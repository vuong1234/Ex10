namespace WindowsFormsApplication1
{
    partial class AddAnSangFrom
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
            this.j = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // j
            // 
            this.j.AutoSize = true;
            this.j.Location = new System.Drawing.Point(29, 31);
            this.j.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(64, 17);
            this.j.TabIndex = 0;
            this.j.Text = "Ten Mon";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(29, 69);
            this.t.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(57, 17);
            this.t.TabIndex = 1;
            this.t.Text = "Gia tien";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(152, 34);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(146, 23);
            this.txtTenMon.TabIndex = 2;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(152, 69);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(146, 23);
            this.txtGiaTien.TabIndex = 3;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(152, 140);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Chot nhe";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // AddAnSangFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 200);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.t);
            this.Controls.Add(this.j);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddAnSangFrom";
            this.Text = "AddAnSangFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label j;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnThemMoi;
    }
}