namespace UDiagnose.Forms
{
    partial class ErrorCodeForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.grpSearchBy = new System.Windows.Forms.GroupBox();
            this.radDesc = new System.Windows.Forms.RadioButton();
            this.radError = new System.Windows.Forms.RadioButton();
            this.txtGoogleSearch = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.dgDisplay);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(980, 593);
            this.MainPanel.TabIndex = 1;
            // 
            // dgDisplay
            // 
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDisplay.Location = new System.Drawing.Point(0, 86);
            this.dgDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.ReadOnly = true;
            this.dgDisplay.Size = new System.Drawing.Size(980, 507);
            this.dgDisplay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGoogle);
            this.panel1.Controls.Add(this.grpSearchBy);
            this.panel1.Controls.Add(this.txtGoogleSearch);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 86);
            this.panel1.TabIndex = 1;
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(826, 47);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(75, 29);
            this.btnGoogle.TabIndex = 4;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // grpSearchBy
            // 
            this.grpSearchBy.Controls.Add(this.radDesc);
            this.grpSearchBy.Controls.Add(this.radError);
            this.grpSearchBy.Location = new System.Drawing.Point(15, 3);
            this.grpSearchBy.Name = "grpSearchBy";
            this.grpSearchBy.Size = new System.Drawing.Size(329, 38);
            this.grpSearchBy.TabIndex = 3;
            this.grpSearchBy.TabStop = false;
            this.grpSearchBy.Text = "Search By";
            // 
            // radDesc
            // 
            this.radDesc.AutoSize = true;
            this.radDesc.Location = new System.Drawing.Point(207, 14);
            this.radDesc.Name = "radDesc";
            this.radDesc.Size = new System.Drawing.Size(92, 20);
            this.radDesc.TabIndex = 1;
            this.radDesc.TabStop = true;
            this.radDesc.Text = "Description";
            this.radDesc.UseVisualStyleBackColor = true;
            this.radDesc.CheckedChanged += new System.EventHandler(this.radDesc_CheckedChanged);
            // 
            // radError
            // 
            this.radError.AutoSize = true;
            this.radError.Location = new System.Drawing.Point(84, 14);
            this.radError.Name = "radError";
            this.radError.Size = new System.Drawing.Size(91, 20);
            this.radError.TabIndex = 0;
            this.radError.TabStop = true;
            this.radError.Text = "Error Code";
            this.radError.UseVisualStyleBackColor = true;
            this.radError.CheckedChanged += new System.EventHandler(this.radError_CheckedChanged);
            // 
            // txtGoogleSearch
            // 
            this.txtGoogleSearch.Location = new System.Drawing.Point(553, 50);
            this.txtGoogleSearch.Name = "txtGoogleSearch";
            this.txtGoogleSearch.Size = new System.Drawing.Size(258, 25);
            this.txtGoogleSearch.TabIndex = 1;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(65, 50);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(258, 25);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you cannot find your error below please use this area to google your problem f" +
    "urther";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 53);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // ErrorCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 593);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ErrorCodeForm";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorCodeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ErrorCodeForm_FormClosing);
            this.Load += new System.EventHandler(this.ErrorCodeForm_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSearchBy.ResumeLayout(false);
            this.grpSearchBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpSearchBy;
        private System.Windows.Forms.RadioButton radDesc;
        private System.Windows.Forms.RadioButton radError;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.TextBox txtGoogleSearch;
        private System.Windows.Forms.Label label1;
    }
}