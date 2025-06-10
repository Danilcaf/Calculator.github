namespace Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Button_Sin = new Button();
            Button_Cos = new Button();
            Button_Power = new Button();
            Button_Multiply = new Button();
            Button_Minus = new Button();
            Button_Number6 = new Button();
            Button_Number5 = new Button();
            Button_Number4 = new Button();
            Button_Divide = new Button();
            Button_Number3 = new Button();
            Button_Number2 = new Button();
            Button_Number1 = new Button();
            Button_Plus = new Button();
            Button_Number9 = new Button();
            Button_Number8 = new Button();
            Button_Number7 = new Button();
            Button_Dot = new Button();
            Button_Number0 = new Button();
            Button_Number00 = new Button();
            Label_Formula = new Label();
            Button_Remove = new Button();
            Button_Percent = new Button();
            Button_SquareRoot = new Button();
            Button_Equals = new Button();
            TextBox_Output_String = new TextBox();
            Panel_Mover = new Panel();
            Button_Minimum = new Button();
            Button_Close = new Button();
            Panel_Mover.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 19F);
            button1.Location = new Point(12, 117);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = "CE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 19F);
            button2.Location = new Point(118, 117);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = "%";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 19F);
            button3.Location = new Point(224, 117);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.Text = "√ ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 19F);
            button4.Location = new Point(330, 117);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.Text = "=";
            button4.UseVisualStyleBackColor = true;
            // 
            // Button_Sin
            // 
            Button_Sin.BackColor = Color.FromArgb(192, 192, 0);
            Button_Sin.FlatStyle = FlatStyle.Flat;
            Button_Sin.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Sin.ForeColor = Color.Sienna;
            Button_Sin.Location = new Point(12, 223);
            Button_Sin.Name = "Button_Sin";
            Button_Sin.Size = new Size(100, 100);
            Button_Sin.TabIndex = 4;
            Button_Sin.Text = "sin";
            Button_Sin.UseVisualStyleBackColor = false;
            Button_Sin.Click += Button_Operation_Click;
            // 
            // Button_Cos
            // 
            Button_Cos.BackColor = Color.FromArgb(192, 192, 0);
            Button_Cos.FlatStyle = FlatStyle.Flat;
            Button_Cos.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Cos.ForeColor = Color.Sienna;
            Button_Cos.Location = new Point(118, 223);
            Button_Cos.Name = "Button_Cos";
            Button_Cos.Size = new Size(100, 100);
            Button_Cos.TabIndex = 5;
            Button_Cos.Text = "cos";
            Button_Cos.UseVisualStyleBackColor = false;
            Button_Cos.Click += Button_Operation_Click;
            // 
            // Button_Power
            // 
            Button_Power.BackColor = Color.FromArgb(192, 192, 0);
            Button_Power.FlatStyle = FlatStyle.Flat;
            Button_Power.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Power.ForeColor = Color.Sienna;
            Button_Power.Location = new Point(224, 223);
            Button_Power.Name = "Button_Power";
            Button_Power.Size = new Size(100, 100);
            Button_Power.TabIndex = 6;
            Button_Power.Text = "^";
            Button_Power.UseVisualStyleBackColor = false;
            Button_Power.Click += Button_Operation_Click;
            // 
            // Button_Multiply
            // 
            Button_Multiply.BackColor = Color.FromArgb(192, 192, 0);
            Button_Multiply.FlatStyle = FlatStyle.Flat;
            Button_Multiply.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Multiply.ForeColor = Color.Sienna;
            Button_Multiply.Location = new Point(330, 223);
            Button_Multiply.Name = "Button_Multiply";
            Button_Multiply.Size = new Size(100, 100);
            Button_Multiply.TabIndex = 7;
            Button_Multiply.Text = "×";
            Button_Multiply.UseVisualStyleBackColor = false;
            Button_Multiply.Click += Button_Operation_Click;
            // 
            // Button_Minus
            // 
            Button_Minus.BackColor = Color.FromArgb(192, 192, 0);
            Button_Minus.FlatStyle = FlatStyle.Flat;
            Button_Minus.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Minus.ForeColor = Color.Sienna;
            Button_Minus.Location = new Point(330, 435);
            Button_Minus.Name = "Button_Minus";
            Button_Minus.Size = new Size(100, 100);
            Button_Minus.TabIndex = 15;
            Button_Minus.Text = "-";
            Button_Minus.UseVisualStyleBackColor = false;
            Button_Minus.Click += Button_Operation_Click;
            // 
            // Button_Number6
            // 
            Button_Number6.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number6.FlatStyle = FlatStyle.Flat;
            Button_Number6.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number6.ForeColor = Color.Maroon;
            Button_Number6.Location = new Point(224, 435);
            Button_Number6.Name = "Button_Number6";
            Button_Number6.Size = new Size(100, 100);
            Button_Number6.TabIndex = 14;
            Button_Number6.Text = "6";
            Button_Number6.UseVisualStyleBackColor = false;
            Button_Number6.Click += Button_Number_Click;
            // 
            // Button_Number5
            // 
            Button_Number5.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number5.FlatStyle = FlatStyle.Flat;
            Button_Number5.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number5.ForeColor = Color.Maroon;
            Button_Number5.Location = new Point(118, 435);
            Button_Number5.Name = "Button_Number5";
            Button_Number5.Size = new Size(100, 100);
            Button_Number5.TabIndex = 13;
            Button_Number5.Text = "5";
            Button_Number5.UseVisualStyleBackColor = false;
            Button_Number5.Click += Button_Number_Click;
            // 
            // Button_Number4
            // 
            Button_Number4.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number4.FlatStyle = FlatStyle.Flat;
            Button_Number4.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number4.ForeColor = Color.Maroon;
            Button_Number4.Location = new Point(12, 435);
            Button_Number4.Name = "Button_Number4";
            Button_Number4.Size = new Size(100, 100);
            Button_Number4.TabIndex = 12;
            Button_Number4.Text = "4";
            Button_Number4.UseVisualStyleBackColor = false;
            Button_Number4.Click += Button_Number_Click;
            // 
            // Button_Divide
            // 
            Button_Divide.BackColor = Color.FromArgb(192, 192, 0);
            Button_Divide.FlatStyle = FlatStyle.Flat;
            Button_Divide.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Divide.ForeColor = Color.Sienna;
            Button_Divide.Location = new Point(330, 329);
            Button_Divide.Name = "Button_Divide";
            Button_Divide.Size = new Size(100, 100);
            Button_Divide.TabIndex = 11;
            Button_Divide.Text = "÷";
            Button_Divide.UseVisualStyleBackColor = false;
            Button_Divide.Click += Button_Operation_Click;
            // 
            // Button_Number3
            // 
            Button_Number3.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number3.FlatStyle = FlatStyle.Flat;
            Button_Number3.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number3.ForeColor = Color.Maroon;
            Button_Number3.Location = new Point(224, 329);
            Button_Number3.Name = "Button_Number3";
            Button_Number3.Size = new Size(100, 100);
            Button_Number3.TabIndex = 10;
            Button_Number3.Text = "3";
            Button_Number3.UseVisualStyleBackColor = false;
            Button_Number3.Click += Button_Number_Click;
            // 
            // Button_Number2
            // 
            Button_Number2.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number2.FlatStyle = FlatStyle.Flat;
            Button_Number2.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number2.ForeColor = Color.Maroon;
            Button_Number2.Location = new Point(118, 329);
            Button_Number2.Name = "Button_Number2";
            Button_Number2.Size = new Size(100, 100);
            Button_Number2.TabIndex = 9;
            Button_Number2.Text = "2";
            Button_Number2.UseVisualStyleBackColor = false;
            Button_Number2.Click += Button_Number_Click;
            // 
            // Button_Number1
            // 
            Button_Number1.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number1.FlatStyle = FlatStyle.Flat;
            Button_Number1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number1.ForeColor = Color.Maroon;
            Button_Number1.Location = new Point(12, 329);
            Button_Number1.Name = "Button_Number1";
            Button_Number1.Size = new Size(100, 100);
            Button_Number1.TabIndex = 8;
            Button_Number1.Text = "1";
            Button_Number1.UseVisualStyleBackColor = false;
            Button_Number1.Click += Button_Number_Click;
            // 
            // Button_Plus
            // 
            Button_Plus.BackColor = Color.FromArgb(192, 192, 0);
            Button_Plus.FlatStyle = FlatStyle.Flat;
            Button_Plus.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Plus.ForeColor = Color.Sienna;
            Button_Plus.Location = new Point(330, 541);
            Button_Plus.Name = "Button_Plus";
            Button_Plus.Size = new Size(100, 206);
            Button_Plus.TabIndex = 19;
            Button_Plus.Text = "+";
            Button_Plus.UseVisualStyleBackColor = false;
            Button_Plus.Click += Button_Operation_Click;
            // 
            // Button_Number9
            // 
            Button_Number9.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number9.FlatStyle = FlatStyle.Flat;
            Button_Number9.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number9.ForeColor = Color.Maroon;
            Button_Number9.Location = new Point(224, 541);
            Button_Number9.Name = "Button_Number9";
            Button_Number9.Size = new Size(100, 100);
            Button_Number9.TabIndex = 18;
            Button_Number9.Text = "9";
            Button_Number9.UseVisualStyleBackColor = false;
            Button_Number9.Click += Button_Number_Click;
            // 
            // Button_Number8
            // 
            Button_Number8.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number8.FlatStyle = FlatStyle.Flat;
            Button_Number8.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number8.ForeColor = Color.Maroon;
            Button_Number8.Location = new Point(118, 541);
            Button_Number8.Name = "Button_Number8";
            Button_Number8.Size = new Size(100, 100);
            Button_Number8.TabIndex = 17;
            Button_Number8.Text = "8";
            Button_Number8.UseVisualStyleBackColor = false;
            Button_Number8.Click += Button_Number_Click;
            // 
            // Button_Number7
            // 
            Button_Number7.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number7.FlatStyle = FlatStyle.Flat;
            Button_Number7.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number7.ForeColor = Color.Maroon;
            Button_Number7.Location = new Point(12, 541);
            Button_Number7.Name = "Button_Number7";
            Button_Number7.Size = new Size(100, 100);
            Button_Number7.TabIndex = 16;
            Button_Number7.Text = "7";
            Button_Number7.UseVisualStyleBackColor = false;
            Button_Number7.Click += Button_Number_Click;
            // 
            // Button_Dot
            // 
            Button_Dot.BackColor = Color.FromArgb(255, 192, 192);
            Button_Dot.FlatStyle = FlatStyle.Flat;
            Button_Dot.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Dot.ForeColor = Color.Maroon;
            Button_Dot.Location = new Point(224, 647);
            Button_Dot.Name = "Button_Dot";
            Button_Dot.Size = new Size(100, 100);
            Button_Dot.TabIndex = 22;
            Button_Dot.Text = ".";
            Button_Dot.UseVisualStyleBackColor = false;
            Button_Dot.Click += Button_Number_Click;
            // 
            // Button_Number0
            // 
            Button_Number0.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number0.FlatStyle = FlatStyle.Flat;
            Button_Number0.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number0.ForeColor = Color.Maroon;
            Button_Number0.Location = new Point(118, 647);
            Button_Number0.Name = "Button_Number0";
            Button_Number0.Size = new Size(100, 100);
            Button_Number0.TabIndex = 21;
            Button_Number0.Text = "0";
            Button_Number0.UseVisualStyleBackColor = false;
            Button_Number0.Click += Button_Number_Click;
            // 
            // Button_Number00
            // 
            Button_Number00.BackColor = Color.FromArgb(255, 192, 192);
            Button_Number00.FlatStyle = FlatStyle.Flat;
            Button_Number00.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            Button_Number00.ForeColor = Color.Maroon;
            Button_Number00.Location = new Point(12, 647);
            Button_Number00.Name = "Button_Number00";
            Button_Number00.Size = new Size(100, 100);
            Button_Number00.TabIndex = 20;
            Button_Number00.Text = "00";
            Button_Number00.UseVisualStyleBackColor = false;
            Button_Number00.Click += Button_Number_Click;
            // 
            // Label_Formula
            // 
            Label_Formula.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            Label_Formula.ForeColor = SystemColors.AppWorkspace;
            Label_Formula.Location = new Point(12, 26);
            Label_Formula.Name = "Label_Formula";
            Label_Formula.Size = new Size(418, 25);
            Label_Formula.TabIndex = 25;
            Label_Formula.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Button_Remove
            // 
            Button_Remove.BackColor = Color.FromArgb(192, 192, 0);
            Button_Remove.BackgroundImageLayout = ImageLayout.None;
            Button_Remove.FlatStyle = FlatStyle.Flat;
            Button_Remove.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Remove.ForeColor = Color.Sienna;
            Button_Remove.Location = new Point(12, 117);
            Button_Remove.Name = "Button_Remove";
            Button_Remove.Size = new Size(100, 100);
            Button_Remove.TabIndex = 0;
            Button_Remove.Text = "CE";
            Button_Remove.UseVisualStyleBackColor = false;
            Button_Remove.Click += Button_Remove_Click;
            // 
            // Button_Percent
            // 
            Button_Percent.BackColor = Color.FromArgb(192, 192, 0);
            Button_Percent.FlatStyle = FlatStyle.Flat;
            Button_Percent.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Percent.ForeColor = Color.Sienna;
            Button_Percent.Location = new Point(118, 117);
            Button_Percent.Name = "Button_Percent";
            Button_Percent.Size = new Size(100, 100);
            Button_Percent.TabIndex = 1;
            Button_Percent.Text = "%";
            Button_Percent.UseVisualStyleBackColor = false;
            Button_Percent.Click += Button_Operation_Click;
            // 
            // Button_SquareRoot
            // 
            Button_SquareRoot.BackColor = Color.FromArgb(192, 192, 0);
            Button_SquareRoot.FlatStyle = FlatStyle.Flat;
            Button_SquareRoot.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_SquareRoot.ForeColor = Color.Sienna;
            Button_SquareRoot.Location = new Point(224, 117);
            Button_SquareRoot.Name = "Button_SquareRoot";
            Button_SquareRoot.Size = new Size(100, 100);
            Button_SquareRoot.TabIndex = 2;
            Button_SquareRoot.Text = "√";
            Button_SquareRoot.UseVisualStyleBackColor = false;
            Button_SquareRoot.Click += Button_Operation_Click;
            // 
            // Button_Equals
            // 
            Button_Equals.BackColor = Color.FromArgb(192, 192, 0);
            Button_Equals.FlatStyle = FlatStyle.Flat;
            Button_Equals.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            Button_Equals.ForeColor = Color.Sienna;
            Button_Equals.Location = new Point(330, 117);
            Button_Equals.Name = "Button_Equals";
            Button_Equals.Size = new Size(100, 100);
            Button_Equals.TabIndex = 3;
            Button_Equals.Text = "=";
            Button_Equals.UseVisualStyleBackColor = false;
            Button_Equals.Click += Button_Equals_Click;
            // 
            // TextBox_Output_String
            // 
            TextBox_Output_String.BackColor = SystemColors.WindowText;
            TextBox_Output_String.BorderStyle = BorderStyle.None;
            TextBox_Output_String.Cursor = Cursors.IBeam;
            TextBox_Output_String.Font = new Font("Nirmala UI", 28F, FontStyle.Bold);
            TextBox_Output_String.ForeColor = SystemColors.Window;
            TextBox_Output_String.Location = new Point(12, 54);
            TextBox_Output_String.MaxLength = 1;
            TextBox_Output_String.Name = "TextBox_Output_String";
            TextBox_Output_String.ReadOnly = true;
            TextBox_Output_String.Size = new Size(418, 50);
            TextBox_Output_String.TabIndex = 26;
            TextBox_Output_String.Text = "0";
            TextBox_Output_String.TextAlign = HorizontalAlignment.Right;
            // 
            // Panel_Mover
            // 
            Panel_Mover.Controls.Add(Button_Minimum);
            Panel_Mover.Controls.Add(Button_Close);
            Panel_Mover.Dock = DockStyle.Top;
            Panel_Mover.Location = new Point(0, 0);
            Panel_Mover.Name = "Panel_Mover";
            Panel_Mover.Size = new Size(445, 23);
            Panel_Mover.TabIndex = 27;
            Panel_Mover.MouseDown += Panel_Mover_MouseDown;
            Panel_Mover.MouseMove += Panel_Mover_MouseMove;
            // 
            // Button_Minimum
            // 
            Button_Minimum.BackColor = SystemColors.ControlLight;
            Button_Minimum.BackgroundImageLayout = ImageLayout.None;
            Button_Minimum.FlatStyle = FlatStyle.Flat;
            Button_Minimum.Font = new Font("Segoe UI", 12F);
            Button_Minimum.Location = new Point(215, 0);
            Button_Minimum.Name = "Button_Minimum";
            Button_Minimum.Size = new Size(112, 23);
            Button_Minimum.TabIndex = 1;
            Button_Minimum.Text = "-";
            Button_Minimum.UseVisualStyleBackColor = false;
            Button_Minimum.Click += Button_Minimum_Click;
            // 
            // Button_Close
            // 
            Button_Close.BackColor = Color.Red;
            Button_Close.BackgroundImageLayout = ImageLayout.None;
            Button_Close.FlatStyle = FlatStyle.Flat;
            Button_Close.Font = new Font("Segoe UI", 8F);
            Button_Close.ForeColor = Color.Black;
            Button_Close.Location = new Point(333, 0);
            Button_Close.Name = "Button_Close";
            Button_Close.Size = new Size(112, 23);
            Button_Close.TabIndex = 0;
            Button_Close.Text = "X";
            Button_Close.UseVisualStyleBackColor = false;
            Button_Close.Click += Button_Close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(445, 764);
            Controls.Add(Panel_Mover);
            Controls.Add(TextBox_Output_String);
            Controls.Add(Label_Formula);
            Controls.Add(Button_Dot);
            Controls.Add(Button_Number0);
            Controls.Add(Button_Number00);
            Controls.Add(Button_Plus);
            Controls.Add(Button_Number9);
            Controls.Add(Button_Number8);
            Controls.Add(Button_Number7);
            Controls.Add(Button_Minus);
            Controls.Add(Button_Number6);
            Controls.Add(Button_Number5);
            Controls.Add(Button_Number4);
            Controls.Add(Button_Divide);
            Controls.Add(Button_Number3);
            Controls.Add(Button_Number2);
            Controls.Add(Button_Number1);
            Controls.Add(Button_Multiply);
            Controls.Add(Button_Power);
            Controls.Add(Button_Cos);
            Controls.Add(Button_Sin);
            Controls.Add(Button_Equals);
            Controls.Add(button4);
            Controls.Add(Button_SquareRoot);
            Controls.Add(button3);
            Controls.Add(Button_Percent);
            Controls.Add(button2);
            Controls.Add(Button_Remove);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Calculator";
            Panel_Mover.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Button_Sin;
        private Button Button_Cos;
        private Button Button_Power;
        private Button Button_Multiply;
        private Button Button_Minus;
        private Button Button_Number6;
        private Button Button_Number5;
        private Button Button_Number4;
        private Button Button_Divide;
        private Button Button_Number3;
        private Button Button_Number2;
        private Button Button_Number1;
        private Button Button_Plus;
        private Button Button_Number9;
        private Button Button_Number8;
        private Button Button_Number7;
        private Button Button_Dot;
        private Button Button_Number0;
        private Button Button_Number00;
        private Label Label_Formula;
        private Button Button_Remove;
        private Button Button_Percent;
        private Button Button_;
        private Button Button_Equals;
        private Button Button_SquareRoot;
        private TextBox TextBox_Output_String;
        private Panel Panel_Mover;
        private Button Button_Minimum;
        private Button Button_Close;
    }
}
