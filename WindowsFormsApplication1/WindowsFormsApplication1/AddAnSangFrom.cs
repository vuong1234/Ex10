using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddAnSangFrom : Form
    {
        public AddAnSangFrom()
        {
            InitializeComponent();
            this.btnThemMoi.Click += btnThemMoi_Click;
        }

        void btnThemMoi_Click(object sender, EventArgs e)
        {
            var TenMon = this.txtTenMon.Text;
            var giaTien = int.Parse(this.txtGiaTien.Text);
            var anSang = new AnSang();
            anSang.TenMon = TenMon;
            anSang.Giatien = giaTien;

            var db = new QuanAnEntities();
            db.AnSangs.Add(anSang);
            db.SaveChanges();

            MessageBox.Show("Them mon an thanh cong !!");
            this.Close();


        }
    }
}
