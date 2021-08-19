
namespace DATN_KhueVu
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_home = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ChonVatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tiếtDiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_main = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_home,
            this.btn_ChonVatLieu,
            this.tiếtDiệnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_home
            // 
            this.btn_home.Image = global::DATN_KhueVu.Properties.Resources.home_icon;
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(68, 20);
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_ChonVatLieu
            // 
            this.btn_ChonVatLieu.Image = global::DATN_KhueVu.Properties.Resources.Icon_Cotlechtamphang;
            this.btn_ChonVatLieu.Name = "btn_ChonVatLieu";
            this.btn_ChonVatLieu.Size = new System.Drawing.Size(204, 20);
            this.btn_ChonVatLieu.Text = "Nhập Liệu Cột Lệch Tâm Phẳng.";
            this.btn_ChonVatLieu.Click += new System.EventHandler(this.btn_ChonVatLieu_Click);
            // 
            // tiếtDiệnToolStripMenuItem
            // 
            this.tiếtDiệnToolStripMenuItem.Image = global::DATN_KhueVu.Properties.Resources.Icon_lechtamxien;
            this.tiếtDiệnToolStripMenuItem.Name = "tiếtDiệnToolStripMenuItem";
            this.tiếtDiệnToolStripMenuItem.Size = new System.Drawing.Size(201, 20);
            this.tiếtDiệnToolStripMenuItem.Text = "Tính Toán Cột Lệch Tâm Phẳng.";
            // 
            // pn_main
            // 
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 24);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1079, 565);
            this.pn_main.TabIndex = 1;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 589);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "Đồ Án Tốt Nghiệp Vũ Đình Khuê";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem btn_home;
        public System.Windows.Forms.ToolStripMenuItem btn_ChonVatLieu;
        public System.Windows.Forms.ToolStripMenuItem tiếtDiệnToolStripMenuItem;
        public System.Windows.Forms.Panel pn_main;
    }
}

