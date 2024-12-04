using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xama1.ViewModel;
using Xama1.Model;

namespace Xama1.ViewModel
{
    public class VMPage2 : BaseViewModel
    {
        #region VARIABLES
        string _Text;
        public List<MUser> userlist {  get; set; }
        #endregion

        #region BUILDER
        public VMPage2(INavigation navigation)
        {
            Navigation = navigation;
            ShowUsers();
        }
        #endregion

        #region OBJECT
        public string Text
        {
            get { return _Text; }
            set { SetValue(ref _Text, value); }
        }
        #endregion

        #region PROCESS
        public async Task Back()
        {
            await Navigation.PopAsync();
        }
        public void ShowUsers()
        {
            userlist = new List<MUser>
            {
                new MUser
                {
                    Name= "LAFLDSMDFR",
                    Image=""
                },
                new MUser
                {
                    Name= "unlolsitooq",
                    Image= "https://p1.hiclipart.com/preview/2/32/1017/un-show-mas-png-clipart.jpg"
                },
                new MUser
                {
                    Name= "chocoflan",
                    Image= "https://p1.hiclipart.com/preview/2/32/1017/un-show-mas-png-clipart.jpg"
                },
                new MUser
                {
                    Name= "chanchito tiste",
                    Image= "https://p1.hiclipart.com/preview/2/32/1017/un-show-mas-png-clipart.jpg"
                }
            };
           
        }
        public async Task Alert(MUser parameters)
        {
            await DisplayAlert("Tittle", parameters.Name, "OK");
        }
        #endregion


        #region COMMANDS
        public ICommand Backcommand => new Command(async () => await Back());
        public ICommand AlertCommand => new Command<MUser>(async (p) => await Alert(p));
        //public ICommand SimpleProcesscommand => new Command(SimpleProcess);
        #endregion
    }
}
