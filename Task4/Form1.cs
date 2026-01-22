
namespace Task4
{
    public partial class Form1 : Form
    {
        public ListBox listBoxResults = new ListBox();
        int[] numbers = { 5, 3, 2, 4, 1 };


        public Form1()
        {
            InitializeComponent();
            listBoxOriginal.DataSource = numbers;
        }
        public int[] BubbleSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            int[] sortedNumbers = BubbleSort(numbers);
            listBoxResult.DataSource = sortedNumbers;
        }

    }
}
