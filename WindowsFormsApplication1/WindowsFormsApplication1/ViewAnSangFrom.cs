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
    public partial class ViewAnSangFrom : Form
    {
        public ViewAnSangFrom()
        {
            InitializeComponent();
            this.Load += ViewAnSangFrom_Load;
            this.btnAddAnsang.Click += btnAddAnsang_Click;
        }

        void btnAddAnsang_Click(object sender, EventArgs e)
        {
            var from = new AddAnSangFrom();
            from.ShowDialog();
            this.ShowAnSangList();

        }

        void ViewAnSangFrom_Load(object sender, EventArgs e)
        {
            this.ShowAnSangList();
        }
        private void ShowAnSangList()
        {
            QuanAnEntities db = new QuanAnEntities();
            var list = db.AnSangs.ToArray();
            this.grdAnsang.DataSource = list;
        }
    }
}
