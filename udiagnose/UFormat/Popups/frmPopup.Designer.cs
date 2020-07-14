namespace UDiagnose.Forms
{
    partial class frmPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopup));
            this.txtVolumeLabel = new System.Windows.Forms.TextBox();
            this.btnAccept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chkQuickFormat = new System.Windows.Forms.CheckBox();
            this.cmbFileSystem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAllocationSize = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCompression = new System.Windows.Forms.CheckBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAllocationSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVolumeLabel
            // 
            this.txtVolumeLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumeLabel.Location = new System.Drawing.Point(134, 70);
            this.txtVolumeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVolumeLabel.Name = "txtVolumeLabel";
            this.txtVolumeLabel.Size = new System.Drawing.Size(173, 25);
            this.txtVolumeLabel.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(58, 275);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnAccept.Size = new System.Drawing.Size(105, 31);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Values.Text = "Accept";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter drive name.";
            // 
            // chkQuickFormat
            // 
            this.chkQuickFormat.AutoSize = true;
            this.chkQuickFormat.Checked = true;
            this.chkQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuickFormat.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuickFormat.Location = new System.Drawing.Point(134, 161);
            this.chkQuickFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkQuickFormat.Name = "chkQuickFormat";
            this.chkQuickFormat.Size = new System.Drawing.Size(104, 20);
            this.chkQuickFormat.TabIndex = 3;
            this.chkQuickFormat.Text = "Quick Format";
            this.chkQuickFormat.UseVisualStyleBackColor = true;
            // 
            // cmbFileSystem
            // 
            this.cmbFileSystem.DropDownWidth = 227;
            this.cmbFileSystem.Items.AddRange(new object[] {
            "NTFS",
            "FAT32",
            "exFAT"});
            this.cmbFileSystem.Location = new System.Drawing.Point(134, 103);
            this.cmbFileSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFileSystem.Name = "cmbFileSystem";
            this.cmbFileSystem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.cmbFileSystem.Size = new System.Drawing.Size(173, 21);
            this.cmbFileSystem.TabIndex = 4;
            this.cmbFileSystem.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Volume Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "File System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Allocation unit size";
            // 
            // cmbAllocationSize
            // 
            this.cmbAllocationSize.DropDownWidth = 227;
            this.cmbAllocationSize.Items.AddRange(new object[] {
            "512 bytes",
            "1024 bytes",
            "2048 bytes",
            "4096 bytes",
            "8192 bytes",
            "16 kilobytes",
            "32 kilobytes",
            "64 kilobytes",
            "128 kilobytes",
            "256 kilobytes",
            "512 kilobytes",
            "1024 kilobytes",
            "2048 kilobytes"});
            this.cmbAllocationSize.Location = new System.Drawing.Point(134, 132);
            this.cmbAllocationSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAllocationSize.Name = "cmbAllocationSize";
            this.cmbAllocationSize.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.cmbAllocationSize.Size = new System.Drawing.Size(173, 21);
            this.cmbAllocationSize.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Please wait after the the page closes for the success popup.";
            // 
            // chkCompression
            // 
            this.chkCompression.AutoSize = true;
            this.chkCompression.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompression.Location = new System.Drawing.Point(134, 189);
            this.chkCompression.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCompression.Name = "chkCompression";
            this.chkCompression.Size = new System.Drawing.Size(231, 20);
            this.chkCompression.TabIndex = 10;
            this.chkCompression.Text = "Enable file and folder compression";
            this.chkCompression.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnCancel.Size = new System.Drawing.Size(105, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Format Details";
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkCompression);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAllocationSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFileSystem);
            this.Controls.Add(this.chkQuickFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtVolumeLabel);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPopup";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Details";
            this.Load += new System.EventHandler(this.frmPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAllocationSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtVolumeLabel;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAccept;
        private System.Windows.Forms.CheckBox chkQuickFormat;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbFileSystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbAllocationSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCompression;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private System.Windows.Forms.Label label6;
    }
}