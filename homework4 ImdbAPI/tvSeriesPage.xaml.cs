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
using System.Windows.Xps;

namespace homework4_ImdbAPI
{
    /// <summary>
    /// Interaction logic for tvSeriesPage.xaml
    /// </summary>
    public partial class tvSeriesPage : Page
    {
        public tvSeriesPage(Result tvSeries)
        {
            InitializeComponent();

            tvSeriesTitle.Content = tvSeries.Title;
            numberOfEpisodesLabel.Content = tvSeries.NumberOfEpisodes;
            startYearLabel.Content = tvSeries.SeriesStartYear;

            if (tvSeries.SeriesEndYear != 0)
                endYearLabel.Content = tvSeries.SeriesEndYear;
            else
                endYearLabel.Content = "-";                                                

            runningTimeLabel.Content = tvSeries.RunningTimeInMinutes;

            actorsList.ItemsSource = tvSeries.Principals;

            poster.Source = new BitmapImage(new Uri(tvSeries.Image.Url));

        }
    }
}
