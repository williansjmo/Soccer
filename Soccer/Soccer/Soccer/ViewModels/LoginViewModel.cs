using Soccer.Classes;
using Soccer.Services;
using System.ComponentModel;
using System.Windows.Input;
//using GalaSoft.MvvmLight.Command;

namespace Soccer.ViewModels
{
    public class LoginViewModel: INotifyPropertyChanged
    {

        #region Constructor
        public LoginViewModel()
        {
            apiService = new ApiService();
            dialogService = new DialogService();
            IsEnable = true;
            IsRemember = true;

        }
        #endregion

        #region Comandos
        //public ICommand LoginCommand
        //{
        //    get
        //    {
        //        return new RelayCommand()
        //    }
        //}
        #endregion

        #region Eventos
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Atributos
        private ApiService apiService;
        private DialogService dialogService;
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnable;
        private bool isRemember;
        #endregion

        #region Propiedades
        public string Email
        {
            get { return email; }
            set
            {
                if(email !=value)
                {
                    email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
                }
            }
        }
        public string Password
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }
        public bool IsRunning
        {
            get { return isRunning; }
            set
            {
                if (isRunning != value)
                {
                    isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
                }
            }
        }
        public bool IsEnable
        {
            get { return isEnable; }
            set
            {
                if (isEnable != value)
                {
                    isEnable = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsEnable"));
                }
            }
        }
        public bool IsRemember
        {
            get { return isRemember; }
            set
            {
                if (isRemember != value)
                {
                    isRemember = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRemember"));
                }
            }
        }
        #endregion
    }
}
