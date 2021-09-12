using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_ViDu2
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "https://www.facebook.com/tuantrong18082001/";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cbbMaSo.SelectedItem = this.cbbMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDSMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMHDay.Items.Add(lbDSMH.SelectedItems[i]);
                this.lbDSMH.Items.Remove(lbDSMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.cbbMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);
            
            foreach (object ob in this.lbMHDay.Items)
                this.lbDSMH.Items.Add(ob);
                this.lbMHDay.Items.Clear();
            
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cbbMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;
            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
                gv.NgoaiNgu = ngoaingu.Split(';');
                DanhMucMonHoc mh = new DanhMucMonHoc();
                foreach (object ob in lbMHDay.Items)
                    mh.Them(new MonHoc(ob.ToString()));
                    gv.dsMonHoc = mh;
                
                return gv;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMHDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDSMH.Items.Add(lbMHDay.SelectedItems[i]);
                this.lbMHDay.Items.Remove(lbMHDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DanhSachGiaoVien dialog = new DanhSachGiaoVien();
            dialog.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmThongTinGiaoVien dialog = new frmThongTinGiaoVien();
            dialog.ShowDialog();
        }
    }
}
