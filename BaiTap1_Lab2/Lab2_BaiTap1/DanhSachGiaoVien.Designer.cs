
namespace Lab2_ViDu2
{
    partial class DanhSachGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.lvDanhSachGiaoVien = new System.Windows.Forms.ListView();
            this.lvMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvDanhSachGiaoVien
            // 
            this.lvDanhSachGiaoVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvMa,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDanhSachGiaoVien.GridLines = true;
            this.lvDanhSachGiaoVien.HideSelection = false;
            this.lvDanhSachGiaoVien.Location = new System.Drawing.Point(12, 12);
            this.lvDanhSachGiaoVien.Name = "lvDanhSachGiaoVien";
            this.lvDanhSachGiaoVien.Size = new System.Drawing.Size(378, 426);
            this.lvDanhSachGiaoVien.TabIndex = 0;
            this.lvDanhSachGiaoVien.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachGiaoVien.View = System.Windows.Forms.View.Details;
            // 
            // lvMa
            // 
            this.lvMa.Text = "Mã GV";
            this.lvMa.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên GV";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số ĐT";
            this.columnHeader3.Width = 181;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(415, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên GV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số ĐT";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(480, 85);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(191, 22);
            this.txtMaGV.TabIndex = 6;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(480, 126);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(191, 22);
            this.txtTenGV.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(480, 169);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // DanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvDanhSachGiaoVien);
            this.Name = "DanhSachGiaoVien";
            this.Text = "DanhSachGiaoVien";
            this.Load += new System.EventHandler(this.DanhSachGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDanhSachGiaoVien;
        private System.Windows.Forms.ColumnHeader lvMa;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtSDT;
    }
}