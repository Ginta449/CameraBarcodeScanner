using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace DatabaseTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection _filerInfo;
        VideoCaptureDevice _videoCapture;

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.ConnectionString = "yourconnectionstring;";
                builder.InitialCatalog = "ProductExample";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    String sql = "SELECT * FROM Product";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    listBox1.Items.Add(reader[i].ToString());
                                }
                                   
                             }
                                
                            }
                        }
                    connection.Close();
                    }
                
            }
            catch (SqlException a)
            {
                MessageBox.Show("Error!" + a);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _filerInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo myDevice in _filerInfo)
            {
                comboBoxSelectCamera.Items.Add(myDevice.Name);
            }
        }

        private void btnScanProduct_Click(object sender, EventArgs e)
        {
            _videoCapture = new VideoCaptureDevice(_filerInfo[comboBoxSelectCamera.SelectedIndex].MonikerString);
            _videoCapture.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCapture.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader scanner = new BarcodeReader();
            var result = scanner.Decode(bitmap);
            if (result != null)
            {
                textBoxShowBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    textBoxShowBarcode.Text = result.ToString();
                }));
            }

            pictureBoxScanBarCode.Image = bitmap;

           
            }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_videoCapture != null)
            {
                if (_videoCapture.IsRunning)
                {
                    _videoCapture.Stop();
                }
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(textBoxEnterProd.Text, textBoxShowBarcode.Text);
            try
            {
                string query = "INSERT INTO Product(Id, productName, productBarcode) VALUES('" + Product.Id + "', '" + newProduct.productName + "', '" + newProduct.productBarcode + "'); ";

                using (SqlConnection conn = new SqlConnection("yourconnectionstring;"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                   // conn.Close();
                }


            }
            catch
            {
                MessageBox.Show("Error!");
            }
          
            MessageBox.Show(newProduct.ToString());
        }
    }
}
