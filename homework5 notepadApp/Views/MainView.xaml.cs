﻿using homework5_notepadApp.ViewModels;
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
using System.Windows.Shapes;

namespace homework5_notepadApp.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void newWindow_Click(object sender, RoutedEventArgs e)
        {
            MainView window = new MainView();
            window.Show();
        }

        private void zoomIncrease_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontSize++;
        }

        private void zoomDecrease_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontSize--;
        }

        private void zoomDefault_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontSize= 12;
        }
    }
}
