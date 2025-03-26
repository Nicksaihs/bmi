namespace bmi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 37);
            label1.Name = "label1";
            label1.Size = new Size(621, 47);
            label1.TabIndex = 0;
            label1.Text = "請輸入你(妳)的身高(cm)                 cm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 97);
            label2.Name = "label2";
            label2.Size = new Size(612, 47);
            label2.TabIndex = 1;
            label2.Text = "請輸入你(妳)的體重(kg)                  kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 157);
            label3.Name = "label3";
            label3.Size = new Size(799, 47);
            label3.TabIndex = 2;
            label3.Text = "你(妳)的BMI值為                  是屬於                 等級";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(344, 157);
            label4.Name = "label4";
            label4.Size = new Size(125, 47);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(621, 157);
            label5.Name = "label5";
            label5.Size = new Size(125, 47);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(489, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 54);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(475, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 54);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(690, 44);
            button1.Name = "button1";
            button1.Size = new Size(175, 102);
            button1.TabIndex = 7;
            button1.Text = "計算您的BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 215);
            label6.Name = "label6";
            label6.Size = new Size(125, 47);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 450);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label6;
    }
}