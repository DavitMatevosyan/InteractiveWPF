using System.Windows.Media;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System;

namespace PrivateData.Windows
{
    public partial class CreateAccountWindow
    {
        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[Application.Current.Windows.Count - 1].Close();

        }
        // #FFABADB3     border thickness  = 1
        

        /// <summary>
            /// Adds sequrity questions to the combobox
            /// </summary>
        private void AddSQ()
        {
            cbQuestions.Items.Add("What is the last name of the teacher who gave you your first failing grade?");
            cbQuestions.Items.Add("What was the name of your elementary / primary school?");
            cbQuestions.Items.Add("In what city or town does your nearest sibling live?");
            cbQuestions.Items.Add("What time of the day were you born? (hh:mm)");
            cbQuestions.Items.Add("What is your pet’s name?");
            cbQuestions.Items.Add("In what year was your father born?");
        }

        /// <summary>
        /// Checks whether there are any kind of errors if there are: colors them
        /// </summary>
        /// <returns></returns>
        private bool CheckForError()
        {
            string errorbase = string.Empty;

            int count = 0;
            if (fnametxt.Text == string.Empty || fnametxt.Text == "")
            {
                fnametxt.BorderBrush = Brushes.Red;
                fnametxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter Your Name\n";
            }
            if (lnametxt.Text == string.Empty || lnametxt.Text == "")
            {
                lnametxt.BorderBrush = Brushes.Red;
                lnametxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter Your Last Name\n";
            }
            if (daytxt.Text == "")
            {
                daytxt.BorderBrush = Brushes.Red;
                daytxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter The day of your birth\n";
            }
            if (monthtxt.Text == "")
            {
                monthtxt.BorderBrush = Brushes.Red;
                monthtxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter The month of your birth\n";
            }
            if (yeartxt.Text == "")
            {
                yeartxt.BorderBrush = Brushes.Red;
                yeartxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter The year of your birth\n";
            }
            if (logintxt.Text == "")
            {
                logintxt.BorderBrush = Brushes.Red;
                logintxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter your login\n";
            }
            if (emailtxt.Text == "")
            {
                emailtxt.BorderBrush = Brushes.Red;
                emailtxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter your e-mail\n";
            }
            if (sqanstxt.Text == "")
            {
                sqanstxt.BorderBrush = Brushes.Red;
                sqanstxt.BorderThickness = new Thickness(2);
                count++;
                errorbase += "Enter the answer to the security question\n";
            }
            if (count > 0)
            {
                return false;
            }
            MessageBox.Show(errorbase);
            return true;
        }

        /// <summary>
        /// Checks whether the user has fixed the problems
        /// </summary>
        private bool CheckForValids()
        {
            #region basecol and basebt

            var hextobrush = new BrushConverter();
            var basecol = (Brush)hextobrush.ConvertFromString("#FFABADB3");
            var basebt = new Thickness(1);

            #endregion


            int count = 0;
            if (fnametxt.Text != "")
            {
                fnametxt.BorderBrush = basecol;
                fnametxt.BorderThickness = basebt;
                count++;
            }
            if (lnametxt.Text != "")
            {
                lnametxt.BorderBrush = basecol;
                lnametxt.BorderThickness = basebt;
                count++;
            }
            if (daytxt.Text != "")
            {
                daytxt.BorderBrush = basecol;
                daytxt.BorderThickness = basebt;
                count++;
            }
            if (monthtxt.Text != "")
            {
                monthtxt.BorderBrush = basecol;
                monthtxt.BorderThickness = basebt;
                count++;
            }
            if (yeartxt.Text != "")
            {
                yeartxt.BorderBrush = basecol;
                yeartxt.BorderThickness = basebt;
                count++;
            }
            if (logintxt.Text != "")
            {
                logintxt.BorderBrush = basecol;
                logintxt.BorderThickness = basebt;
                count++;
            }
            if (emailtxt.Text != "")
            {
                emailtxt.BorderBrush = basecol;
                emailtxt.BorderThickness = basebt;
                count++;
            }
            if (sqanstxt.Text != "")
            {
                sqanstxt.BorderBrush = basecol;
                sqanstxt.BorderThickness = basebt;
                count++;
            }
            if (count > 0)
            {
                return false;
            }
            return true;
        }



        private void Registerbtn_Click(object sender, RoutedEventArgs e)
        {
            CheckForError();
            CheckForValids();

            if (CheckForValids())
            {
                StoreData();
            }
            

        }
    }
}
