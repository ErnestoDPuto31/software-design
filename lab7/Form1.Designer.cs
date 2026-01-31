namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxBooks = new ListBox();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            lblPageNumber = new Label();
            btnExportBooks = new Button();
            btnImport = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(12, 23);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(358, 344);
            listBoxBooks.TabIndex = 0;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(229, 383);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(39, 383);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 2;
            btnPreviousPage.Text = "<";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(168, 388);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(17, 20);
            lblPageNumber.TabIndex = 3;
            lblPageNumber.Text = "1";
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(407, 321);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(177, 46);
            btnExportBooks.TabIndex = 4;
            btnExportBooks.Text = "EXPORT BOOKS";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(605, 321);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(177, 46);
            btnImport.TabIndex = 5;
            btnImport.Text = "IMPORT BOOK";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(407, 231);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 46);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(407, 198);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Books";
            txtSearch.Size = new Size(305, 27);
            txtSearch.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(407, 85);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Author:";
            txtAuthor.Size = new Size(305, 27);
            txtAuthor.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(407, 52);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title:";
            txtTitle.Size = new Size(305, 27);
            txtTitle.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(407, 118);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 46);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnImport);
            Controls.Add(btnExportBooks);
            Controls.Add(lblPageNumber);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnNextPage);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Label lblPageNumber;
        private Button btnExportBooks;
        private Button btnImport;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Button btnSave;
    }
}