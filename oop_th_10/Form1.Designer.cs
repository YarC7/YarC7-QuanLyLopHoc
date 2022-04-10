namespace oop_th_10
{
    partial class FormQLLH
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.dgv_ketqua = new System.Windows.Forms.DataGridView();
            this.btn_tk = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ex_imp = new System.Windows.Forms.Button();
            this.ex_exp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ma SV";
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(143, 332);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(132, 22);
            this.txt_masv.TabIndex = 5;
            // 
            // dgv_ketqua
            // 
            this.dgv_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ketqua.Location = new System.Drawing.Point(13, 53);
            this.dgv_ketqua.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ketqua.Name = "dgv_ketqua";
            this.dgv_ketqua.RowHeadersWidth = 51;
            this.dgv_ketqua.Size = new System.Drawing.Size(724, 218);
            this.dgv_ketqua.TabIndex = 6;
            // 
            // btn_tk
            // 
            this.btn_tk.Location = new System.Drawing.Point(13, 296);
            this.btn_tk.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(100, 28);
            this.btn_tk.TabIndex = 7;
            this.btn_tk.Text = "Tim kiem";
            this.btn_tk.UseVisualStyleBackColor = true;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 393);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Them";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(162, 393);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 28);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Sua";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(315, 393);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 28);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Xoa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(499, 393);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 28);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Thoat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 

            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(888, 450);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(100, 28);
            this.btn_cancle.TabIndex = 13;
            this.btn_cancle.Text = "Huy";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ThongTinChiTiet";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // ex_imp
            // 
            this.ex_imp.Location = new System.Drawing.Point(751, 332);
            this.ex_imp.Margin = new System.Windows.Forms.Padding(4);
            this.ex_imp.Name = "ex_imp";
            this.ex_imp.Size = new System.Drawing.Size(100, 28);
            this.ex_imp.TabIndex = 15;
            this.ex_imp.Text = "Import";
            this.ex_imp.UseVisualStyleBackColor = true;
            this.ex_imp.Click += new System.EventHandler(this.ex_imp_Click);
            // 
            // ex_exp
            // 
            this.ex_exp.Location = new System.Drawing.Point(888, 332);
            this.ex_exp.Margin = new System.Windows.Forms.Padding(4);
            this.ex_exp.Name = "ex_exp";
            this.ex_exp.Size = new System.Drawing.Size(100, 28);
            this.ex_exp.TabIndex = 16;
            this.ex_exp.Text = "Export";
            this.ex_exp.UseVisualStyleBackColor = true;
            this.ex_exp.Click += new System.EventHandler(this.ex_exp_Click);
            // 
            // FormQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 572);
            this.Controls.Add(this.ex_exp);
            this.Controls.Add(this.ex_imp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.dgv_ketqua);
            this.Controls.Add(this.txt_masv);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQLLH";
            this.Text = "Quan Ly Lop Hoc";
            this.Load += new System.EventHandler(this.FormQLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.DataGridView dgv_ketqua;
        private System.Windows.Forms.Button btn_tk;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button ex_exp;
        private System.Windows.Forms.Button ex_imp;
    }
}

