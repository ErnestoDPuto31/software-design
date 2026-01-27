namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnShowBook = new Button();
            btnDeleteBook = new Button();
            btnSearchBook = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(47, 35);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name:";
            txtAuthorName.Size = new Size(284, 27);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(47, 68);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title:";
            txtBookTitle.Size = new Size(284, 27);
            txtBookTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(47, 149);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(284, 47);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "ADD BOOK";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(403, 35);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(373, 384);
            listBoxBooks.TabIndex = 3;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(47, 101);
            txtBookID.Name = "txtBookID";
            txtBookID.PlaceholderText = "Book ID:";
            txtBookID.Size = new Size(284, 27);
            txtBookID.TabIndex = 4;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(47, 260);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(284, 47);
            btnUpdateBook.TabIndex = 5;
            btnUpdateBook.Text = "UPDATE BOOK";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnShowBook
            // 
            btnShowBook.Location = new Point(47, 207);
            btnShowBook.Name = "btnShowBook";
            btnShowBook.Size = new Size(284, 47);
            btnShowBook.TabIndex = 6;
            btnShowBook.Text = "SHOW BOOK";
            btnShowBook.UseVisualStyleBackColor = true;
            btnShowBook.Click += btnShowBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(47, 318);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(284, 47);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "DELETE BOOK";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(47, 372);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(284, 47);
            btnSearchBook.TabIndex = 8;
            btnSearchBook.Text = "SEARCH AUTHOR";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnShowBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnShowBook;
        private Button btnDeleteBook;
        private Button btnSearchBook;
    }
}
