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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int a, b, compar_result;
        string sign;
        bool result;

        private void BoxTwo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (result = int.TryParse(BoxOne.Text, out a))
            {
                if (BoxTwo.Text != null)
                {
                    int.TryParse(BoxTwo.Text, out b);
                    compar_result = a > b ? a : b;
                    sign = a > b ? ">" : a < b ? "<" : "=";

                    ResultText.Text = $"a {sign} b";
                }

            }
            else
            {
                ResultText.Text = "Некорректные \nзначения";
            }
        }

        private void BoxOne_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (result = int.TryParse(BoxTwo.Text, out b))
            {
                if (BoxOne.Text != null)
                {
                    int.TryParse(BoxOne.Text, out a);
                    compar_result = a > b ? a : b;
                    sign = a > b ? ">" : a < b ? "<" : "=";

                    ResultText.Text = $"a {sign} b";
                }

            }
            else
            {
                ResultText.Text = "Некорректные \nзначения";
            }
        }
    }
}
