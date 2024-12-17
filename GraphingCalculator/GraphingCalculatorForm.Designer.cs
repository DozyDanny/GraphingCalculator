namespace GraphingCalculator
{
    partial class GrapingCalculatorForm
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
            calcBtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            xTextBox = new TextBox();
            constantTextBox = new TextBox();
            exponentTextBox = new TextBox();
            label3 = new Label();
            errorText = new Label();
            SuspendLayout();
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(411, 15);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(135, 66);
            calcBtn.TabIndex = 0;
            calcBtn.Text = "Calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 758);
            panel1.TabIndex = 1;
            panel1.Paint += panel1Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(50, 32);
            label1.TabIndex = 2;
            label1.Text = "Y =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 31);
            label2.Name = "label2";
            label2.Size = new Size(28, 32);
            label2.TabIndex = 3;
            label2.Text = "X";
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(86, 28);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(96, 39);
            xTextBox.TabIndex = 4;
            xTextBox.Text = "0.1";
            // 
            // constantTextBox
            // 
            constantTextBox.Location = new Point(297, 28);
            constantTextBox.Name = "constantTextBox";
            constantTextBox.Size = new Size(93, 39);
            constantTextBox.TabIndex = 5;
            constantTextBox.Text = "-100";
            // 
            // exponentTextBox
            // 
            exponentTextBox.Location = new Point(217, 15);
            exponentTextBox.Name = "exponentTextBox";
            exponentTextBox.Size = new Size(38, 39);
            exponentTextBox.TabIndex = 6;
            exponentTextBox.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 28);
            label3.Name = "label3";
            label3.Size = new Size(30, 32);
            label3.TabIndex = 7;
            label3.Text = "+";
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.Font = new Font("Segoe UI", 8F);
            errorText.Location = new Point(563, 18);
            errorText.Name = "errorText";
            errorText.Size = new Size(0, 30);
            errorText.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 866);
            Controls.Add(errorText);
            Controls.Add(label3);
            Controls.Add(exponentTextBox);
            Controls.Add(constantTextBox);
            Controls.Add(xTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(calcBtn);
            Name = "Form1";
            Text = "C# Graphing Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcBtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox xTextBox;
        private TextBox constantTextBox;
        private TextBox exponentTextBox;
        private Label label3;
        private Label errorText;
    }
}
