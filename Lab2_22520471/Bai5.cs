using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_22520471
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }
        public class Movie
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public List<int> TicketCodes { get; set; }
            public int TicketsSold { get; set; }
            public int TicketsRemaining { get; set; }

            public double SalesRatio
            {
                get
                {
                    return (double)TicketsSold / (TicketsSold + TicketsRemaining);
                }
            }

            public int Sales
            {
                get
                {
                    return TicketsSold * Price;
                }
            }

            public Movie(string name, int price, string ticketCodes, int ticketsSold, int ticketsRemaining)
            {
                Name = name;
                Price = price;
                TicketCodes = ticketCodes.Split(',').Select(x => int.Parse(x)).ToList();
                TicketsSold = ticketsSold;
                TicketsRemaining = ticketsRemaining;
            }
        }
        List<Movie> movies;
        private void btnNhapGhi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string input = File.ReadAllText(openFileDialog.FileName);
                movies = new List<Movie>();
                string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    string[] tokens = line.Split('|');
                    Movie movie = new Movie(tokens[0], int.Parse(tokens[1]), tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]));
                    movies.Add(movie);
                }
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int totalSales = 0;
            List<Movie> sortedMovies = movies.OrderByDescending(m => m.Sales).ToList();
            using (StreamWriter writer = new StreamWriter("output5.txt"))
            {
                writer.WriteLine("TEN PHIM\tSO LUONG VE BAN RA\tSO LUONG VE TON\tTI LE VE BAN RA\tDOANH THU\tXEP HANG DOANH THU");
                for (int i = 0; i < sortedMovies.Count; i++)
                {
                    Movie movie = sortedMovies[i];
                    writer.WriteLine($"{movie.Name}\t{movie.TicketsSold}\t{movie.TicketsRemaining}\t{movie.SalesRatio:P}\t{movie.Sales}\t{i + 1}");
                    totalSales += movie.Sales;
                    progressBar.Value = (int)(((double)i / (sortedMovies.Count - 1)) * 100);
                    Application.DoEvents();
                }
            }
            MessageBox.Show($"Tong doanh thu: {totalSales}");
        }
    }
}