
namespace Lab2_ViDu2
{
    partial class frmThongTinGiaoVien
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
            this.grbTim = new System.Windows.Forms.GroupBox();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdHoTenGV = new System.Windows.Forms.RadioButton();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapMaGV = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grbTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTim
            // 
            this.grbTim.Controls.Add(this.rdSoDT);
            this.grbTim.Controls.Add(this.rdHoTenGV);
            this.grbTim.Controls.Add(this.rdMaGV);
            this.grbTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTim.Location = new System.Drawing.Point(12, 22);
            this.grbTim.Name = "grbTim";
            this.grbTim.Size = new System.Drawing.Size(559, 94);
            this.grbTim.TabIndex = 0;
            this.grbTim.TabStop = false;
            this.grbTim.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Location = new System.Drawing.Point(416, 38);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(127, 24);
            this.rdSoDT.TabIndex = 2;
            this.rdSoDT.TabStop = true;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            // 
            // rdHoTenGV
            // 
            this.rdHoTenGV.AutoSize = true;
            this.rdHoTenGV.Location = new System.Drawing.Point(205, 38);
            this.rdHoTenGV.Name = "rdHoTenGV";
            this.rdHoTenGV.Size = new System.Drawing.Size(80, 24);
            this.rdHoTenGV.TabIndex = 1;
            this.rdHoTenGV.TabStop = true;
            this.rdHoTenGV.Text = "Họ tên";
            this.rdHoTenGV.UseVisualStyleBackColor = true;
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Location = new System.Drawing.Point(6, 38);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(82, 24);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã GV";
            // 
            // txtNhapMaGV
            // 
            this.txtNhapMaGV.Location = new System.Drawing.Point(156, 145);
            this.txtNhapMaGV.Name = "txtNhapMaGV";
            this.txtNhapMaGV.Size = new System.Drawing.Size(306, 22);
            this.txtNhapMaGV.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(496, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 33);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 190);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNhapMaGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTim);
            this.Name = "frmThongTinGiaoVien";
            this.Text = "Tìm thông tin giáo viên";
            this.Load += new System.EventHandler(this.frmThongTinGiaoVien_Load);
            this.grbTim.ResumeLayout(false);
            this.grbTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTim;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdHoTenGV;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapMaGV;
        private System.Windows.Forms.Button btnOk;
    }
}