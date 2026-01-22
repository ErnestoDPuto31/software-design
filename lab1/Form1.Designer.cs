namespace lab1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSort = new Button();
            listBoxResult = new ListBox();
            label1 = new Label();
            listBoxOriginal = new ListBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(54, 306);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(121, 56);
            btnSort.TabIndex = 0;
            btnSort.Text = "SORT";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 24;
            listBoxResult.Location = new Point(214, 70);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(532, 292);
            listBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 70);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 2;
            label1.Text = "ORIGINAL ARRAY";
            // 
            // listBoxOriginal
            // 
            listBoxOriginal.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxOriginal.FormattingEnabled = true;
            listBoxOriginal.ItemHeight = 21;
            listBoxOriginal.Location = new Point(47, 103);
            listBoxOriginal.Name = "listBoxOriginal";
            listBoxOriginal.Size = new Size(140, 172);
            listBoxOriginal.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxOriginal);
            Controls.Add(label1);
            Controls.Add(listBoxResult);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResult;
        private Label label1;
        private ListBox listBoxOriginal;
    }
}
