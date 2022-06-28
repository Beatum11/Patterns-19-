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
using Patterns_19_.Data;
using Patterns_19_.Presenters;

namespace Patterns_19_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region События
        public event Action CreateEvent;
        public event Action ShowListEvent;
        public event Action SaveTxtEvent;
        public event Action SaveDocxEvent;

        #endregion


        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }


        #region Кнопки

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            CreateEvent.Invoke();
        }

        private void showListButton_Click(object sender, RoutedEventArgs e)
        {
            ShowListEvent.Invoke();
        }

        private void downloadTxtButton_Click(object sender, RoutedEventArgs e)
        {
            SaveTxtEvent.Invoke();
            MessageBox.Show($"Данные успешно сохранены");
        }

        private void downloadDocxButton_Click(object sender, RoutedEventArgs e)
        {
            SaveDocxEvent.Invoke();
            MessageBox.Show($"Данные успешно сохранены");
        }

        #endregion


    }
}
