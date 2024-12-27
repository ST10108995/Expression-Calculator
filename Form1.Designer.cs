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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputbox = new TextBox();
            result = new TextBox();
            btnEqual = new Button();
            btn0 = new Button();
            btndecimal = new Button();
            btnlbrac = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnback = new Button();
            button14 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnclear = new Button();
            btnrbrac = new Button();
            SuspendLayout();
            // 
            // inputbox
            // 
            inputbox.BorderStyle = BorderStyle.None;
            inputbox.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputbox.ForeColor = Color.Black;
            inputbox.Location = new Point(49, 12);
            inputbox.Multiline = true;
            inputbox.Name = "inputbox";
            inputbox.Size = new Size(569, 65);
            inputbox.TabIndex = 0;
            inputbox.TextAlign = HorizontalAlignment.Right;
            // 
            // result
            // 
            result.BackColor = SystemColors.Window;
            result.BorderStyle = BorderStyle.None;
            result.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.Location = new Point(49, 74);
            result.Multiline = true;
            result.Name = "result";
            result.RightToLeft = RightToLeft.No;
            result.Size = new Size(569, 65);
            result.TabIndex = 0;
            result.TextAlign = HorizontalAlignment.Right;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("MS Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = Color.FromArgb(192, 0, 0);
            btnEqual.Location = new Point(49, 451);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(185, 90);
            btnEqual.TabIndex = 2;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn0.ForeColor = Color.FromArgb(192, 0, 0);
            btn0.Location = new Point(336, 451);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 90);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btndecimal
            // 
            btndecimal.Font = new Font("MS Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndecimal.ForeColor = Color.FromArgb(192, 0, 0);
            btndecimal.Location = new Point(240, 451);
            btndecimal.Name = "btndecimal";
            btndecimal.Size = new Size(90, 90);
            btndecimal.TabIndex = 4;
            btndecimal.Text = ".";
            btndecimal.UseVisualStyleBackColor = true;
            btndecimal.Click += btndecimal_Click;
            // 
            // btnlbrac
            // 
            btnlbrac.Font = new Font("MS Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlbrac.ForeColor = Color.FromArgb(192, 0, 0);
            btnlbrac.Location = new Point(48, 163);
            btnlbrac.Name = "btnlbrac";
            btnlbrac.Size = new Size(90, 90);
            btnlbrac.TabIndex = 5;
            btnlbrac.Text = "(";
            btnlbrac.UseVisualStyleBackColor = true;
            btnlbrac.Click += btnlbrac_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn1.ForeColor = Color.FromArgb(192, 0, 0);
            btn1.Location = new Point(240, 355);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 90);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn2.ForeColor = Color.FromArgb(192, 0, 0);
            btn2.Location = new Point(336, 355);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 90);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(192, 0, 0);
            btn3.Location = new Point(432, 355);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 90);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn4.ForeColor = Color.FromArgb(192, 0, 0);
            btn4.Location = new Point(240, 259);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 90);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(192, 0, 0);
            btn5.Location = new Point(336, 259);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 90);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn6.ForeColor = Color.FromArgb(192, 0, 0);
            btn6.Location = new Point(432, 259);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 90);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn7.ForeColor = Color.FromArgb(192, 0, 0);
            btn7.Location = new Point(240, 163);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 90);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(192, 0, 0);
            btn8.Location = new Point(336, 163);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 90);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold);
            btn9.ForeColor = Color.FromArgb(192, 0, 0);
            btn9.Location = new Point(432, 163);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 90);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Control;
            btnback.Image = (Image)resources.GetObject("btnback.Image");
            btnback.Location = new Point(528, 163);
            btnback.Name = "btnback";
            btnback.Size = new Size(90, 90);
            btnback.TabIndex = 15;
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // button14
            // 
            button14.Font = new Font("MS Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.FromArgb(192, 0, 0);
            button14.Location = new Point(528, 259);
            button14.Name = "button14";
            button14.Size = new Size(90, 186);
            button14.TabIndex = 16;
            button14.Text = "OFF";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Image = (Image)resources.GetObject("btnMultiply.Image");
            btnMultiply.Location = new Point(144, 259);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(90, 90);
            btnMultiply.TabIndex = 17;
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Image = (Image)resources.GetObject("btnDivide.Image");
            btnDivide.Location = new Point(48, 259);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(90, 90);
            btnDivide.TabIndex = 18;
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Image = (Image)resources.GetObject("btnSubtract.Image");
            btnSubtract.Location = new Point(49, 355);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(90, 90);
            btnSubtract.TabIndex = 19;
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(144, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 90);
            btnAdd.TabIndex = 20;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.ForeColor = Color.FromArgb(192, 0, 0);
            btnclear.Location = new Point(433, 451);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(185, 90);
            btnclear.TabIndex = 21;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnrbrac
            // 
            btnrbrac.Font = new Font("MS Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrbrac.ForeColor = Color.FromArgb(192, 0, 0);
            btnrbrac.Location = new Point(144, 163);
            btnrbrac.Name = "btnrbrac";
            btnrbrac.Size = new Size(90, 90);
            btnrbrac.TabIndex = 23;
            btnrbrac.Text = ")";
            btnrbrac.UseVisualStyleBackColor = true;
            btnrbrac.Click += btnrbrac_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(665, 579);
            Controls.Add(btnrbrac);
            Controls.Add(btnclear);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(button14);
            Controls.Add(btnback);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnlbrac);
            Controls.Add(btndecimal);
            Controls.Add(btn0);
            Controls.Add(btnEqual);
            Controls.Add(result);
            Controls.Add(inputbox);
            Name = "Form1";
            Text = "CALCULATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputbox;
        private TextBox result;
        private Button btnEqual;
        private Button btn0;
        private Button btndecimal;
        private Button btnlbrac;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnback;
        private Button button14;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnclear;
        private Button btnrbrac;
    }
}
