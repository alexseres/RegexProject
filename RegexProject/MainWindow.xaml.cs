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
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace RegexProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string regexEmail = @"^([\w]+)@([\w]+)\.([\w]+)$";
        public string regexPhoneNumber = "^(0036)(([ ][0-9]{3}){3})$";
        public string regexName = @"^([\w]+)@([\w]+)\.([\w]+)$";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Regexp(regexName, txtName, NameLabel, "Name");
            Regexp(regexPhoneNumber, txtPhone, PhoneLabel, "Phone");
            Regexp(regexEmail, txtEmail, EmailLabel, "Email");
        }

        public void Regexp(string re, TextBox tb, Label lbl, string s)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                lbl.Foreground = Brushes.Green;
                lbl.Content = "Valid";
            }
            else
            {
                lbl.Foreground = Brushes.Red;
                lbl.Content = "Invalid";

            }
        }
    }
}
