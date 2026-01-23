namespace lab3
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
            txtBookName = new TextBox();
            comboCategory = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            txtAuthor = new TextBox();
            btnEnterInfo = new Button();
            txtUnique = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(55, 55);
            txtBookName.Name = "txtBookName";
            txtBookName.PlaceholderText = "Enter Book Name:";
            txtBookName.Size = new Size(223, 27);
            txtBookName.TabIndex = 1;
            // 
            // comboCategory
            // 
            comboCategory.AllowDrop = true;
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "Book", "Magazine", "E-Book", "Textbook", "Audiobook" });
            comboCategory.Location = new Point(55, 153);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(223, 28);
            comboCategory.TabIndex = 2;
            comboCategory.Text = "Enter Category:";
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(343, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(404, 204);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 62);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(55, 103);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Enter Author:";
            txtAuthor.Size = new Size(223, 27);
            txtAuthor.TabIndex = 5;
            // 
            // btnEnterInfo
            // 
            btnEnterInfo.Location = new Point(55, 258);
            btnEnterInfo.Name = "btnEnterInfo";
            btnEnterInfo.Size = new Size(223, 45);
            btnEnterInfo.TabIndex = 6;
            btnEnterInfo.Text = "ENTER";
            btnEnterInfo.UseVisualStyleBackColor = true;
            btnEnterInfo.Click += btnEnterInfo_Click;
            // 
            // txtUnique
            // 
            txtUnique.Location = new Point(55, 208);
            txtUnique.Name = "txtUnique";
            txtUnique.Size = new Size(223, 27);
            txtUnique.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 55);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            label2.Text = "LOG SHEET";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtUnique);
            Controls.Add(btnEnterInfo);
            Controls.Add(txtAuthor);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(comboCategory);
            Controls.Add(txtBookName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBookName;
        private ListBox listBox1;
        private Label label1;
        private TextBox txtAuthor;
        private ComboBox comboCategory;
        private Button btnEnterInfo;
        private TextBox txtUnique;
        private Label label2;
    }
}
