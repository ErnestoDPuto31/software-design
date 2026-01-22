namespace lab2
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            btnCalculateFactorial = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtArrayInput = new TextBox();
            label4 = new Label();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            label6 = new Label();
            btnCalculatePower = new Button();
            label8 = new Label();
            txtBase = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtInputFibonacci = new TextBox();
            lblFibResult = new Label();
            btnCalculateFib = new Button();
            label12 = new Label();
            lblPowerResult = new Label();
            txtExponent = new TextBox();
            SuspendLayout();
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateFactorial.Location = new Point(12, 173);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(287, 32);
            btnCalculateFactorial.TabIndex = 0;
            btnCalculateFactorial.Text = "CALCULATE";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(12, 124);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 24);
            lblResult.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(12, 46);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(292, 28);
            txtInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 3;
            label1.Text = "FACTORIAL RESULT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(139, 24);
            label2.TabIndex = 4;
            label2.Text = "INPUT INTEGER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(405, 19);
            label3.Name = "label3";
            label3.Size = new Size(148, 24);
            label3.TabIndex = 6;
            label3.Text = "INPUT INTEGERS";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArrayInput.Location = new Point(405, 46);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(292, 28);
            txtArrayInput.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(405, 100);
            label4.Name = "label4";
            label4.Size = new Size(119, 24);
            label4.TabIndex = 9;
            label4.Text = "SUM RESULT:";
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSumResult.Location = new Point(405, 124);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 24);
            lblSumResult.TabIndex = 8;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateSum.Location = new Point(405, 173);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(287, 32);
            btnCalculateSum.TabIndex = 7;
            btnCalculateSum.Text = "CALCULATE";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(405, 421);
            label6.Name = "label6";
            label6.Size = new Size(144, 24);
            label6.TabIndex = 19;
            label6.Text = "POWER RESULT:";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculatePower.Location = new Point(405, 494);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(287, 32);
            btnCalculatePower.TabIndex = 17;
            btnCalculatePower.Text = "CALCULATE";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(405, 305);
            label8.Name = "label8";
            label8.Size = new Size(259, 24);
            label8.TabIndex = 16;
            label8.Text = "INPUT BASE AND EXPOENENT";
            // 
            // txtBase
            // 
            txtBase.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBase.Location = new Point(405, 332);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(292, 28);
            txtBase.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 305);
            label9.Name = "label9";
            label9.Size = new Size(139, 24);
            label9.TabIndex = 14;
            label9.Text = "INPUT INTEGER";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 386);
            label10.Name = "label10";
            label10.Size = new Size(171, 24);
            label10.TabIndex = 13;
            label10.Text = "FIBONACCI RESULT:";
            // 
            // txtInputFibonacci
            // 
            txtInputFibonacci.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputFibonacci.Location = new Point(12, 332);
            txtInputFibonacci.Name = "txtInputFibonacci";
            txtInputFibonacci.Size = new Size(292, 28);
            txtInputFibonacci.TabIndex = 12;
            // 
            // lblFibResult
            // 
            lblFibResult.AutoSize = true;
            lblFibResult.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFibResult.Location = new Point(21, 421);
            lblFibResult.Name = "lblFibResult";
            lblFibResult.Size = new Size(0, 24);
            lblFibResult.TabIndex = 11;
            // 
            // btnCalculateFib
            // 
            btnCalculateFib.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateFib.Location = new Point(12, 459);
            btnCalculateFib.Name = "btnCalculateFib";
            btnCalculateFib.Size = new Size(287, 32);
            btnCalculateFib.TabIndex = 10;
            btnCalculateFib.Text = "CALCULATE";
            btnCalculateFib.UseVisualStyleBackColor = true;
            btnCalculateFib.Click += btnCalculateFib_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 249);
            label12.Name = "label12";
            label12.Size = new Size(748, 24);
            label12.TabIndex = 20;
            label12.Text = "---------------------------------------------------------------------------------------------------------------------------";
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(405, 456);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(0, 24);
            lblPowerResult.TabIndex = 21;
            // 
            // txtExponent
            // 
            txtExponent.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExponent.Location = new Point(405, 366);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(292, 28);
            txtExponent.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(txtExponent);
            Controls.Add(lblPowerResult);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(btnCalculatePower);
            Controls.Add(label8);
            Controls.Add(txtBase);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtInputFibonacci);
            Controls.Add(lblFibResult);
            Controls.Add(btnCalculateFib);
            Controls.Add(label4);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(label3);
            Controls.Add(txtArrayInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateFactorial);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFactorial;
        private Label lblResult;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtArrayInput;
        private Label label4;
        private Label lblSumResult;
        private Label label5;
        private Button btnCalculateSum;
        private Label label6;
        private Label label7;
        private Button btnCalculatePower;
        private Button button1;
        private Label label8;
        private TextBox txtBase;
        private TextBox textBox1;
        private Label label9;
        private Label label10;
        private TextBox txtInputFibonacci;
        private Label lblFibResult;
        private Button btnCalculateFib;
        private Label label12;
        private Label lblPowerResult;
        private TextBox txtExponent;
    }
}
