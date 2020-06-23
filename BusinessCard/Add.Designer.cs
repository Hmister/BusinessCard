namespace BusinessCard
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.rb_woman = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(47, 20);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(234, 21);
            this.tb_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别";
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.Location = new System.Drawing.Point(56, 64);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(35, 16);
            this.rb_man.TabIndex = 3;
            this.rb_man.TabStop = true;
            this.rb_man.Text = "男";
            this.rb_man.UseVisualStyleBackColor = true;
            // 
            // rb_woman
            // 
            this.rb_woman.AutoSize = true;
            this.rb_woman.Location = new System.Drawing.Point(108, 64);
            this.rb_woman.Name = "rb_woman";
            this.rb_woman.Size = new System.Drawing.Size(35, 16);
            this.rb_woman.TabIndex = 4;
            this.rb_woman.TabStop = true;
            this.rb_woman.Text = "女";
            this.rb_woman.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "手机";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(47, 101);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(234, 21);
            this.tb_phone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "公司";
            // 
            // tb_company
            // 
            this.tb_company.Location = new System.Drawing.Point(47, 139);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(234, 21);
            this.tb_company.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "职务";
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(47, 177);
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(234, 21);
            this.tb_position.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "地址";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(47, 218);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(234, 52);
            this.tb_address.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 286);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(269, 32);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "保存";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 330);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_company);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_woman);
            this.Controls.Add(this.rb_man);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增名片";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_man;
        private System.Windows.Forms.RadioButton rb_woman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Button btn_add;
    }
}