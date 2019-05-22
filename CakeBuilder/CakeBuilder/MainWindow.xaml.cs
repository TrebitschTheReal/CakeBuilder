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
        private DataBase data = new DataBase();

        public MainWindow()
        {
            InitializeComponent();
            comboBox_ingridients.ItemsSource = data.Materials;
        }


        private void Header_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Button_Click_SaveAndExit(object sender, RoutedEventArgs e)
        {
            try
            {
                int chosenIngridient = comboBox_ingridients.SelectedIndex;
                int typedValue = int.Parse(textbox_Value.Text);

                data.Materials[chosenIngridient].UnitQuantity = typedValue;

                comboBox_ingridients.Text = "";
                textbox_Value.Text = "";
            }
            catch
            {
                string cakeName = textbox_CakeName.Text;
                Export.SaveTheCake(data, cakeName);
                Environment.Exit(0);
            }
           
        }

        private void Button_Click_AddIngridientValue(object sender, RoutedEventArgs e)
        {
            int chosenIngridient = comboBox_ingridients.SelectedIndex;
            int typedValue = int.Parse(textbox_Value.Text);

            data.Materials[chosenIngridient].UnitQuantity = typedValue;

            comboBox_ingridients.Text = "";
            textbox_Value.Text = "";
        }

        private void GenerateActualIngridientData(object sender, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                int chosenIngridient = comboBox_ingridients.SelectedIndex;
                textbox_ActualIngridientValue.Text = data.Materials[chosenIngridient].UnitQuantity.ToString();
                textbox_ActualIngridientUnitType.Text = data.Materials[chosenIngridient].UnitType;
            }
            catch { }
        }
    }
}
