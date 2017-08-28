using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateData.Windows
{
    public partial class CreateAccountWindow
    {
        #region Data

        string fname;
        string lname;
        DateTime bday;
        string login;
        string mail;
        string pas;
        Tuple<string, string> sq;
        
        #endregion



        private void StoreData()
        {
            fname = fnametxt.Text;
            lname = lnametxt.Text;

            int d;
            int m;
            int y;

            if (int.TryParse(daytxt.Text, out d))
            {
                d = int.Parse(daytxt.Text);
            }
            if (int.TryParse(monthtxt.Text, out m))
            {
                m = int.Parse(monthtxt.Text);
            }
            if (int.TryParse(yeartxt.Text, out y))
            {
                y = int.Parse(yeartxt.Text);
            }
        }
    }
}
