using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer.ViewModels
{
    public class MainViewModel
    {
        #region Propiedades
        public LoginViewModel Login { get; set; }
        #endregion

        #region Construtores
        public MainViewModel()
        {
            Login = new LoginViewModel();
        }
        #endregion
    }
}
