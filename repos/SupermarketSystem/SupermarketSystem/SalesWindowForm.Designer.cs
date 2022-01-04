
namespace SupermarketSystem
{
    partial class SalesWindowForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsAmmountTbox = new System.Windows.Forms.TextBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.goodsGroupCbox = new System.Windows.Forms.ComboBox();
            this.goodsNameCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ապրանքի Խումբը";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ապրանքի Անվանումը";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Քանակ";
            // 
            // goodsAmmountTbox
            // 
            this.goodsAmmountTbox.Location = new System.Drawing.Point(164, 154);
            this.goodsAmmountTbox.Name = "goodsAmmountTbox";
            this.goodsAmmountTbox.Size = new System.Drawing.Size(58, 23);
            this.goodsAmmountTbox.TabIndex = 3;
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(253, 157);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(46, 23);
            this.plusBtn.TabIndex = 4;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(209, 258);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 6;
            this.buyBtn.Text = "Գնել";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // goodsGroupCbox
            // 
            this.goodsGroupCbox.FormattingEnabled = true;
            this.goodsGroupCbox.Location = new System.Drawing.Point(196, 47);
            this.goodsGroupCbox.Name = "goodsGroupCbox";
            this.goodsGroupCbox.Size = new System.Drawing.Size(121, 23);
            this.goodsGroupCbox.TabIndex = 7;
            this.goodsGroupCbox.SelectedIndexChanged += new System.EventHandler(this.goodsGroupCbox_SelectedIndexChanged);
            // 
            // goodsNameCbox
            // 
            this.goodsNameCbox.FormattingEnabled = true;
            this.goodsNameCbox.Location = new System.Drawing.Point(196, 95);
            this.goodsNameCbox.Name = "goodsNameCbox";
            this.goodsNameCbox.Size = new System.Drawing.Size(121, 23);
            this.goodsNameCbox.TabIndex = 8;
            // 
            // SalesWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 396);
            this.Controls.Add(this.goodsNameCbox);
            this.Controls.Add(this.goodsGroupCbox);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.goodsAmmountTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesWindowForm";
            this.Text = "SalesWindowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goodsAmmountTbox;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.ComboBox goodsGroupCbox;
        private System.Windows.Forms.ComboBox goodsNameCbox;
    }
}