using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "9";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "8";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "7";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "6";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "5";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "4";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "3";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "2";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "0";
        }
    }
}
