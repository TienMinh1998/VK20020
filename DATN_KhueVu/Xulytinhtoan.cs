using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN_KhueVu
{
   public class Xulytinhtoan
    {

        public static double tinhtoan_IS(double b_mm, double h_mm, double ho_mm, double a_mm, double ut)
        {

            try
            {
                double b_m = b_mm / 1000;
                double h_m = h_mm / 1000;
                double ho_m = ho_mm / 1000;
                double a_m = a_mm / 1000;

                double ketqua = Math.Round((ut * b_m * ho_m) * Math.Pow((0.5 * h_m - a_m), 2), 6)/100;
                return ketqua;
            }
            catch (Exception)
            {
                return 0;
            }


        }

        // độ lệch tâm ngẫu nhiên :
        /// <summary>
        /// 
        /// </summary>
        /// <param name="h">Chiều cao tiết diện</param>
        /// <param name="H">Chiều cao của của cột</param>
        /// <returns></returns>
        public static double DoLechTamNgauNhien(double h, double H)
        {
            // lấy min của 3 kết quả : h/30, H/600 và 10.
            try
            {
                // Chiều cao của cột.
                double ketqua = (h / 30) > (H / 600) ? (h / 30) : (H / 600);
               return Math.Round((ketqua > 10 ? ketqua : 10), 2);
               
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public static double TinhToanCOtTHep(double p_L,double p_b, double p_H, double p_a,double Hs_uon_doc,double p_ut, double p_m, double p_n, double p_mtt, double p_ntt)
        {
            double L, Lo, hs_uon, ho, H, a, I, IS, b, ut;          // L,Hs_uon,H,a,b,ut   
            double m, n, e1, ea, e0, ML, Ml1, mtt, ntt;     // m, n,mtt,ntt
            double phi, xichma_e, kb;                       // Thông Số Tính Toán
            double D, Ks, Es, Eb, Ncr;                      // Es , Eb truyền vào
            double _n, ms, ts;                              // Thông Số Tính Toán
            double _e;                                      // Thông Số Tính Toán
            double x1, yb;
            double ax2;

            b = p_b;
            H = p_H;
            a = p_a;

            // Tính Ho;         
            ho = H - a;
            ho = Math.Round(ho, 3);
            // Tính Lo :
            hs_uon = Hs_uon_doc;
            L = p_L;
            Lo = L * hs_uon;
            Lo = Math.Round(Lo, 3);
        
            // TÍnh Momen quán tính Cho Bê tông: 
            I = (b * Math.Pow(H, 3)) / 12;
            I = I / 1000000000000; // đổi momen quán tính ra mét
            I = Math.Round(I, 6);

            // Tính momen quán tính cho cốt thép :
            ut = p_ut;
            IS = Xulytinhtoan.tinhtoan_IS(b, H, ho, a, ut);

            // Tính toán e1 <Độ lệch tâm tĩnh học>: 
            m = p_m;
            n = p_n;
            e1 = m / n;
            e1 = e1 * 1000;
            e1 = Math.Round(e1, 4);

            // Tính toán ea : 
            double chieucaocot = p_L;
            ea = Xulytinhtoan.DoLechTamNgauNhien(H, chieucaocot);
        

            e0 = Math.Max(e1, ea);

            // Tính Ml1 và Ml : 
            mtt = p_mtt;
            ntt = p_ntt;


            Ml1 = mtt + ntt * (0.5 * H / 1000 - a / 1000);
            ML = m + n * (0.5 * H / 1000 - a / 1000);
            phi = Math.Round((1 + Ml1 / ML), 2);          
            // Tính toán xich ma  e :

            xichma_e = e0 / H;
            xichma_e = Math.Round(xichma_e, 3);
      
            // TÍnh Kb : 
            kb = 0.15 / (phi * (0.3 + xichma_e));
            kb = Math.Round(kb, 3);
        
            // Tính Toán D
            Ks = 0.7;
            Eb = Data.BT.Eb;
            Es = 2 * Math.Pow(10, 8);
            D = kb * Eb * Math.Pow(10, 3) * I + Ks * Es * IS;

            // Tính Toán Ncr
            double pi = Math.PI;
            Ncr = (Math.Pow(pi, 2) * D) / (Lo / 1000);

            // Tính Toán Neta : 
            ms = 1 - (n / Ncr);
            ts = 1;
            _n = ts / ms;
            _n = Math.Round(_n, 2); // làm tròn 2 chữ số                                  
            _e = e0 * _n + ((ho - a) / 2); // áp dụng công thức
            _e = Math.Round(_e, 2); // làm tròn

            // Xác định sơ bộ chiều cao vùng nén

            yb = 1;
            x1 = n / (yb * Data.BT.Rb * Math.Pow(10, 3) * b / 1000); // đổi sang đơn vị Kn/m2 nên nhân với 10^3
            x1 = Math.Round(x1, 3);
            x1 = x1 * 100;

            // 2 lần a; 
            ax2 = a / 10 * 2;
            double ErxHo = 0.5333 * ho / 10;
            ErxHo = Math.Round(ErxHo, 6);

            // Đây là trường hợp đặc biêt
            #region "Trường hợp tính cốt thép lệch tâm bé"

            if (x1 < ax2)
            {
                // trường hơp đặc biệt 2

                #region "Tinhs E'" 
                //----------------------------- TÍNH  e'---------------------------------------- : 
                double e_phay;
                e_phay = _e - ho + a;
                e_phay = e_phay / 10; // đổi sang cm;    
                //--------------------------------------------------------------------------------;
                #endregion
                // TÍNH Za : 
                double za;
                za = (ho / 10) - (a / 10);
                // TÍnh diện Tích của cố thép :
                double As, As_phay, Rs, NN;
                Rs = Data.CT.Rs;
                As = (n * e_phay) / (Rs * Math.Pow(10, 3) * za);
                As = As * 10000; // đổi từ m2 sang cm2
                MessageBox.Show(As.ToString());
                // TÍnh hàm lượng cót thép :
                double L_divide_H = Lo / (H);
                double u_min;
                double U0;
                double u;
                if (L_divide_H < 5)
                {
                    u_min = 0.1;
                }
                else if (L_divide_H > 25)
                {
                    u_min = 0.25;
                }
                else
                {
                    // Nội suy : 
                    u_min = NoisuyUmin(L_divide_H);
                }
                U0 = 2 * u_min;
                u = (As * 2) / (b / 10 * ho / 10) * 100; // nhân 100 để đổi ra phần trăm

                if (u < 6)
                {
                    return As * 2;
                }
                else
                {
                    return 0; // cần tăng tiết diện
                }
            }
            #endregion

            #region "Trường hợp Tính Cốt Thép lệch tâm lớn"

            if (ax2 < x1 && x1 < ErxHo)
            {
                double x = x1;
                double e_phay;
                e_phay = _e - ho + a;
                e_phay = e_phay / 10; // đổi sang cm;                                         //--------------------------------------------------------------------------------
                // TÍNH Za : 
                double za;
                za = (ho / 10) - (a / 10);
                // TÍnh diện Tích của cố thép :
                double As, As_phay, Rs, NN;
                Rs = Data.CT.Rs;
                double ts1, ms1;
                ts1 = Data.BT.Rb * Math.Pow(10, 3) * (b / 1000) * (ho / 1000) * (_e / 1000 + 0.5 * x / 100 - ho / 1000);
                ms1 = Rs * Math.Pow(10, 3) * za / 100;
                As_phay = (ts1 / ms1);
                As_phay = As_phay * 10000;  // để đổi ra cm2
                double L_divide_H = Lo / (H);
                double u_min;
                double U0;
                double u;
                if (L_divide_H < 5)
                {
                    u_min = 0.1;
                }
                else if (L_divide_H > 25)
                {
                    u_min = 0.25;
                }
                else
                {
                    // Nội suy : 
                    u_min = NoisuyUmin(L_divide_H);
                }
                U0 = 2 * u_min;
                u = (As_phay * 2) / (b / 10 * ho / 10) * 100; // nhân 100 để đổi ra phần trăm

                if (u < 6)
                {
                    return As_phay * 2;
                }
                else
                {
                    return 0; // Cần tăng tiết diện

                }
            }
            #endregion

            return 0;
        }
        // Đưa vào số liệu và tính toán

        public static double NoisuyUmin(double x)
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
