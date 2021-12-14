
namespace CDBenhGa.GUI
{
    partial class Luat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSK = new System.Windows.Forms.DataGridView();
            this.MaSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVephai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVetrai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaluat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLuat = new System.Windows.Forms.DataGridView();
            this.MaLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeTrai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VePhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMoKl = new System.Windows.Forms.DataGridView();
            this.MaKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnVT = new System.Windows.Forms.Button();
            this.btnVP = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoKl)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSK);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sự kiện";
            // 
            // dgvSK
            // 
            this.dgvSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSK,
            this.TenSK,
            this.CauHoi});
            this.dgvSK.Location = new System.Drawing.Point(6, 25);
            this.dgvSK.Name = "dgvSK";
            this.dgvSK.ReadOnly = true;
            this.dgvSK.RowHeadersWidth = 62;
            this.dgvSK.RowTemplate.Height = 28;
            this.dgvSK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSK.Size = new System.Drawing.Size(589, 336);
            this.dgvSK.TabIndex = 0;
            this.dgvSK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSK_CellClick);
            // 
            // MaSK
            // 
            this.MaSK.DataPropertyName = "MaSK";
            this.MaSK.HeaderText = "Mã SK";
            this.MaSK.MinimumWidth = 8;
            this.MaSK.Name = "MaSK";
            this.MaSK.ReadOnly = true;
            // 
            // TenSK
            // 
            this.TenSK.DataPropertyName = "TenSK";
            this.TenSK.HeaderText = "Tên SK";
            this.TenSK.MinimumWidth = 8;
            this.TenSK.Name = "TenSK";
            this.TenSK.ReadOnly = true;
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "CauHoi";
            this.CauHoi.HeaderText = "Câu hỏi";
            this.CauHoi.MinimumWidth = 8;
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVephai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVetrai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaluat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(857, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 358);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // txtVephai
            // 
            this.txtVephai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVephai.Location = new System.Drawing.Point(124, 220);
            this.txtVephai.Name = "txtVephai";
            this.txtVephai.Size = new System.Drawing.Size(196, 30);
            this.txtVephai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vế phải";
            // 
            // txtVetrai
            // 
            this.txtVetrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVetrai.Location = new System.Drawing.Point(124, 134);
            this.txtVetrai.Name = "txtVetrai";
            this.txtVetrai.Size = new System.Drawing.Size(196, 30);
            this.txtVetrai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vế trái";
            // 
            // txtMaluat
            // 
            this.txtMaluat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaluat.Location = new System.Drawing.Point(124, 58);
            this.txtMaluat.Name = "txtMaluat";
            this.txtMaluat.Size = new System.Drawing.Size(196, 30);
            this.txtMaluat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã luật";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLuat);
            this.groupBox3.Location = new System.Drawing.Point(12, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 275);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin luật";
            // 
            // dgvLuat
            // 
            this.dgvLuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuat,
            this.VeTrai,
            this.VePhai});
            this.dgvLuat.Location = new System.Drawing.Point(6, 25);
            this.dgvLuat.Name = "dgvLuat";
            this.dgvLuat.ReadOnly = true;
            this.dgvLuat.RowHeadersWidth = 62;
            this.dgvLuat.RowTemplate.Height = 28;
            this.dgvLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuat.Size = new System.Drawing.Size(383, 244);
            this.dgvLuat.TabIndex = 0;
            this.dgvLuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuat_CellClick);
            // 
            // MaLuat
            // 
            this.MaLuat.DataPropertyName = "MaLuat";
            this.MaLuat.HeaderText = "Mã luật";
            this.MaLuat.MinimumWidth = 8;
            this.MaLuat.Name = "MaLuat";
            this.MaLuat.ReadOnly = true;
            // 
            // VeTrai
            // 
            this.VeTrai.DataPropertyName = "VeTrai";
            this.VeTrai.HeaderText = "Vế trái";
            this.VeTrai.MinimumWidth = 8;
            this.VeTrai.Name = "VeTrai";
            this.VeTrai.ReadOnly = true;
            // 
            // VePhai
            // 
            this.VePhai.DataPropertyName = "VePhai";
            this.VePhai.HeaderText = "Vế phải";
            this.VePhai.MinimumWidth = 8;
            this.VePhai.Name = "VePhai";
            this.VePhai.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMoKl);
            this.groupBox4.Location = new System.Drawing.Point(433, 457);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 275);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mô tả luật";
            // 
            // dgvMoKl
            // 
            this.dgvMoKl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMoKl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoKl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKL,
            this.MoTa});
            this.dgvMoKl.Location = new System.Drawing.Point(6, 25);
            this.dgvMoKl.Name = "dgvMoKl";
            this.dgvMoKl.ReadOnly = true;
            this.dgvMoKl.RowHeadersWidth = 62;
            this.dgvMoKl.RowTemplate.Height = 28;
            this.dgvMoKl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoKl.Size = new System.Drawing.Size(392, 244);
            this.dgvMoKl.TabIndex = 1;
            this.dgvMoKl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoKl_CellClick);
            // 
            // MaKL
            // 
            this.MaKL.DataPropertyName = "MaKL";
            this.MaKL.HeaderText = "Mã KL";
            this.MaKL.MinimumWidth = 8;
            this.MaKL.Name = "MaKL";
            this.MaKL.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnThoat);
            this.groupBox5.Controls.Add(this.btnXoa);
            this.groupBox5.Controls.Add(this.btnSua);
            this.groupBox5.Controls.Add(this.btnThem);
            this.groupBox5.Location = new System.Drawing.Point(857, 457);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 192);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(223, 116);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(7);
            this.btnThoat.Size = new System.Drawing.Size(130, 55);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(51, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(7);
            this.btnXoa.Size = new System.Drawing.Size(130, 55);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(223, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(7);
            this.btnSua.Size = new System.Drawing.Size(130, 55);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(51, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(7);
            this.btnThem.Size = new System.Drawing.Size(130, 55);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnVT
            // 
            this.btnVT.Image = ((System.Drawing.Image)(resources.GetObject("btnVT.Image")));
            this.btnVT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVT.Location = new System.Drawing.Point(653, 64);
            this.btnVT.Name = "btnVT";
            this.btnVT.Padding = new System.Windows.Forms.Padding(10);
            this.btnVT.Size = new System.Drawing.Size(180, 65);
            this.btnVT.TabIndex = 5;
            this.btnVT.Text = "Chọn vế trái";
            this.btnVT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVT.UseVisualStyleBackColor = true;
            this.btnVT.Click += new System.EventHandler(this.btnVT_Click);
            // 
            // btnVP
            // 
            this.btnVP.Image = ((System.Drawing.Image)(resources.GetObject("btnVP.Image")));
            this.btnVP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVP.Location = new System.Drawing.Point(653, 177);
            this.btnVP.Name = "btnVP";
            this.btnVP.Padding = new System.Windows.Forms.Padding(10);
            this.btnVP.Size = new System.Drawing.Size(180, 65);
            this.btnVP.TabIndex = 6;
            this.btnVP.Text = "Chọn vế phải";
            this.btnVP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVP.UseVisualStyleBackColor = true;
            this.btnVP.Click += new System.EventHandler(this.btnVP_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(653, 283);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnHuy.Size = new System.Drawing.Size(180, 65);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Luat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1292, 785);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnVP);
            this.Controls.Add(this.btnVT);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Luat";
            this.Text = "Luật";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Luat_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoKl)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVephai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVetrai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaluat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnVT;
        private System.Windows.Forms.Button btnVP;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvSK;
        private System.Windows.Forms.DataGridView dgvLuat;
        private System.Windows.Forms.DataGridView dgvMoKl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeTrai;
        private System.Windows.Forms.DataGridViewTextBoxColumn VePhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}