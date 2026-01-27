namespace lab6
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
            listBoxBooks = new ListBox();
            btnFetchBooks = new Button();
            btnAddBook = new Button();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            txtBookID = new TextBox();
            btnDeleteBook = new Button();
            btnSearchBook = new Button();
            btnUpdateBook = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(68, 37);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(292, 324);
            listBoxBooks.TabIndex = 0;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(118, 376);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(183, 44);
            btnFetchBooks.TabIndex = 1;
            btnFetchBooks.Text = "FETCH BOOKS";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(428, 161);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(306, 44);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "ADD BOOK";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(428, 37);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name:";
            txtAuthorName.Size = new Size(306, 27);
            txtAuthorName.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(428, 70);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title:";
            txtBookTitle.Size = new Size(306, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(428, 103);
            txtBookID.Name = "txtBookID";
            txtBookID.PlaceholderText = "Book ID:";
            txtBookID.Size = new Size(306, 27);
            txtBookID.TabIndex = 5;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(428, 261);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(306, 44);
            btnDeleteBook.TabIndex = 6;
            btnDeleteBook.Text = "DELETE BOOK";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(428, 311);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(306, 44);
            btnSearchBook.TabIndex = 7;
            btnSearchBook.Text = "SEARCH BOOK";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(428, 211);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(306, 44);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "UPDATE BOOK";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(428, 391);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(306, 29);
            progressBar1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 366);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 11;
            label1.Text = "Asynchornization Progress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(txtBookID);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(btnAddBook);
            Controls.Add(btnFetchBooks);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnFetchBooks;
        private Button btnAddBook;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private TextBox txtBookID;
        private Button btnDeleteBook;
        private Button btnSearchBook;
        private Button btnUpdateBook;
        private ProgressBar progressBar1;
        private Label label1;
    }
}
