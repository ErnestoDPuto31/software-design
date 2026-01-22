namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = txtInput.Text
                    .Split(',')
                    .Select(n => int.Parse(n.Trim()))
                    .ToArray();

                BubbleSort(numbers);

                lblResult.Text = string.Join(", ", numbers);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid integers separated by commas.\nExample: 5, 3, 8, 1",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
