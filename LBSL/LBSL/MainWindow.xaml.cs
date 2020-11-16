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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LBSL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool original = true;
        public string orCode = "";
        public string cppCode = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ModeSwither(object sender, RoutedEventArgs e)
        {
            original = !original;
            switch (original)
            {
                case true:
                    SwithButton.Content = "LBSL";
                    LBSLRed.IsEnabled = true;
                    CppRed.IsEnabled = false;
                    LBSLRed.Visibility = Visibility.Visible;
                    CppRed.Visibility = Visibility.Hidden;
                    break;
                case false:
                    SwithButton.Content = "C++";
                    LBSLRed.IsEnabled = false;
                    CppRed.IsEnabled = true;
                    LBSLRed.Visibility = Visibility.Hidden;
                    CppRed.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void Refresh(object sender, RoutedEventArgs e)
        {
            orCode = LBSLRed.Text();
            cppCode = Compiler(orCode);
            if (!string.IsNullOrEmpty(cppCode))
            {
                CppRed.Text = cppCode;
            }
        }
        private string Compiler (string cd)
        {
            cd = cd.Replace("\n", "");
            cd = cd.Replace("\r","");
            cd = cd.ParseConstFunction("global");
            return cd;
        }
    }
    static class StCl
    {
        public static string Text (this RichTextBox rtb)
        {
            return new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).Text;
        }
        public static void Text(this RichTextBox rtb, string value)
        {
            new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).Text = value;
        }
        public static string ParseConstFunction (this string text, string fName)
        {
            if (text.Contains (fName))
            {
                return text.Replace(fName, "");
            }
            else
            {
                return "";
            }
        }
    }
}
