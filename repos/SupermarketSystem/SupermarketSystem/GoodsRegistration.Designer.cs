
namespace SupermarketSystem
{
    partial class GoodsRegistration
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
            this.documentNumberTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expirationDateTbox = new System.Windows.Forms.TextBox();
            this.AmmountTbox = new System.Windows.Forms.TextBox();
            this.purchcasePriseTbox = new System.Windows.Forms.TextBox();
            this.salePriceTbox = new System.Windows.Forms.TextBox();
            this.registerGoodsBtn = new System.Windows.Forms.Button();
            this.suplierCbox = new System.Windows.Forms.ComboBox();
            this.goodsCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // documentNumberTbox
            // 
            this.documentNumberTbox.AccessibleName = "";
            this.documentNumberTbox.Location = new System.Drawing.Point(183, 53);
            this.documentNumberTbox.Name = "documentNumberTbox";
            this.documentNumberTbox.Size = new System.Drawing.Size(100, 23);
            this.documentNumberTbox.TabIndex = 0;
            this.documentNumberTbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Փաստաթղթի համար";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTbox
            // 
            this.dateTbox.Location = new System.Drawing.Point(183, 108);
            this.dateTbox.Name = "dateTbox";
            this.dateTbox.Size = new System.Drawing.Size(100, 23);
            this.dateTbox.TabIndex = 2;
            this.dateTbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ամսաթիվ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Մատակարար";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(297, 400);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(162, 23);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Գրանցել";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.Final_Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Պիտանելիության Ժամկետ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ապրանքի անվանումը";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Քանակ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ձեռքբերման Գին";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Վաճառքի Գին";
            // 
            // expirationDateTbox
            // 
            this.expirationDateTbox.AccessibleName = "";
            this.expirationDateTbox.Location = new System.Drawing.Point(597, 53);
            this.expirationDateTbox.Name = "expirationDateTbox";
            this.expirationDateTbox.Size = new System.Drawing.Size(100, 23);
            this.expirationDateTbox.TabIndex = 12;
            // 
            // AmmountTbox
            // 
            this.AmmountTbox.AccessibleName = "";
            this.AmmountTbox.Location = new System.Drawing.Point(597, 154);
            this.AmmountTbox.Name = "AmmountTbox";
            this.AmmountTbox.Size = new System.Drawing.Size(100, 23);
            this.AmmountTbox.TabIndex = 14;
            // 
            // purchcasePriseTbox
            // 
            this.purchcasePriseTbox.AccessibleName = "";
            this.purchcasePriseTbox.Location = new System.Drawing.Point(597, 201);
            this.purchcasePriseTbox.Name = "purchcasePriseTbox";
            this.purchcasePriseTbox.Size = new System.Drawing.Size(100, 23);
            this.purchcasePriseTbox.TabIndex = 15;
            // 
            // salePriceTbox
            // 
            this.salePriceTbox.AccessibleName = "";
            this.salePriceTbox.Location = new System.Drawing.Point(597, 244);
            this.salePriceTbox.Name = "salePriceTbox";
            this.salePriceTbox.Size = new System.Drawing.Size(100, 23);
            this.salePriceTbox.TabIndex = 16;
            // 
            // registerGoodsBtn
            // 
            this.registerGoodsBtn.Location = new System.Drawing.Point(479, 301);
            this.registerGoodsBtn.Name = "registerGoodsBtn";
            this.registerGoodsBtn.Size = new System.Drawing.Size(162, 23);
            this.registerGoodsBtn.TabIndex = 17;
            this.registerGoodsBtn.Text = "Գրանցել";
            this.registerGoodsBtn.UseVisualStyleBackColor = true;
            this.registerGoodsBtn.Click += new System.EventHandler(this.registerGoodsBtn_Click);
            // 
            // suplierCbox
            // 
            this.suplierCbox.FormattingEnabled = true;
            this.suplierCbox.Location = new System.Drawing.Point(173, 163);
            this.suplierCbox.Name = "suplierCbox";
            this.suplierCbox.Size = new System.Drawing.Size(121, 23);
            this.suplierCbox.TabIndex = 18;
            this.suplierCbox.SelectedIndexChanged += new System.EventHandler(this.suplierCbox_SelectedIndexChanged);
            // 
            // goodsCbox
            // 
            this.goodsCbox.FormattingEnabled = true;
            this.goodsCbox.Location = new System.Drawing.Point(597, 105);
            this.goodsCbox.Name = "goodsCbox";
            this.goodsCbox.Size = new System.Drawing.Size(121, 23);
            this.goodsCbox.TabIndex = 19;
            // 
            // GoodsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 561);
            this.Controls.Add(this.goodsCbox);
            this.Controls.Add(this.suplierCbox);
            this.Controls.Add(this.registerGoodsBtn);
            this.Controls.Add(this.salePriceTbox);
            this.Controls.Add(this.purchcasePriseTbox);
            this.Controls.Add(this.AmmountTbox);
            this.Controls.Add(this.expirationDateTbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documentNumberTbox);
            this.Name = "GoodsRegistration";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GoodsRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox documentNumberTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox expirationDateTbox;
        private System.Windows.Forms.TextBox AmmountTbox;
        private System.Windows.Forms.TextBox purchcasePriseTbox;
        private System.Windows.Forms.TextBox salePriceTbox;
        private System.Windows.Forms.Button registerGoodsBtn;
        private System.Windows.Forms.ComboBox suplierCbox;
        private System.Windows.Forms.ComboBox goodsCbox;
    }
}