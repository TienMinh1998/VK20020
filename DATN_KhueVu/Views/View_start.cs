using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATN_KhueVu.Common;

namespace DATN_KhueVu.Views
{
    public partial class View_start : Form
    {
        public View_start()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_nhap_lieu_Click(object sender, EventArgs e)
        {
            View_ChonVatLieu view_ChonVatLieu = new View_ChonVatLieu();
            Librarys.setView(view_ChonVatLieu, frm_main.Intance);

        }
    }
}
