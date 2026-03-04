using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing; // Needed for Colors
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab9
{
    public partial class DataMining : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiKey = "AIzaSyA-Qlft8vRZnNLylP4kJiLL-zHHIMkOE2A";

        public DataMining()
        {
            InitializeComponent();
            ApplyProfessionalStyles();
        }

        private void ApplyProfessionalStyles()
        {
            // List all your charts here
            Chart[] charts = { chartBookCategories, chartYearTrends, chartAuthors, chartRatings };

            foreach (var chart in charts)
            {
                chart.BackColor = Color.White;
                chart.ChartAreas[0].BackColor = Color.White;
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

                if (chart.Titles.Count == 0)
                {
                    chart.Titles.Add("Chart Title"); 
                }

                chart.Titles[0].Font = new Font("Segoe UI", 10, FontStyle.Bold);
                chart.Titles[0].ForeColor = Color.DarkSlateGray;
            }
        }
        private async void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string query = txtSearchTitle.Text.Trim();
            if (string.IsNullOrEmpty(query)) return;
            var books = await FetchBooksDataAsync(query, "relevance");
            if (books != null) VisualizeCategories(books);
        }
        private async void btnShowYearTrends_Click(object sender, EventArgs e)
        {
            string query = txtSearchQuery.Text.Trim();
            if (string.IsNullOrEmpty(query)) return;

            var books = await FetchBooksDataAsync(query, "relevance");

            if (books != null)
            {
                VisualizeYears(books);
                VisualizeAuthors(books);
                VisualizeRatings(books);
            }
        }

        private async Task<JArray> FetchBooksDataAsync(string query, string orderBy)
        {
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q={query}&orderBy={orderBy}&maxResults=40&key={apiKey}";
            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                return (JArray)JObject.Parse(json)["items"];
            }
            catch
            {
                MessageBox.Show("No data found or API limit reached.");
                return null;
            }
        }

        // PIE CHART
        private void VisualizeCategories(JArray books)
        {
            var stats = new Dictionary<string, int>();

            foreach (var book in books)
            {
                var cats = book["volumeInfo"]?["categories"];
                if (cats != null)
                {
                    string cat = cats[0].ToString();
                    if (stats.ContainsKey(cat)) stats[cat]++; else stats[cat] = 1;
                }
            }

            // Group small items into "Others"
            var finalStats = new Dictionary<string, int>();
            int others = 0;
            foreach (var kvp in stats)
            {
                if (kvp.Value < 2) others += kvp.Value;
                else finalStats.Add(kvp.Key, kvp.Value);
            }
            if (others > 0) finalStats.Add("Others", others);

            chartBookCategories.Series.Clear();
            Series s = chartBookCategories.Series.Add("Categories");
            s.ChartType = SeriesChartType.Pie;

            s["PieLabelStyle"] = "Outside";
            s.BorderColor = Color.White;
            s.BorderWidth = 1;

            foreach (var pair in finalStats)
            {
                int p = s.Points.AddXY(pair.Key, pair.Value);
                s.Points[p].LegendText = pair.Key; 
                s.Points[p].Label = "#VAL";        
            }

            chartBookCategories.Legends[0].Docking = Docking.Bottom;
            chartBookCategories.Legends[0].Alignment = StringAlignment.Center;
        }

        // YEARS CHART
        private void VisualizeYears(JArray books)
        {
            var stats = new SortedDictionary<string, int>();

            foreach (var book in books)
            {
                string date = book["volumeInfo"]?["publishedDate"]?.ToString();
                if (!string.IsNullOrEmpty(date) && date.Length >= 4)
                {
                    string year = date.Substring(0, 4);
                    if (stats.ContainsKey(year)) stats[year]++; else stats[year] = 1;
                }
            }

            chartYearTrends.Series.Clear();
            Series s = chartYearTrends.Series.Add("Years");
            s.ChartType = SeriesChartType.Column;
            s.Color = Color.CornflowerBlue; 

            foreach (var pair in stats) s.Points.AddXY(pair.Key, pair.Value);
        }

        // AUTHORS CHART
        private void VisualizeAuthors(JArray books)
        {
            var stats = new Dictionary<string, int>();

            foreach (var book in books)
            {
                var authors = book["volumeInfo"]?["authors"];
                if (authors != null)
                {
                    foreach (var auth in authors)
                    {
                        string name = auth.ToString();
                        // Shorten long names
                        if (name.Length > 18) name = name.Substring(0, 15) + "...";
                        if (stats.ContainsKey(name)) stats[name]++; else stats[name] = 1;
                    }
                }
            }

            var top = stats.OrderByDescending(x => x.Value).Take(5);

            chartAuthors.Series.Clear();
            Series s = chartAuthors.Series.Add("Authors");
            s.ChartType = SeriesChartType.Bar;
            s.Color = Color.SeaGreen;

            foreach (var pair in top) s.Points.AddXY(pair.Key, pair.Value);
        }

        // RATINGS CHART
        private void VisualizeRatings(JArray books)
        {
            int[] ratings = new int[6]; 

            foreach (var book in books)
            {
                var rToken = book["volumeInfo"]?["averageRating"];
                if (rToken != null)
                {
                    double val = (double)rToken;
                    int r = (int)Math.Round(val);
                    if (r >= 1 && r <= 5) ratings[r]++;
                }
            }

            chartRatings.Series.Clear();
            Series s = chartRatings.Series.Add("Ratings");
            s.ChartType = SeriesChartType.Line;
            s.BorderWidth = 3;
            s.Color = Color.OrangeRed;
            s.MarkerStyle = MarkerStyle.Circle;
            s.MarkerSize = 8;
            for (int i = 1; i <= 5; i++)
            {
                s.Points.AddXY(i, ratings[i]);
            }

            chartRatings.ChartAreas[0].AxisX.CustomLabels.Clear();
            for (int i = 1; i <= 5; i++)
            {
                chartRatings.ChartAreas[0].AxisX.CustomLabels.Add(i - 0.5, i + 0.5, i + " ★");
            }
        }
    }
}