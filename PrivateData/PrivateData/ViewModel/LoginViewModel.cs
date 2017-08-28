using System.Windows;
using System.Windows.Input;

namespace PrivateData
{
    class LoginViewModel : BaseViewModel
    {
        #region Constructor

        public LoginViewModel(Window _wind)
        {
            _LoginWindow = _wind;

        }

        #endregion

        #region Public

        #endregion

        #region Private

        Window _LoginWindow;

        #endregion
    }
}