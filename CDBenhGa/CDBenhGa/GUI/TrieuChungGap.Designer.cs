
namespace CDBenhGa.GUI
{
    partial class TrieuChungGap
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
            this.cboTrieuChungThuongGapNhat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboTrieuChungThuongGapNhat
            // 
            this.cboTrieuChungThuongGapNhat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTrieuChungThuongGapNhat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTrieuChungThuongGapNhat.FormattingEnabled = true;
            this.cboTrieuChungThuongGapNhat.Location = new System.Drawing.Point(53, 71);
            this.cboTrieuChungThuongGapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTrieuChungThuongGapNhat.Name = "cboTrieuChungThuongGapNhat";
            this.cboTrieuChungThuongGapNhat.Size = new System.Drawing.Size(260, 28);
            this.cboTrieuChungThuongGapNhat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Triệu chứng bạn thường gặp nhất là:";
            // 
            // TrieuChungGap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboTrieuChungThuongGapNhat);
            this.Controls.Add(this.label1);
            this.Name = "TrieuChungGap";
            this.Size = new System.Drawing.Size(384, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTrieuChungThuongGapNhat;
        private System.Windows.Forms.Label label1;
    }
}
