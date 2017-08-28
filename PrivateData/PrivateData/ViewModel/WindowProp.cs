using System.Windows;
using System.Windows.Input;

namespace PrivateData
{
    public class WindowProp : BaseViewModel
    {
        #region Constructor

        public WindowProp(Window _wind)
        {
            _Window = _wind;
        }

        #endregion  
        
        #region Public

        /// <summary>
        /// Caption Height
        /// </summary>
        public double WindowChromeCaptionHeight { get; set; } = 20;

        public GridLength vle { get; set; } = new GridLength(20);

        #endregion

        #region Commands

        public ICommand CloseKey = ApplicationCommands.Close;

        #endregion

        #region Private

        Window _Window;

        #endregion
    }
}
