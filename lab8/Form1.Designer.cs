namespace lab8
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
            txtISBN = new TextBox();
            label1 = new Label();
            btnFetchBook = new Button();
            label2 = new Label();
            txtBookDetails = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            lstBooks = new ListBox();
            btnSearchAuthor = new Button();
            btnPrev = new Button();
            lblPage = new Label();
            btnNext = new Button();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(54, 73);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(312, 27);
            txtISBN.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 47);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Book ISBN:";
            // 
            // btnFetchBook
            // 
            btnFetchBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFetchBook.Location = new Point(54, 243);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(312, 48);
            btnFetchBook.TabIndex = 2;
            btnFetchBook.Text = "FETCH BOOK";
            btnFetchBook.UseVisualStyleBackColor = true;
            btnFetchBook.Click += btnFetchBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(428, 47);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 4;
            label2.Text = "Book Details:";
            // 
            // txtBookDetails
            // 
            txtBookDetails.Location = new Point(428, 86);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.Size = new Size(391, 215);
            txtBookDetails.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 108);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 6;
            label3.Text = "Book Author:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(54, 134);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(312, 27);
            txtAuthor.TabIndex = 5;
            // 
            // lstBooks
            // 
            lstBooks.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(54, 330);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(765, 164);
            lstBooks.TabIndex = 7;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchAuthor.Location = new Point(54, 188);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(312, 48);
            btnSearchAuthor.TabIndex = 8;
            btnSearchAuthor.Text = "SEARCH AUTHOR";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // btnPrev
            // 
            btnPrev.Enabled = false;
            btnPrev.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(332, 513);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(55, 47);
            btnPrev.TabIndex = 9;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(402, 524);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(61, 23);
            lblPage.TabIndex = 10;
            lblPage.Text = "Page 1";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(480, 513);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(55, 47);
            btnNext.TabIndex = 11;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(882, 603);
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Controls.Add(btnPrev);
            Controls.Add(btnSearchAuthor);
            Controls.Add(lstBooks);
            Controls.Add(label3);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(txtBookDetails);
            Controls.Add(btnFetchBook);
            Controls.Add(label1);
            Controls.Add(txtISBN);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtISBN;
        private Label label1;
        private Button btnFetchBook;
        private Label label2;
        private TextBox txtBookDetails;
        private Label label3;
        private TextBox txtAuthor;
        private ListBox lstBooks;
        private Button btnSearchAuthor;
        private Button btnPrev;
        private Label lblPage;
        private Button btnNext;
    }
}
