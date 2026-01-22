namespace Task4
{
    public class ProceduralSorter
    {
        public int[] Sort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
    }

    public partial class Form1 : Form
    {
        int[] numbers = { 5, 3, 2, 4, 1 };
        public Form1()
        {
            InitializeComponent();
            listBoxOriginal.DataSource = numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ProceduralSorter sorter = new ProceduralSorter();
            sorter.Sort(numbers);
            listBoxResult.DataSource = numbers;
        }
    }
}
