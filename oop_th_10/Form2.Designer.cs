namespace oop_th_10
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_msv = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.rbt_nam = new System.Windows.Forms.RadioButton();
            this.rbt_nu = new System.Windows.Forms.RadioButton();
            this.gp_gt = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gp_gt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txt_msv
            // 
            this.txt_msv.Location = new System.Drawing.Point(226, 38);
            this.txt_msv.Name = "txt_msv";
            this.txt_msv.Size = new System.Drawing.Size(143, 22);
            this.txt_msv.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(226, 96);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(239, 22);
            this.txt_name.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(226, 213);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(239, 22);
            this.txt_email.TabIndex = 7;
            // 
            // rbt_nam
            // 
            this.rbt_nam.AutoSize = true;
            this.rbt_nam.Location = new System.Drawing.Point(15, 11);
            this.rbt_nam.Name = "rbt_nam";
            this.rbt_nam.Size = new System.Drawing.Size(57, 20);
            this.rbt_nam.TabIndex = 8;
            this.rbt_nam.TabStop = true;
            this.rbt_nam.Text = "Nam";
            this.rbt_nam.UseVisualStyleBackColor = true;
            // 
            // rbt_nu
            // 
            this.rbt_nu.AutoSize = true;
            this.rbt_nu.Location = new System.Drawing.Point(110, 11);
            this.rbt_nu.Name = "rbt_nu";
            this.rbt_nu.Size = new System.Drawing.Size(45, 20);
            this.rbt_nu.TabIndex = 9;
            this.rbt_nu.TabStop = true;
            this.rbt_nu.Text = "Nữ";
            this.rbt_nu.UseVisualStyleBackColor = true;
            // 
            // gp_gt
            // 
            this.gp_gt.Controls.Add(this.rbt_nam);
            this.gp_gt.Controls.Add(this.rbt_nu);
            this.gp_gt.Location = new System.Drawing.Point(226, 156);
            this.gp_gt.Name = "gp_gt";
            this.gp_gt.Size = new System.Drawing.Size(200, 37);
            this.gp_gt.TabIndex = 10;
            this.gp_gt.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(324, 324);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 44);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Lưu dữ liệu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gp_gt);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_msv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gp_gt.ResumeLayout(false);
            this.gp_gt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_msv;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.RadioButton rbt_nam;
        public System.Windows.Forms.RadioButton rbt_nu;
        public System.Windows.Forms.GroupBox gp_gt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ErrorProvider error;
    }
}