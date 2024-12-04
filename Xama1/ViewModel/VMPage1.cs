using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xama1.View;
using Xamarin.Forms;


namespace Xama1.ViewModel
{
    public class VMPage1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _UserType;
        DateTime _Date;
        string _ResultDate;

        #endregion

        #region BUILDER
        public VMPage1(INavigation navigation)
        {
            Navigation = navigation;
            Date = DateTime.Now;
        }
        #endregion

        #region OBJECT
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        public string UserType
        {
            get { return _UserType; }
            set { SetValue(ref _UserType, value); }
        }
        public string SelectUserType
        {
            get { return _UserType; }
            set { SetProperty(ref _UserType, value); 
                UserType = _UserType; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { SetValue(ref _Date, value);
                ResultDate = _Date.ToString("dd/MM/yyyy");
            }
            
        }
        public string ResultDate
        {
            get { return _ResultDate; }
            set { SetValue(ref _ResultDate, value); }
        }
        #endregion

        #region PROCESS
        public async Task Back()
        {
            await Navigation.PopAsync();
        }
        public async Task NavPag2()
        {
            await Navigation.PushAsync(new Page2());
        }
        public void Sum()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = n1 + n2;
            R = r.ToString();
        }
        #endregion

        #region COMMANDS
        public ICommand NavPag2command => new Command(async () => await NavPag2());
        public ICommand Sumcommand => new Command(Sum);
        public ICommand Backcommand => new Command(async () => await Back());
        #endregion
    }
}
