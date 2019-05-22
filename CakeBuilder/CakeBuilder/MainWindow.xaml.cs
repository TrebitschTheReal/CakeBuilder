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

namespace CakeBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase data = new DataBase();
            comboBox_ingridients.ItemsSource = data.Materials;
        }


        private void Header_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Button_Click_SaveAndExit(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Your cake have been saved!", "", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
        }
    }
}
