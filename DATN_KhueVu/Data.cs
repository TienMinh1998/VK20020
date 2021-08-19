using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATN_KhueVu.Model;
using DATN_KhueVu.CotThepSUdung;
using System.Windows.Forms;

namespace DATN_KhueVu
{
   public class Data
    {

        public static void BatBuocNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

       public static Betong BT;
      public static CotThep CT;

    }
}
