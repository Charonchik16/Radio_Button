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

namespace Radio_button
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int corectly_answers;
        public MainWindow()
        {
            InitializeComponent();
   
        }
        private void Radio_Button(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed == cpp)
            {
                corectly_answers++;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (corectly_answers > 0)
            {
                MessageBox.Show("Вы ответили правильно");
            }
            else
            {
                MessageBox.Show("Неверно. Правильные ответ: Cpp"); 
            }
            Close();
        }
    }
}
