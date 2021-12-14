
namespace CDBenhGa.GUI
{
    partial class SuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuKien));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSK = new System.Windows.Forms.TextBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCauhoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSK = new System.Windows.Forms.DataGridView();
            this.MaSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXOa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sự kiện";
            // 
            // txtMaSK
            // 
            this.txtMaSK.Location = new System.Drawing.Point(133, 67);
            this.txtMaSK.Name = "txtMaSK";
            this.txtMaSK.Size = new System.Drawing.Size(260, 26);
            this.txtMaSK.TabIndex = 1;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(133, 128);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(260, 26);
            this.txtMota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // txtCauhoi
            // 
            this.txtCauhoi.Location = new System.Drawing.Point(133, 196);
            this.txtCauhoi.Name = "txtCauhoi";
            this.txtCauhoi.Size = new System.Drawing.Size(260, 26);
            this.txtCauhoi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Câu hỏi";
            // 
            // dgvSK
            // 
            this.dgvSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSK.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSK,
            this.TenSK,
            this.CauHoi});
            this.dgvSK.Location = new System.Drawing.Point(480, 36);
            this.dgvSK.Name = "dgvSK";
            this.dgvSK.ReadOnly = true;
            this.dgvSK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSK.RowHeadersWidth = 62;
            this.dgvSK.RowTemplate.Height = 28;
            this.dgvSK.Size = new System.Drawing.Size(656, 495);
            this.dgvSK.TabIndex = 6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCauhoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMota);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 314);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXOa);
            this.groupBox2.Location = new System.Drawing.Point(12, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(24, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5);
            this.btnThem.Size = new System.Drawing.Size(110, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(157, 39);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5);
            this.btnSua.Size = new System.Drawing.Size(110, 51);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXOa
            // 
            this.btnXOa.Image = ((System.Drawing.Image)(resources.GetObject("btnXOa.Image")));
            this.btnXOa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXOa.Location = new System.Drawing.Point(296, 39);
            this.btnXOa.Name = "btnXOa";
            this.btnXOa.Padding = new System.Windows.Forms.Padding(5);
            this.btnXOa.Size = new System.Drawing.Size(110, 51);
            this.btnXOa.TabIndex = 2;
            this.btnXOa.Text = "Xóa";
            this.btnXOa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXOa.UseVisualStyleBackColor = true;
            this.btnXOa.Click += new System.EventHandler(this.btnXOa_Click);
            // 
            // SuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1148, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSK);
            this.Name = "SuKien";
            this.Text = "Sự kiện";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SuKien_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSK;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCauhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXOa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
    }
}