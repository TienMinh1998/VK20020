using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATN_KhueVu.Model;
using DATN_KhueVu.CotThepSUdung;

namespace DATN_KhueVu.Views
{
    public partial class View_ChonVatLieu : Form
    {



        public View_ChonVatLieu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbb_betong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index_betong = cbb_betong.SelectedIndex;
            switch (index_betong)
            {
                case 0:
                    Data.BT = new B12_5();
                    HienThiThongSoBeTong(Data.BT);
                    break;
                case 1:
                    Data.BT = new B15();
                    HienThiThongSoBeTong(Data.BT);
                    break;
                case 2:
                    Data.BT = new B20();
                    HienThiThongSoBeTong(Data.BT);
                    break;
                case 3:
                    Data.BT = new B25();
                    HienThiThongSoBeTong(Data.BT);
                    break;
                case 4:
                    Data.BT = new B30();
                    HienThiThongSoBeTong(Data.BT);
                    break;
                default:
                    break;
            }
        }



        private void cbb_cotthep_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index_cotthep = cbb_cotthep.SelectedIndex;
            switch (index_cotthep)
            {
                case 0:
                    Data.CT = new CIAI();
                    HienThiThongSoCotThep(Data.CT);
                    break;
                case 1:
                    Data.CT = new CIIAII();
                    HienThiThongSoCotThep(Data.CT);
                    break;
                case 2:
                    Data.CT = new CIIIAIII();
                    HienThiThongSoCotThep(Data.CT);
                    break;
                case 3:

                    break;
                case 4:

                    break;
                default:
                    break;
            }
        }



        // Các hàm hỗ trợ:
        private void HienThiThongSoBeTong(Betong BT)
        {
            txt_EB.Text = BT.Eb.ToString();
            txt_RB.Text = BT.Rb.ToString();
            txt_RBT.Text = BT.Rbt.ToString();

        }
        private void HienThiThongSoCotThep(CotThep CT)
        {
            txt_Es.Text = CT.Es.ToString();
            txt_Rs.Text = CT.Rs.ToString();
            txt_Rsc.Text = CT.Rsc.ToString();

        }

        private void View_ChonVatLieu_Load(object sender, EventArgs e)
        {
            cbb_betong.SelectedIndex = 0;
            cbb_cotthep.SelectedIndex = 0;

        }

        private void txt_L_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data.BatBuocNhapSo(sender, e);

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txt_L.Text);
            double B = double.Parse(txt_b.Text);
            double H = double.Parse(txt_h.Text);
            double a = double.Parse(txt_a.Text);
            double hs_uon = double.Parse(txt_hs_uon.Text);
            double ut = double.Parse(txt_u.Text);
            double m = double.Parse(txt_m.Text);
            double n = double.Parse(txt_n.Text);
            double mtt = double.Parse(txt_mtt.Text);
            double ntt = double.Parse(txt_ntt.Text);


            double result = 0;

            result = Xulytinhtoan.TinhToanCOtTHep(L, B, H, a, hs_uon, ut, m, n, mtt, ntt);
            MessageBox.Show(result.ToString());

            //double L, Lo, hs_uon, ho, H, a, I, IS, b, ut;          // L,Hs_uon,H,a,b,ut   
            //double m, n, e1, ea, e0, ML, Ml1, mtt, ntt;     // m, n,mtt,ntt
            //double phi, xichma_e, kb;                       // Thông Số Tính Toán
            //double D, Ks, Es, Eb, Ncr;                      // Es , Eb truyền vào
            //double _n, ms, ts;                              // Thông Số Tính Toán
            //double _e;                                      // Thông Số Tính Toán
            //double x1, yb;
            //double ax2;

            //b = double.Parse(txt_b.Text);
            //H = double.Parse(txt_h.Text);
            //a = double.Parse(txt_a.Text);

            //// Tính Ho;         
            //ho = H - a;
            //ho = Math.Round(ho, 3);
            //txt_ho_tinhtoan.Text = ho.ToString();
            //Doimauchu(txt_ho_tinhtoan); // nếu nó âm thì đổi sang màu đỏ

            //// Tính Lo :
            //hs_uon = double.Parse(txt_hs_uon.Text);
            //L = double.Parse(txt_L.Text);
            //Lo = L * hs_uon;
            //Lo = Math.Round(Lo, 3);
            //txt_lo.Text = Lo.ToString();

            //// TÍnh Momen quán tính Cho Bê tông: 
            //I = (b * Math.Pow(H, 3)) / 12;
            //I = I / 1000000000000; // đổi momen quán tính ra mét
            //I = Math.Round(I, 6);
            //txt_momenquantinh.Text = I.ToString();

            //// Tính momen quán tính cho cốt thép :
            //ut = double.Parse(txt_u.Text);
            //IS = Xulytinhtoan.tinhtoan_IS(b, H, ho, a, ut);
            //txt_IS.Text = IS.ToString();

            //// Tính toán e1 <Độ lệch tâm tĩnh học>: 
            //m = double.Parse(txt_m.Text);
            //n = double.Parse(txt_n.Text);
            //e1 = m / n;
            //e1 = e1 * 1000;
            //e1 = Math.Round(e1, 4);
            //txt_e1.Text = e1.ToString();

            //// Tính toán ea : 
            //double chieucaocot = double.Parse(txt_L.Text);
            //ea = Xulytinhtoan.DoLechTamNgauNhien(H, chieucaocot);
            //txt_ea.Text = ea.ToString();

            //e0 = Math.Max(e1, ea);
            //txt_eo.Text = e0.ToString();
            //// Tính Ml1 và Ml : 
            //mtt = double.Parse(txt_mtt.Text);
            //ntt = double.Parse(txt_ntt.Text);

            //Ml1 = mtt + ntt * (0.5 * H / 1000 - a / 1000);
            //ML = m + n * (0.5 * H / 1000 - a / 1000);
            //phi = Math.Round((1 + Ml1 / ML), 2);
            //txt_phi.Text = phi.ToString();
            //// Tính toán xich ma  e :

            //xichma_e = e0 / H;
            //xichma_e = Math.Round(xichma_e, 3);
            //txt_xichma_e.Text = xichma_e.ToString();

            //// TÍnh Kb : 
            //kb = 0.15 / (phi * (0.3 + xichma_e));
            //kb = Math.Round(kb, 3);
            //txt_kb.Text = kb.ToString();
            //// Tính Toán D
            //Ks = 0.7;
            //Eb = Data.BT.Eb;
            //Es = 2 * Math.Pow(10, 8);
            //D = kb * Eb * Math.Pow(10, 3) * I + Ks * Es * IS;

            //// Tính Toán Ncr
            //double pi = Math.PI;
            //Ncr = (Math.Pow(pi, 2) * D) / (Lo / 1000);

            //// Tính Toán Neta : 
            //ms = 1 - (n / Ncr);
            //ts = 1;
            //_n = ts / ms;
            //_n = Math.Round(_n, 2); // làm tròn 2 chữ số                                  
            //_e = e0 * _n + ((ho - a) / 2); // áp dụng công thức
            //_e = Math.Round(_e, 2); // làm tròn

            //// Xác định sơ bộ chiều cao vùng nén

            //yb = 1;
            //x1 = n / (yb * Data.BT.Rb * Math.Pow(10, 3) * b / 1000); // đổi sang đơn vị Kn/m2 nên nhân với 10^3
            //x1 = Math.Round(x1, 3);
            //x1 = x1 * 100;

            //// 2 lần a; 
            //ax2 = a / 10 * 2;
            //double ErxHo = 0.5333 * ho / 10;
            //ErxHo = Math.Round(ErxHo, 6);

            //// Đây là trường hợp đặc biêt
            //#region "Trường hợp tính cốt thép lệch tâm bé"

            //if (x1 < ax2)
            //{
            //    // trường hơp đặc biệt 2

            //    #region "Tinhs E'" 
            //    //----------------------------- TÍNH  e'---------------------------------------- : 
            //    double e_phay;
            //    e_phay = _e - ho + a;
            //    e_phay = e_phay / 10; // đổi sang cm;    
            //    //--------------------------------------------------------------------------------;
            //    #endregion
            //    // TÍNH Za : 
            //    double za;
            //    za = (ho / 10) - (a / 10);
            //    // TÍnh diện Tích của cố thép :
            //    double As, As_phay, Rs, NN;
            //    Rs = Data.CT.Rs;
            //    As = (n * e_phay) / (Rs * Math.Pow(10, 3) * za);
            //    As = As * 10000; // đổi từ m2 sang cm2
            //    MessageBox.Show(As.ToString());
            //    // TÍnh hàm lượng cót thép :
            //    double L_divide_H = Lo / (H);
            //    double u_min;
            //    double U0;
            //    double u;
            //    if (L_divide_H < 5)
            //    {
            //        u_min = 0.1;
            //    }
            //    else if (L_divide_H > 25)
            //    {
            //        u_min = 0.25;
            //    }
            //    else
            //    {
            //        // Nội suy : 
            //        u_min = NoisuyUmin(L_divide_H);
            //    }
            //    U0 = 2 * u_min;
            //    u = (As * 2) / (b / 10 * ho / 10) * 100; // nhân 100 để đổi ra phần trăm

            //    if (u < 6)
            //    {
            //        MessageBox.Show("Thỏa mãn");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lượng cốt thép quá lớn, cần tăng tiết diện");

            //    }


            //}
            //#endregion

            //#region "Trường hợp Tính Cốt Thép lệch tâm lớn"

            //if (ax2 < x1 && x1 < ErxHo)
            //{
            //    double x = x1;
            //    double e_phay;
            //    e_phay = _e - ho + a;
            //    e_phay = e_phay / 10; // đổi sang cm;                                         //--------------------------------------------------------------------------------
            //    // TÍNH Za : 
            //    double za;
            //    za = (ho / 10) - (a / 10);
            //    // TÍnh diện Tích của cố thép :
            //    double As, As_phay, Rs, NN;
            //    Rs = Data.CT.Rs;
            //    double ts1, ms1;
            //    ts1 = Data.BT.Rb * Math.Pow(10, 3) * (b / 1000) * (ho / 1000) * (_e / 1000 + 0.5 * x / 100 - ho / 1000);
            //    ms1 = Rs * Math.Pow(10, 3) * za / 100;
            //    As_phay = (ts1 / ms1);
            //    As_phay = As_phay * 10000;  // để đổi ra cm2
            //    double L_divide_H = Lo / (H);
            //    double u_min;
            //    double U0;
            //    double u;
            //    if (L_divide_H < 5)
            //    {
            //        u_min = 0.1;
            //    }
            //    else if (L_divide_H > 25)
            //    {
            //        u_min = 0.25;
            //    }
            //    else
            //    {
            //        // Nội suy : 
            //        u_min = NoisuyUmin(L_divide_H);
            //    }
            //    U0 = 2 * u_min;
            //    u = (As_phay * 2) / (b / 10 * ho / 10) * 100; // nhân 100 để đổi ra phần trăm

            //    if (u < 6)
            //    {
            //        MessageBox.Show("Thỏa mãn");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lượng cốt thép quá lớn, cần tăng tiết diện");

            //    }
            //}
            //#endregion

        }

        private void txt_L_TextChanged(object sender, EventArgs e)
        {

        }

        public void Doimauchu(Label bl)
        {
            double values = double.Parse(bl.Text);
            if (values<0)
            {
                bl.ForeColor = Color.Red;
            }
            else
            {
                bl.ForeColor = Color.Green;
            }
        }
        public double NoisuyUmin(double x)
        {
            try
            {
                double ts, ms;
                ts = 0.5 * (x - 5) + 0.1 * (25 - x);
                ms = 25 - 5;
                return Math.Round((ts / ms), 3);
            }
            catch (Exception)
            {
                return 0;
               
            }
                 

        }
     
    }



}
