namespace calculator
{
    partial class Mainform
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
            this.ans_display = new System.Windows.Forms.Label();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.cal_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ans_display
            // 
            this.ans_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ans_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans_display.Location = new System.Drawing.Point(14, 38);
            this.ans_display.Name = "ans_display";
            this.ans_display.Size = new System.Drawing.Size(318, 54);
            this.ans_display.TabIndex = 0;
            this.ans_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ac
            // 
            this.btn_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ac.Location = new System.Drawing.Point(12, 95);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(156, 46);
            this.btn_ac.TabIndex = 1;
            this.btn_ac.Text = "AC";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_erase.Location = new System.Drawing.Point(174, 95);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(158, 46);
            this.btn_erase.TabIndex = 2;
            this.btn_erase.Text = "<-";
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(255, 147);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 75);
            this.btn_divide.TabIndex = 4;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(255, 228);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(75, 75);
            this.btn_multi.TabIndex = 8;
            this.btn_multi.Text = "X";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.Location = new System.Drawing.Point(174, 147);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(75, 75);
            this.btn_nine.TabIndex = 7;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.Location = new System.Drawing.Point(93, 147);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(75, 75);
            this.btn_eight.TabIndex = 6;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.Location = new System.Drawing.Point(12, 147);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(75, 75);
            this.btn_seven.TabIndex = 5;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(255, 309);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 75);
            this.btn_sub.TabIndex = 12;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_six
            // 
            this.btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.Location = new System.Drawing.Point(174, 228);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(75, 75);
            this.btn_six.TabIndex = 11;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_five
            // 
            this.btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.Location = new System.Drawing.Point(93, 228);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(75, 75);
            this.btn_five.TabIndex = 10;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_four
            // 
            this.btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.Location = new System.Drawing.Point(12, 228);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(75, 75);
            this.btn_four.TabIndex = 9;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(255, 390);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 75);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_three
            // 
            this.btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.Location = new System.Drawing.Point(174, 309);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(75, 75);
            this.btn_three.TabIndex = 15;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.Location = new System.Drawing.Point(93, 309);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(75, 75);
            this.btn_two.TabIndex = 14;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_one
            // 
            this.btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.Location = new System.Drawing.Point(12, 309);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(75, 75);
            this.btn_one.TabIndex = 13;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.Location = new System.Drawing.Point(174, 390);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 75);
            this.btn_equal.TabIndex = 20;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.Location = new System.Drawing.Point(12, 390);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(156, 75);
            this.btn_zero.TabIndex = 17;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // cal_display
            // 
            this.cal_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_display.Location = new System.Drawing.Point(14, 6);
            this.cal_display.Name = "cal_display";
            this.cal_display.Size = new System.Drawing.Size(318, 29);
            this.cal_display.TabIndex = 21;
            this.cal_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 477);
            this.Controls.Add(this.cal_display);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.ans_display);
            this.Name = "Mainform";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ans_display;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Label cal_display;
    }
}

