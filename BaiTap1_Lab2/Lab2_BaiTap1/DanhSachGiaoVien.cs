using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_ViDu2
{
    public partial class DanhSachGiaoVien : Form
    {
        private List<GiaoVien> DSGV;
        public DanhSachGiaoVien()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
                ListViewItem item = new ListViewItem(txtMaGV.Text);
                item.SubItems.Add(txtTenGV.Text);
                item.SubItems.Add(txtSDT.Text);
                lvDanhSachGiaoVien.Items.Add(item);

        }

        private void DanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            DSGV = new List<GiaoVien>();
        }
    }
}
