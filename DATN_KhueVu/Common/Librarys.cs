using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN_KhueVu.Common
{
    class Librarys
    {
        public static void setView(Form _frm, frm_main _frm_main)
        {

            _frm_main.pn_main.Controls.Clear();
            _frm.TopLevel = false;
            _frm.Dock = DockStyle.Fill;
            _frm_main.pn_main.Controls.Add(_frm);
            _frm.Show();
        }
    }
}
