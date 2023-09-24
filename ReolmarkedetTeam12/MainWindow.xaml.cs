using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        bool CorrectPhone, CorrectDate, CorrectWeeks;
        string name, email, phone, date, weeks;
        int phoneInt, weeksInt;
        DateTime dateDateTime;


        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Date_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Weeks_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
        public MainWindow()
        {
            InitializeComponent();
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = NameTxt.Text;
            email = EmailTxt.Text;
            phone = PhoneTxt.Text;
            date = DateTxt.Text;
            weeks = WeeksTxt.Text;

            if (Int32.TryParse(phone, out int phoneInt))
            {
                Debug.WriteLine($"Was able to parse '{phone}'");
                CorrectPhone = true;               
            }
            else
            {
                Debug.WriteLine($"Unable to parse '{phone}'");
                //Show dialog
                MessageBox.Show("Ikke korrekt værdi. Prøv igen");
                PhoneTxt.Text = ""; //Clear the error.
            }

            if (Int32.TryParse(weeks, out int weeksInt))
            {
                Debug.WriteLine($"Was able to parse '{weeks}'");
                CorrectWeeks = true;
            }
            else
            {
                Debug.WriteLine($"Unable to parse '{weeks}'");
                //Show dialog
                MessageBox.Show("Ikke korrekt værdi. Prøv igen");
                WeeksTxt.Text = ""; //Clear the error.
            }

            var dateDateTimeVar = DateTime.Parse(date, new CultureInfo("en-US", true)); //'MM/dd/yyyy' forma
            dateDateTime = dateDateTimeVar;

            //if (!DateTime.TryParse(date, out dateDateTime))
            //{
            //    MessageBox.Show("Ikke korrekt værdi. Prøv igen");
            //}


            if (CorrectPhone && CorrectWeeks && name != null && email != null && date != null) //missing proper date check
            {
                CreateNewRenter();
            }

        }
        void CreateNewRenter()
        {            
            Debug.WriteLine(@"{0}, {1}, {2} {3} {4}", name, email, phoneInt, dateDateTime, weeks); //check if it works.
            MessageBox.Show("Din booking er godkendt");
        }
    }
}
