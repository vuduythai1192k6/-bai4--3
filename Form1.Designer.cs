namespace bai4_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btncong = new Button();
            btntru = new Button();
            btnnhan = new Button();
            btnchia = new Button();
            btnc = new Button();
            btnbang = new Button();
            SuspendLayout();

            // txtDisplay
            txtDisplay.Location = new Point(26, 30);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(476, 27);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;

            // btn1
            btn1.Location = new Point(26, 80);
            btn1.Name = "btn1";
            btn1.Size = new Size(93, 70);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;

            // btn2
            btn2.Location = new Point(125, 80);
            btn2.Name = "btn2";
            btn2.Size = new Size(93, 70);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;

            // btn3
            btn3.Location = new Point(224, 80);
            btn3.Name = "btn3";
            btn3.Size = new Size(93, 70);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;

            // btncong
            btncong.Location = new Point(360, 80);
            btncong.Name = "btncong";
            btncong.Size = new Size(68, 70);
            btncong.TabIndex = 4;
            btncong.Text = "+";
            btncong.UseVisualStyleBackColor = true;
            btncong.Click += PhepToan_Click;

            // btntru
            btntru.Location = new Point(434, 80);
            btntru.Name = "btntru";
            btntru.Size = new Size(68, 70);
            btntru.TabIndex = 5;
            btntru.Text = "-";
            btntru.UseVisualStyleBackColor = true;
            btntru.Click += PhepToan_Click;

            // btn4
            btn4.Location = new Point(26, 155);
            btn4.Name = "btn4";
            btn4.Size = new Size(93, 70);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;

            // btn5
            btn5.Location = new Point(125, 155);
            btn5.Name = "btn5";
            btn5.Size = new Size(93, 70);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;

            // btn6
            btn6.Location = new Point(224, 155);
            btn6.Name = "btn6";
            btn6.Size = new Size(93, 70);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;

            // btnnhan
            btnnhan.Location = new Point(360, 155);
            btnnhan.Name = "btnnhan";
            btnnhan.Size = new Size(68, 70);
            btnnhan.TabIndex = 9;
            btnnhan.Text = "x";
            btnnhan.UseVisualStyleBackColor = true;
            btnnhan.Click += PhepToan_Click;

            // btnchia
            btnchia.Location = new Point(434, 155);
            btnchia.Name = "btnchia";
            btnchia.Size = new Size(68, 70);
            btnchia.TabIndex = 10;
            btnchia.Text = ":";
            btnchia.UseVisualStyleBackColor = true;
            btnchia.Click += PhepToan_Click;

            // btn7
            btn7.Location = new Point(26, 230);
            btn7.Name = "btn7";
            btn7.Size = new Size(93, 70);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;

            // btn8
            btn8.Location = new Point(125, 230);
            btn8.Name = "btn8";
            btn8.Size = new Size(93, 70);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;

            // btn9
            btn9.Location = new Point(224, 230);
            btn9.Name = "btn9";
            btn9.Size = new Size(93, 70);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;

            // btnc
            btnc.BackColor = Color.Coral;
            btnc.Location = new Point(360, 230);
            btnc.Name = "btnc";
            btnc.Size = new Size(68, 70);
            btnc.TabIndex = 14;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = false;
            btnc.Click += btnc_Click;

            // btnbang
            btnbang.Location = new Point(434, 230);
            btnbang.Name = "btnbang";
            btnbang.Size = new Size(68, 70);
            btnbang.TabIndex = 15;
            btnbang.Text = "=";
            btnbang.UseVisualStyleBackColor = true;
            btnbang.Click += btnbang_Click;

            // btn0
            btn0.Location = new Point(26, 305);
            btn0.Name = "btn0";
            btn0.Size = new Size(291, 70);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 410);
            Controls.Add(btnbang);
            Controls.Add(btnc);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnchia);
            Controls.Add(btnnhan);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btntru);
            Controls.Add(btncong);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "May tinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btncong;
        private Button btntru;
        private Button btnnhan;
        private Button btnchia;
        private Button btnc;
        private Button btnbang;
    }
}