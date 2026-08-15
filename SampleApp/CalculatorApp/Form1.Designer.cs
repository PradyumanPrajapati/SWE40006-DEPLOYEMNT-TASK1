namespace CalculatorApp
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
            txtDisplay = new TextBox();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonClear = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonEquals = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(21, 75);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(388, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(21, 124);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(127, 124);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(75, 23);
            buttonSub.TabIndex = 2;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(235, 124);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 23);
            buttonMultiply.TabIndex = 3;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(334, 124);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 23);
            buttonDivide.TabIndex = 4;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(127, 168);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(235, 168);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(334, 168);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button4
            // 
            button4.Location = new Point(21, 216);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(127, 216);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(235, 216);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(334, 216);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(75, 23);
            buttonEquals.TabIndex = 12;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // button7
            // 
            button7.Location = new Point(21, 261);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 13;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(127, 261);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 14;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(235, 261);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 15;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(334, 261);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 16;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 450);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonEquals);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonClear);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonClear;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonEquals;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
    }
}
