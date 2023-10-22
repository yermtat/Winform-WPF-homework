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

namespace homework4_ImdbAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string res = DownloadService.DownloadJson("https://imdb8.p.rapidapi.com/title/find?q=titanic");
            //Rootobject obj = DeserializeService.DeserializeJson<Rootobject>(res);

        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            var searchResult = MovieService.GetMovies(movieTitleTextBox.Text);

            movieList.ItemsSource = searchResult.Results;
        }
    }
}
