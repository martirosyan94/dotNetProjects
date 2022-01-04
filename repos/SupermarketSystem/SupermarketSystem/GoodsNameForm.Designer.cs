
namespace SupermarketSystem
{
    partial class GoodsNameForm
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
            this.NameTbox = new System.Windows.Forms.TextBox();
            this.CodeTBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupCbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTbox
            // 
            this.NameTbox.Location = new System.Drawing.Point(130, 94);
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.Size = new System.Drawing.Size(100, 23);
            this.NameTbox.TabIndex = 17;
            // 
            // CodeTBox
            // 
            this.CodeTBox.Location = new System.Drawing.Point(130, 47);
            this.CodeTBox.Name = "CodeTBox";
            this.CodeTBox.Size = new System.Drawing.Size(100, 23);
            this.CodeTBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ընդհատել";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Գրանցել";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Անուն";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Կոդ";
            // 
            // groupCbox
            // 
            this.groupCbox.FormattingEnabled = true;
            this.groupCbox.Location = new System.Drawing.Point(129, 142);
            this.groupCbox.Name = "groupCbox";
            this.groupCbox.Size = new System.Drawing.Size(121, 23);
            this.groupCbox.TabIndex = 18;
            this.groupCbox.SelectedIndexChanged += new System.EventHandler(this.groupCbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Խումբ";
            // 
            // GoodsNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupCbox);
            this.Controls.Add(this.NameTbox);
            this.Controls.Add(this.CodeTBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GoodsNameForm";
            this.Text = "GoodsNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTbox;
        private System.Windows.Forms.TextBox CodeTBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupCbox;
        private System.Windows.Forms.Label label3;
    }
}