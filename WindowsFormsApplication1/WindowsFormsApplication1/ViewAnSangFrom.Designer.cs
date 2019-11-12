namespace WindowsFormsApplication1
{
    partial class ViewAnSangFrom
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
            this.grdAnsang = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddAnsang = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnsang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdAnsang
            // 
            this.grdAnsang.AllowUserToAddRows = false;
            this.grdAnsang.AllowUserToDeleteRows = false;
            this.grdAnsang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnsang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAnsang.Location = new System.Drawing.Point(0, 24);
            this.grdAnsang.Name = "grdAnsang";
            this.grdAnsang.ReadOnly = true;
            this.grdAnsang.Size = new System.Drawing.Size(477, 237);
            this.grdAnsang.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAnsang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddAnsang
            // 
            this.btnAddAnsang.Name = "btnAddAnsang";
            this.btnAddAnsang.Size = new System.Drawing.Size(94, 20);
            this.btnAddAnsang.Text = "Them mon an";
            // 
            // ViewAnSangFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 261);
            this.Controls.Add(this.grdAnsang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewAnSangFrom";
            this.Text = "ViewAnSangFrom";
            ((System.ComponentModel.ISupportInitialize)(this.grdAnsang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAnsang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddAnsang;
    }
}

