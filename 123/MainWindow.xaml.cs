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


namespace WpfApp28
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            string fio = textBox.Text;
            string mail = textBox_Copy.Text;
            string phone = textBox_Copy1.Text;
            string snils = textBox_Copy2.Text;
            
            if ((mail.Contains("@") && mail.Contains(",") == false && mail.Contains("'") == false && mail.Contains("*") == false && mail.Contains("#") == false && mail.Contains("$") == false && mail.Contains("^") == false && mail.Contains("&") == false && mail.Contains("(") == false && mail.Contains(")") == false && mail.Contains("-") == false && mail.Contains("+") == false && mail.Contains("=") == false && mail.Contains(";") == false && mail.Contains(":") == false && mail.Contains("/") == false && mail.Contains("?") == false && mail.Contains(">") == false && mail.Contains("<") == false && mail.Contains("|") == false && mail.Contains("[") == false && mail.Contains("]") == false && mail.Contains("{") == false && mail.Contains("}") == false || mail.EndsWith(".ru") || mail.EndsWith(".com")) && (fio.Length >= 10) && (phone.StartsWith("+") && phone.Length < 15))
            {
                listBox.Items.Add($"Фамилия Имя Отчество: {fio}\nПочта: {mail}\nТелефон: {phone}\nНомер СНИЛС: {snils}");
            }
            else
            {
                MessageBox.Show("Документы введены неверно");
            }
            
        }

        

        private void textBox_Copy1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == "+")))
              
            {
                e.Handled = true;
            }
            if (textBox_Copy1.Text.Length > 11)
            {
                e.Handled = true;
            }
        }


        private void textBox_Copy2_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (textBox_Copy2.Text.Length > 10)
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
            char ch = e.Text[0];
            if (ch < 'А' || ch > 'я')
            { 
                e.Handled = true; 
            }
                
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                string str = listBox.SelectedItem.ToString();
                listBox.Items.Remove(str);
            }
            catch 
            {

                MessageBox.Show("Вы не выбрали элемент");
            }
        }

        private void textBox_Copy_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char ch = e.Text[0];
            if (ch < 'A' || ch > 'z')
            {
                e.Handled = true;
            }
        }
    }
}
