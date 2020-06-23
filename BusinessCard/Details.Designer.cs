namespace BusinessCard
{
    partial class Details
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.Label();
            this._sex = new System.Windows.Forms.Label();
            this.btn_updata = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "姓名";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(51, 201);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(234, 52);
            this.tb_address.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "地址";
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(51, 160);
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(234, 21);
            this.tb_position.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "职务";
            // 
            // tb_company
            // 
            this.tb_company.Location = new System.Drawing.Point(51, 122);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(234, 21);
            this.tb_company.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "公司";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(51, 84);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(234, 21);
            this.tb_phone.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "手机";
            // 
            // _name
            // 
            this._name.AutoSize = true;
            this._name.Location = new System.Drawing.Point(65, 15);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(29, 12);
            this._name.TabIndex = 21;
            this._name.Text = "张三";
            // 
            // _sex
            // 
            this._sex.AutoSize = true;
            this._sex.Location = new System.Drawing.Point(65, 49);
            this._sex.Name = "_sex";
            this._sex.Size = new System.Drawing.Size(17, 12);
            this._sex.TabIndex = 22;
            this._sex.Text = "男";
            // 
            // btn_updata
            // 
            this.btn_updata.Location = new System.Drawing.Point(51, 273);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.Size = new System.Drawing.Size(75, 23);
            this.btn_updata.TabIndex = 23;
            this.btn_updata.Text = "修改";
            this.btn_updata.UseVisualStyleBackColor = true;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(210, 273);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 24;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 318);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_updata);
            this.Controls.Add(this._sex);
            this.Controls.Add(this._name);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_company);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "详情";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _name;
        private System.Windows.Forms.Label _sex;
        private System.Windows.Forms.Button btn_updata;
        private System.Windows.Forms.Button btn_del;
    }
}