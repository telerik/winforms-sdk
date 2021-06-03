using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RadGridViewMultithreading
{
    public partial class Form1 : Form
    {
        private BindingList<Book> books = new BindingList<Book>();

        public Form1()
        {
            InitializeComponent();

            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.DataSource = this.books;
            this.FetchData(this.books, 5000);
        }

        private bool stop;
        public void FetchData(IList<Book> dataSourceToFill, int interval, int maxFetches = -1)
        {
            Thread dataThread = new Thread(() => this.FetchDataCore(dataSourceToFill, maxFetches, interval));
            dataThread.IsBackground = true;
            dataThread.Start();
        }

        private void FetchDataCore(IList<Book> dataSourceToFill, int maxFetches, int interval)
        {
            int fetchesCount = 0;
            while (fetchesCount <= maxFetches || !this.stop)
            {
                IEnumerable<Book> fetchedBooks = this.GetAndParseData(15);
                //simulate server wait time
                Thread.Sleep(1500);

                //actual wait time passed as a parameter
                Thread.Sleep(interval);
                this.AddBooks(fetchedBooks, dataSourceToFill);

                fetchesCount++;
            }
        }
  
        private void AddBooks(IEnumerable<Book> fetchedBooks, IList<Book> dataSourceToFill)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => this.AddBooks(fetchedBooks, dataSourceToFill)));
                return;
            }

            foreach (Book book in fetchedBooks)
            {
                dataSourceToFill.Add(book);
            }
        }

        private IEnumerable<Book> GetAndParseData(int count)
        {
            string[] rawFormatBooks = DataGenerator.GenerateBooks(count);
            List<Book> parsedBooks = new List<Book>();

            foreach (string rawBook in rawFormatBooks)
            {
                string[] bookParams = rawBook.Split(',');
                int id = int.Parse(bookParams[0]);
                string name = bookParams[1];
                string authorName = bookParams[2];
                DateTime publishDate = DateTime.Parse(bookParams[3]);
                Book newBook = new Book(id, name, authorName, publishDate);
                parsedBooks.Add(newBook);
            }

            return parsedBooks;
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishDate { get; set; }

        public Book(int id, string name, string authorName, DateTime publishDate)
        {
            this.Id = id;
            this.Name = name;
            this.AuthorName = authorName;
            this.PublishDate = publishDate;
        }
    }

    public static class DataGenerator
    {
        private static Random random = new Random();

        public static Random Random
        {
            get { return random; }
        }

        public static string[] GenerateBooks(int count)
        {
            string[] books = new string[count];
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = GenerateBook();
            }

            return books;
        }

        public static string GenerateBook()
        {
            int id = Random.Next();
            string name = string.Format("Book {0}", id);
            string authorName = string.Format("Author {0}", id);
            DateTime publishDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-Random.Next(100, 1000));

            string book = string.Format("{0},{1},{2},{3}", id, name, authorName, publishDate);
            return book;
        }
    }
}