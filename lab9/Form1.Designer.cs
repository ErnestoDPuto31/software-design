namespace lab9
{
	partial class DataMining
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            txtSearchTitle = new TextBox();
            btnSearchBooks = new Button();
            label1 = new Label();
            label2 = new Label();
            chartBookCategories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            txtSearchQuery = new TextBox();
            btnShowYearTrends = new Button();
            chartYearTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartAuthors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            chartRatings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartBookCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartYearTrends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAuthors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRatings).BeginInit();
            SuspendLayout();
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTitle.Location = new Point(49, 67);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(375, 30);
            txtSearchTitle.TabIndex = 0;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBooks.Location = new Point(49, 113);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(375, 47);
            btnSearchBooks.TabIndex = 1;
            btnSearchBooks.Text = "Search for Categories";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 35);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 2;
            label1.Text = "Book TItle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 203);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 4;
            label2.Text = "Book TItle";
            // 
            // chartBookCategories
            // 
            chartArea1.Name = "ChartArea1";
            chartBookCategories.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBookCategories.Legends.Add(legend1);
            chartBookCategories.Location = new Point(49, 188);
            chartBookCategories.Name = "chartBookCategories";
            chartBookCategories.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBookCategories.Series.Add(series1);
            chartBookCategories.Size = new Size(454, 270);
            chartBookCategories.TabIndex = 3;
            chartBookCategories.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(553, 35);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 4;
            label3.Text = "Search Query";
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchQuery.Location = new Point(553, 67);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(375, 30);
            txtSearchQuery.TabIndex = 5;
            // 
            // btnShowYearTrends
            // 
            btnShowYearTrends.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowYearTrends.Location = new Point(553, 113);
            btnShowYearTrends.Name = "btnShowYearTrends";
            btnShowYearTrends.Size = new Size(375, 47);
            btnShowYearTrends.TabIndex = 6;
            btnShowYearTrends.Text = "Show Year Trends";
            btnShowYearTrends.UseVisualStyleBackColor = true;
            btnShowYearTrends.Click += btnShowYearTrends_Click;
            // 
            // chartYearTrends
            // 
            chartArea2.Name = "ChartArea1";
            chartYearTrends.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartYearTrends.Legends.Add(legend2);
            chartYearTrends.Location = new Point(553, 188);
            chartYearTrends.Name = "chartYearTrends";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartYearTrends.Series.Add(series2);
            chartYearTrends.Size = new Size(454, 270);
            chartYearTrends.TabIndex = 7;
            chartYearTrends.Text = "chart2";
            // 
            // chartAuthors
            // 
            chartArea3.Name = "ChartArea1";
            chartAuthors.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartAuthors.Legends.Add(legend3);
            chartAuthors.Location = new Point(49, 525);
            chartAuthors.Name = "chartAuthors";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartAuthors.Series.Add(series3);
            chartAuthors.Size = new Size(454, 284);
            chartAuthors.TabIndex = 8;
            chartAuthors.Text = "chart1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 494);
            label4.Name = "label4";
            label4.Size = new Size(195, 23);
            label4.TabIndex = 9;
            label4.Text = "Most Frequent Authors";
            // 
            // chartRatings
            // 
            chartArea4.Name = "ChartArea1";
            chartRatings.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartRatings.Legends.Add(legend4);
            chartRatings.Location = new Point(553, 525);
            chartRatings.Name = "chartRatings";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartRatings.Series.Add(series4);
            chartRatings.Size = new Size(454, 284);
            chartRatings.TabIndex = 10;
            chartRatings.Text = "chart1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(553, 494);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 11;
            label5.Text = "Average Ratings";
            label5.UseCompatibleTextRendering = true;
            // 
            // DataMining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 853);
            Controls.Add(label5);
            Controls.Add(chartRatings);
            Controls.Add(label4);
            Controls.Add(chartAuthors);
            Controls.Add(chartYearTrends);
            Controls.Add(btnShowYearTrends);
            Controls.Add(txtSearchQuery);
            Controls.Add(label3);
            Controls.Add(chartBookCategories);
            Controls.Add(label1);
            Controls.Add(btnSearchBooks);
            Controls.Add(txtSearchTitle);
            Name = "DataMining";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartBookCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartYearTrends).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAuthors).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRatings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearchBooks;
        private Label label1;
        private Label label2;
        private TextBox txtSearchTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookCategories;
        private Label label3;
        private TextBox txtSearchQuery;
        private Button btnShowYearTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAuthors;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRatings;
        private Label label5;
    }
}
