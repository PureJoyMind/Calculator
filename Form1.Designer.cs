namespace Calculator
{
    partial class Calculator
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
            resultBox = new TextBox();
            one = new Button();
            two = new Button();
            three = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            seven = new Button();
            nine = new Button();
            eight = new Button();
            zero = new Button();
            point = new Button();
            subtract = new Button();
            plus = new Button();
            times = new Button();
            divide = new Button();
            Enter = new Button();
            pClose = new Button();
            pOpen = new Button();
            label1 = new Label();
            answerBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.Location = new Point(3, 12);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(410, 34);
            resultBox.TabIndex = 0;
            resultBox.Text = "Enter expression";
            // 
            // one
            // 
            one.Location = new Point(29, 272);
            one.Name = "one";
            one.Size = new Size(40, 40);
            one.TabIndex = 1;
            one.Tag = "1";
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += genericButton_click;
            // 
            // two
            // 
            two.Location = new Point(88, 272);
            two.Name = "two";
            two.Size = new Size(40, 40);
            two.TabIndex = 2;
            two.Tag = "2";
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += genericButton_click;
            // 
            // three
            // 
            three.Location = new Point(147, 272);
            three.Name = "three";
            three.Size = new Size(40, 40);
            three.TabIndex = 3;
            three.Tag = "3";
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += genericButton_click;
            // 
            // six
            // 
            six.Location = new Point(147, 213);
            six.Name = "six";
            six.Size = new Size(40, 40);
            six.TabIndex = 6;
            six.Tag = "6";
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += genericButton_click;
            // 
            // five
            // 
            five.Location = new Point(88, 213);
            five.Name = "five";
            five.Size = new Size(40, 40);
            five.TabIndex = 5;
            five.Tag = "5";
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += genericButton_click;
            // 
            // four
            // 
            four.Location = new Point(29, 213);
            four.Name = "four";
            four.Size = new Size(40, 40);
            four.TabIndex = 4;
            four.Tag = "4";
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += genericButton_click;
            // 
            // seven
            // 
            seven.Location = new Point(29, 153);
            seven.Name = "seven";
            seven.Size = new Size(40, 40);
            seven.TabIndex = 7;
            seven.Tag = "7";
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += genericButton_click;
            // 
            // nine
            // 
            nine.Location = new Point(147, 153);
            nine.Name = "nine";
            nine.Size = new Size(40, 40);
            nine.TabIndex = 9;
            nine.Tag = "9";
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += genericButton_click;
            // 
            // eight
            // 
            eight.Location = new Point(88, 153);
            eight.Name = "eight";
            eight.Size = new Size(40, 40);
            eight.TabIndex = 8;
            eight.Tag = "8";
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += genericButton_click;
            // 
            // zero
            // 
            zero.Location = new Point(29, 331);
            zero.Name = "zero";
            zero.Size = new Size(99, 40);
            zero.TabIndex = 10;
            zero.Tag = "0";
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += genericButton_click;
            // 
            // point
            // 
            point.Location = new Point(147, 331);
            point.Name = "point";
            point.Size = new Size(40, 40);
            point.TabIndex = 11;
            point.Tag = "8";
            point.Text = ".";
            point.UseVisualStyleBackColor = true;
            point.Click += genericButton_click;
            // 
            // subtract
            // 
            subtract.Location = new Point(281, 272);
            subtract.Name = "subtract";
            subtract.Size = new Size(40, 40);
            subtract.TabIndex = 15;
            subtract.Tag = "4";
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += genericButton_click;
            // 
            // plus
            // 
            plus.Location = new Point(340, 272);
            plus.Name = "plus";
            plus.Size = new Size(40, 40);
            plus.TabIndex = 14;
            plus.Tag = "3";
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += genericButton_click;
            // 
            // times
            // 
            times.Location = new Point(340, 213);
            times.Name = "times";
            times.Size = new Size(40, 40);
            times.TabIndex = 13;
            times.Tag = "2";
            times.Text = "*";
            times.UseVisualStyleBackColor = true;
            times.Click += genericButton_click;
            // 
            // divide
            // 
            divide.Location = new Point(281, 213);
            divide.Name = "divide";
            divide.Size = new Size(40, 40);
            divide.TabIndex = 12;
            divide.Tag = "1";
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += genericButton_click;
            // 
            // Enter
            // 
            Enter.Location = new Point(281, 331);
            Enter.Name = "Enter";
            Enter.Size = new Size(99, 40);
            Enter.TabIndex = 17;
            Enter.Tag = "0";
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // pClose
            // 
            pClose.Location = new Point(340, 153);
            pClose.Name = "pClose";
            pClose.Size = new Size(40, 40);
            pClose.TabIndex = 19;
            pClose.Tag = "2";
            pClose.Text = ")";
            pClose.UseVisualStyleBackColor = true;
            pClose.Click += genericButton_click;
            // 
            // pOpen
            // 
            pOpen.Location = new Point(281, 153);
            pOpen.Name = "pOpen";
            pOpen.Size = new Size(40, 40);
            pOpen.TabIndex = 18;
            pOpen.Tag = "1";
            pOpen.Text = "(";
            pOpen.UseVisualStyleBackColor = true;
            pOpen.Click += genericButton_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 76);
            label1.Name = "label1";
            label1.Size = new Size(32, 35);
            label1.TabIndex = 20;
            label1.Text = "=";
            // 
            // answerBox
            // 
            answerBox.Location = new Point(41, 79);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(372, 34);
            answerBox.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(205, 153);
            button1.Name = "button1";
            button1.Size = new Size(59, 65);
            button1.TabIndex = 22;
            button1.Tag = "9";
            button1.Text = "CE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(417, 407);
            Controls.Add(button1);
            Controls.Add(answerBox);
            Controls.Add(label1);
            Controls.Add(pClose);
            Controls.Add(pOpen);
            Controls.Add(Enter);
            Controls.Add(subtract);
            Controls.Add(plus);
            Controls.Add(times);
            Controls.Add(divide);
            Controls.Add(point);
            Controls.Add(zero);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(resultBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultBox;
        private Button one;
        private Button two;
        private Button three;
        private Button six;
        private Button five;
        private Button four;
        private Button seven;
        private Button nine;
        private Button eight;
        private Button zero;
        private Button point;
        private Button subtract;
        private Button plus;
        private Button times;
        private Button divide;
        private Button Enter;
        private Button pClose;
        private Button pOpen;
        private Label label1;
        private TextBox answerBox;
        private Button button1;
    }
}