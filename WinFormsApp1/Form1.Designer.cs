namespace WinFormsApp1
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
            txtSideA = new TextBox();
            txtSideB = new TextBox();
            txtAngle = new TextBox();
            button1 = new Button();
            lblResult = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // txtSideA
            // 
            txtSideA.Location = new Point(63, 46);
            txtSideA.Name = "txtSideA";
            txtSideA.Size = new Size(102, 27);
            txtSideA.TabIndex = 0;
            txtSideA.TextChanged += textBox1_TextChanged;
            // 
            // txtSideB
            // 
            txtSideB.Location = new Point(432, 46);
            txtSideB.Name = "txtSideB";
            txtSideB.Size = new Size(163, 27);
            txtSideB.TabIndex = 1;
            // 
            // txtAngle
            // 
            txtAngle.Location = new Point(851, 46);
            txtAngle.Name = "txtAngle";
            txtAngle.Size = new Size(102, 27);
            txtAngle.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(421, 343);
            button1.Name = "button1";
            button1.Size = new Size(161, 29);
            button1.TabIndex = 3;
            button1.Text = "Узнать ответ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(432, 154);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(150, 162);
            lblResult.TabIndex = 4;
            lblResult.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(448, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "Сторона b";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(836, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "Угол между a и b";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 27);
            textBox3.TabIndex = 7;
            textBox3.Text = "Сторона a";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 533);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(txtAngle);
            Controls.Add(txtSideB);
            Controls.Add(txtSideA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSideA;
        private TextBox txtSideB;
        private TextBox txtAngle;
        private Button button1;
        private RichTextBox lblResult;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
