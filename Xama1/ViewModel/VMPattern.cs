using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xama1.ViewModel
{
    public class VMPattern : BaseViewModel
    {
        #region VARIABLES
        string _Text;
        #endregion

        #region BUILDER
        public VMPattern(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJECT
        public string Text
        {
            get { return _Text;  }
            set { SetValue(ref _Text, value); }
        }
        #endregion

        #region PROCESS
        public async Task AsyncProcess()
        {

        }
        public void SimpleProcess()
        {

        }
        #endregion

        #region COMMANDS
        public ICommand AsyncProcesscommand => new Command(async () => await AsyncProcess());
        public ICommand SimpleProcesscommand => new Command(SimpleProcess);
        #endregion
    }
}
