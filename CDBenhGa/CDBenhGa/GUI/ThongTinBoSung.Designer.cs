
namespace CDBenhGa.GUI
{
    partial class ThongTinBoSung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radKhong = new System.Windows.Forms.RadioButton();
            this.radCo = new System.Windows.Forms.RadioButton();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Các triệu chứng khác:";
            // 
            // radKhong
            // 
            this.radKhong.AutoSize = true;
            this.radKhong.Location = new System.Drawing.Point(130, 103);
            this.radKhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radKhong.Name = "radKhong";
            this.radKhong.Size = new System.Drawing.Size(80, 24);
            this.radKhong.TabIndex = 8;
            this.radKhong.Text = "Không";
            this.radKhong.UseVisualStyleBackColor = true;
            // 
            // radCo
            // 
            this.radCo.AutoSize = true;
            this.radCo.Checked = true;
            this.radCo.Location = new System.Drawing.Point(45, 103);
            this.radCo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radCo.Name = "radCo";
            this.radCo.Size = new System.Drawing.Size(54, 24);
            this.radCo.TabIndex = 7;
            this.radCo.TabStop = true;
            this.radCo.Text = "Có";
            this.radCo.UseVisualStyleBackColor = true;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Location = new System.Drawing.Point(33, 61);
            this.lblCauHoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(67, 20);
            this.lblCauHoi.TabIndex = 6;
            this.lblCauHoi.Text = "Câu hỏi:";
            // 
            // ThongTinBoSung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radKhong);
            this.Controls.Add(this.radCo);
            this.Controls.Add(this.lblCauHoi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongTinBoSung";
            this.Size = new System.Drawing.Size(981, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radKhong;
        private System.Windows.Forms.RadioButton radCo;
        private System.Windows.Forms.Label lblCauHoi;
    }
}
