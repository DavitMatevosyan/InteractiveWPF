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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri link;
        string site = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            browser.RenderSize = new Size(500, 500);
        }

        private void btn_backClick_Click(object sender, RoutedEventArgs e)
        {
            browser.GoBack();
        }

        private void btn_rdrClick_Click(object sender, RoutedEventArgs e)
        {
            SearchOnGoogle();
        }

        private void btn_forwardClick_Click(object sender, RoutedEventArgs e)
        {
            browser.GoForward();
        }

        private void btn_fulllinkClick_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Uri link = currentSite.Text.StartsWith("www.") ? link = new Uri("http://" + currentSite.Text) : link = new Uri("http://www." + currentSite.Text); 
                browser.Source = link;
            }
            catch (Exception ex)
            {
                SearchOnGoogle();
                MessageBox.Show("Error Occured, Searching on Google!" , "Couldn't Redirect");
            }
        }

        private void SearchOnGoogle()
        {
            try
            {
                link = new Uri($"http://google.com/search?q={txtLink.Text}");
                browser.Source = link;
                currentSite.Text = link.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
