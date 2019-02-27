using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Book> booklist = new List<Book>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Book b1 = new Book()
            {
                Name = "The catcher in the rye",
                Description = "J.D. Salinger's classic novel of teenage angst and rebellion was first published in 1951. The novel was included on Time's 2005 list of the 100 best English-language novels written since 1923. It was named by Modern Library and its readers as one of the 100 best English-language novels of the 20th century.",
                price = 9.99M
            };
            Book b2 = new Book()
            {
                Name = "1984",
                Description = "Among the seminal texts of the 20th century, Nineteen Eighty-Four is a rare work that grows more haunting as its futuristic purgatory becomes more real.",
                price = 12.99M
            };
            Book b3 = new Book()
            {
                Name = "To kill a mockingbird",
                Description = "Compassionate, dramatic and deeply moving. To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience,kindness and cruelty, love and hatred,humor and pathos.Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal.Harper Lee always considered her book to be a simple love story.Today it is regarded as a masterpiece of American literature.",
                price = 7.99M
            };

            booklist.Add(b1);
            booklist.Add(b2);
            booklist.Add(b3);

            lstbx.ItemsSource = booklist;

        }

        private void lstbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book selectedBook = lstbx.SelectedItem as Book;

            if(selectedBook != null)
            {
                tblkTitle.Text = selectedBook.Name;
                Desc.Text = selectedBook.Description;
                pricebx.Text = selectedBook.price.ToString();
            }
        }

        private void Incbtn_Click(object sender, RoutedEventArgs e)
        {
            Book selectedBook = lstbx.SelectedItem as Book;

            if(selectedBook != null)
            {
                selectedBook.price += 0.1m;

                pricebx.Text = selectedBook.price.ToString();
            }
        }

        private void decbtn_Click(object sender, RoutedEventArgs e)
        {
            Book selectedBook = lstbx.SelectedItem as Book;

            if (selectedBook != null)
            {
                selectedBook.price -= 0.1m;

                pricebx.Text = selectedBook.price.ToString();
            }
        }
    }
}
