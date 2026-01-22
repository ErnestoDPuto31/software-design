namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // HINTS
            txtInput.PlaceholderText = "e.g. 5 ";
            txtArrayInput.PlaceholderText = "e.g. 1, 2, 3, 4, 5...";
            txtInputFibonacci.PlaceholderText = "e.g. 7 ";
            txtBase.PlaceholderText = "e.g. 2";
            txtExponent.PlaceholderText = "e.g. 3";
        }

        public int RecursiveFactorial(int n)
        {
            if (n <= 1) return 1;
            else return n * RecursiveFactorial(n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtInput.Text);
                int result = RecursiveFactorial(number);
                lblResult.Text = $"Factorial of {number} is {result}";
            }
            catch (FormatException)
            {
                lblResult.Text = "Invalid input format. \nPlease enter a valid integer.";
            }
        }
        public int RecursiveSum(int[] arr, int index)
        {
            if (index < 0) return 0;
            else return arr[index] + RecursiveSum(arr, index - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
                int result = RecursiveSum(numbers, numbers.Length - 1);
                lblSumResult.Text = $"Sum of array elements is {result}";
            }
            catch (FormatException)
            {
                lblSumResult.Text = "Invalid input format. \nPlease enter integers separated by commas.";
            }
        }

        public int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            else if (n == 1) return 1;
            else return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        public int RecursivePower(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            else return baseNum * RecursivePower(baseNum, exponent - 1);
        }

        private void btnCalculateFib_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtInputFibonacci.Text);
                int result = RecursiveFibonacci(number);
                lblFibResult.Text = $"{number}th Fibonacci is {result}";
            }
            catch (FormatException)
            {
                lblFibResult.Text = "Invalid input format. \nPlease enter a valid integer.";
            }
        }

        private void btnCalculatePower_Click_1(object sender, EventArgs e)
        {
            try
            {
                int baseNum = int.Parse(txtBase.Text);
                int exponent = int.Parse(txtExponent.Text);
                int result = RecursivePower(baseNum, exponent);
                lblPowerResult.Text = $"{baseNum} to the power of {exponent} is {result}";
            }
            catch (FormatException)
            {
                lblPowerResult.Text = "Invalid input format. \nPlease enter valid integers for base and exponent.";
            }
        }
    }
}
