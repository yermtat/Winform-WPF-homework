using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace homework3_ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BindingList<toDoItem> ToDoList { get; set; } = new();
        public MainWindow()
        {
            InitializeComponent();
            
            ToDoList = fileOperationService.LoadFromFile();
            taskLisBox.ItemsSource= ToDoList;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToDoList.Add(new toDoItem()
                {
                    Task = taskTextBox.Text,
                    Due = dueTime.SelectedDate.Value.Date,
                    CreationTime = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter info");
            }
            fileOperationService.SaveToFile(ToDoList);
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (taskLisBox.SelectedItem == null)
            {
                MessageBox.Show("Select an item");
            }
            else
            {
                ToDoList.Remove((toDoItem)taskLisBox.SelectedItem);
                fileOperationService.SaveToFile(ToDoList);
            }
        }
    }
}
