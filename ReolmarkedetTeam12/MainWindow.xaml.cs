using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ReolmarkedetTeam12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string name, email, phone, date, weeks;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = NameTxt.Text;
            email = EmailTxt.Text;
            phone = PhoneTxt.Text;
            date = DateTxt.Text;
            weeks = WeeksTxt.Text;

            Debug.WriteLine(@"{0}, {1}, {2} {3} {4}",name, email, phone, date, weeks); //check if it works.
        }
    }
}
