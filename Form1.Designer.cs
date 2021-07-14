namespace DatabaseTestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.blbSelrctCamera = new System.Windows.Forms.Label();
            this.comboBoxSelectCamera = new System.Windows.Forms.ComboBox();
            this.pictureBoxScanBarCode = new System.Windows.Forms.PictureBox();
            this.btnScanProduct = new System.Windows.Forms.Button();
            this.textBoxShowBarcode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.textBoxEnterProd = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGetProduct.Location = new System.Drawing.Point(641, 35);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(147, 98);
            this.btnGetProduct.TabIndex = 0;
            this.btnGetProduct.Text = "Get Product Details";
            this.btnGetProduct.UseVisualStyleBackColor = false;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(645, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 244);
            this.listBox1.TabIndex = 1;
            // 
            // blbSelrctCamera
            // 
            this.blbSelrctCamera.AutoSize = true;
            this.blbSelrctCamera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.blbSelrctCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbSelrctCamera.Location = new System.Drawing.Point(36, 18);
            this.blbSelrctCamera.Name = "blbSelrctCamera";
            this.blbSelrctCamera.Size = new System.Drawing.Size(297, 44);
            this.blbSelrctCamera.TabIndex = 2;
            this.blbSelrctCamera.Text = "Select Camera:";
            // 
            // comboBoxSelectCamera
            // 
            this.comboBoxSelectCamera.FormattingEnabled = true;
            this.comboBoxSelectCamera.Location = new System.Drawing.Point(353, 35);
            this.comboBoxSelectCamera.Name = "comboBoxSelectCamera";
            this.comboBoxSelectCamera.Size = new System.Drawing.Size(270, 24);
            this.comboBoxSelectCamera.TabIndex = 3;
            // 
            // pictureBoxScanBarCode
            // 
            this.pictureBoxScanBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxScanBarCode.Location = new System.Drawing.Point(34, 65);
            this.pictureBoxScanBarCode.Name = "pictureBoxScanBarCode";
            this.pictureBoxScanBarCode.Size = new System.Drawing.Size(589, 117);
            this.pictureBoxScanBarCode.TabIndex = 4;
            this.pictureBoxScanBarCode.TabStop = false;
            // 
            // btnScanProduct
            // 
            this.btnScanProduct.BackColor = System.Drawing.Color.YellowGreen;
            this.btnScanProduct.Location = new System.Drawing.Point(34, 188);
            this.btnScanProduct.Name = "btnScanProduct";
            this.btnScanProduct.Size = new System.Drawing.Size(589, 59);
            this.btnScanProduct.TabIndex = 5;
            this.btnScanProduct.Text = "Scan Product";
            this.btnScanProduct.UseVisualStyleBackColor = false;
            this.btnScanProduct.Click += new System.EventHandler(this.btnScanProduct_Click);
            // 
            // textBoxShowBarcode
            // 
            this.textBoxShowBarcode.Location = new System.Drawing.Point(145, 260);
            this.textBoxShowBarcode.Name = "textBoxShowBarcode";
            this.textBoxShowBarcode.Size = new System.Drawing.Size(105, 22);
            this.textBoxShowBarcode.TabIndex = 6;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(29, 319);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(212, 25);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Enter Product Name:";
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveProduct.Location = new System.Drawing.Point(283, 253);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(340, 130);
            this.btnSaveProduct.TabIndex = 9;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // textBoxEnterProd
            // 
            this.textBoxEnterProd.Location = new System.Drawing.Point(27, 361);
            this.textBoxEnterProd.Name = "textBoxEnterProd";
            this.textBoxEnterProd.Size = new System.Drawing.Size(223, 22);
            this.textBoxEnterProd.TabIndex = 10;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.SystemColors.Info;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(29, 257);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(99, 25);
            this.lblBarcode.TabIndex = 11;
            this.lblBarcode.Text = "Barcode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.textBoxEnterProd);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.textBoxShowBarcode);
            this.Controls.Add(this.btnScanProduct);
            this.Controls.Add(this.pictureBoxScanBarCode);
            this.Controls.Add(this.comboBoxSelectCamera);
            this.Controls.Add(this.blbSelrctCamera);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGetProduct);
            this.Name = "Form1";
            this.Text = "CameraBarcodeScanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScanBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetProduct;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label blbSelrctCamera;
        private System.Windows.Forms.ComboBox comboBoxSelectCamera;
        private System.Windows.Forms.PictureBox pictureBoxScanBarCode;
        private System.Windows.Forms.Button btnScanProduct;
        private System.Windows.Forms.TextBox textBoxShowBarcode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.TextBox textBoxEnterProd;
        private System.Windows.Forms.Label lblBarcode;
    }
}

