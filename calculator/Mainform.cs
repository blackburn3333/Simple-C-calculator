//Author : Jayendra Matarage

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace calculator
{
    public partial class Mainform : Form
    {

        public Mainform()
        {
            InitializeComponent();
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            cal_display.Text = "";
            ans_display.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if(cal_display.Text == "" || cal_display.Text == null)
            {
                cal_display.Text = "Error!, Enter numbers before calculate.";
                cal_display.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                char lastChar = cal_display.Text[cal_display.Text.Length - 1];
                if(lastChar == '+'|| lastChar == '-'|| lastChar == '/'|| lastChar == '*')
                {
                    ans_display.Text = "Error!";
                }
                else
                {
                    string answer = new DataTable().Compute(string.Join("", cal_display.Text), null).ToString();
                    ans_display.Text = answer.ToString();
                }
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "9";
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            string displayText = cal_display.Text;
            if (displayText.Length > 1)
            {
                displayText = displayText.Substring(0, displayText.Length - 1);
            }
            else
            {
                displayText = "";
            }
            cal_display.Text = displayText;

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "/";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "*";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "-";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "+";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            cal_display.Text = cal_display.Text + "0";
        }

    }
}
