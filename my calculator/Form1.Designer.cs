namespace my_calculator
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
            txt1 = new NumericUpDown();
            txt2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)txt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 41);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 0;
            label1.Text = "عدد اول:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 88);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "عدد دوم:";
            // 
            // txt1
            // 
            txt1.Location = new Point(12, 33);
            txt1.Name = "txt1";
            txt1.Size = new Size(304, 26);
            txt1.TabIndex = 2;
            txt1.ValueChanged += txt1_ValueChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(12, 86);
            txt2.Name = "txt2";
            txt2.Size = new Size(304, 26);
            txt2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 140);
            button1.Name = "button1";
            button1.Size = new Size(60, 29);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(78, 140);
            button2.Name = "button2";
            button2.Size = new Size(59, 29);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(143, 140);
            button3.Name = "button3";
            button3.Size = new Size(60, 29);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(209, 140);
            button4.Name = "button4";
            button4.Size = new Size(60, 29);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 197);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ماشین حساب من";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown txt1;
        private NumericUpDown txt2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
