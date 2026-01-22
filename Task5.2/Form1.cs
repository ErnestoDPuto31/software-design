using System;
using System.Windows.Forms;
using Task5._2;

namespace Task5._2
{

    public partial class Form1 : Form
    {
        int[] numbers = { 10, 2, 7, 4, 9 };
        public Form1()
        {
            InitializeComponent();
            originalNums.Text = string.Join(", ", numbers);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            DescendingSorter sorter = new DescendingSorter();
            sorter.SortDescending(numbers);

            lblResult.Text = string.Join(", ", numbers);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
