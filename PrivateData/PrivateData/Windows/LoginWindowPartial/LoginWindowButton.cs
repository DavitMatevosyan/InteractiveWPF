using System.Windows;

namespace PrivateData.Windows
{
    public partial class LoginWindow
    {

        /// <summary>
        /// Runs When Close button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CreateAccountbtn(object sender, RoutedEventArgs e)
        {
            // shutdown current app
       //     Application.Current.Shutdown();

            // Show create account window
            CreateAccountWindow CAW = new CreateAccountWindow();
            CAW.Show();
        }
    }
}
