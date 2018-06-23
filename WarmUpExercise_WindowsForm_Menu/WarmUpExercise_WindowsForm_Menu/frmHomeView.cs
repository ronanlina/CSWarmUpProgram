using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WarmUpExercise_Menu;

namespace WarmUpExercise_WindowsForm_Menu
{
    public partial class HomeActivity : Form
    {
        public HomeActivity()
        {
            InitializeComponent();
            HomeViewRestore();
        }

        /// View Codes
        
        private void btnOEResult_Click(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(txtOEInput.Text, out value))
            {
                lblOEResult.Text = new OddEven(value).IsOddEven();
                lblOEResult.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSwapperResult_Click(object sender, EventArgs e)
        {
            int valueA, valueB;

            if (int.TryParse(txtSwapValA.Text, out valueA) && int.TryParse(txtSwapValB.Text, out valueB))
            {
                txtSwapValA.Text = new Swapper(valueA, valueB).Swap().ToString();
                txtSwapValB.Text = new Swapper(valueB, valueA).Swap().ToString();
            }
        }

        private void btnSODResult_Click(object sender, EventArgs e)
        {
            int value;

            if(int.TryParse(txtSODInput.Text, out value))
            {   
                lblSODResult.Text = new SumOfDigits(value).GetSum().ToString();
                lblSODResult.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnReverseResult_Click(object sender, EventArgs e)
        {
            int value;

            if(int.TryParse(txtReverseInput.Text, out value))
            {
                lblReverseResult.Text = new Reverse(value).DoReverse().ToString();
                lblReverseResult.ForeColor = System.Drawing.Color.Black;
            }
        }

        /// View Buttons

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeViewRestore();
        }
        private void btnOddEven_Click(object sender, EventArgs e)
        {
            ViewOpener(1);
        }

        private void btnSwapper_Click(object sender, EventArgs e)
        {
            ViewOpener(2);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            ViewOpener(3);
        }

        private void btnSumOfDigits_Click(object sender, EventArgs e)
        {
            ViewOpener(4);
        }

        ///Helper Methods
        private void ViewOpener(int index)
        {
            switch(index)
            {
                case 1:
                    OddEvenView.Show(); frmHomeView.Hide();break;
                case 2:
                    SwapperView.Show(); frmHomeView.Hide();break;
                case 3:
                    ReverseView.Show(); frmHomeView.Hide();break;
                case 4:
                    SumOfDigitsView.Show(); frmHomeView.Hide();break;
            }
        }
        private void HomeViewRestore()
        {
            OddEvenView.Hide();
            SumOfDigitsView.Hide();
            ReverseView.Hide();
            SwapperView.Hide();
            frmHomeView.Show();
        }
    }
}
