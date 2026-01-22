namespace lab1
{

    public partial class Form1 : Form
    {
        int[] numbers = { 5, 3, 2, 4, 1 };

        public Form1()
        {
            InitializeComponent();
            listBoxOriginal.DataSource = numbers;
        }

        public int[] Sort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBoxResult.DataSource = Sort(numbers);
        }
    }
}
