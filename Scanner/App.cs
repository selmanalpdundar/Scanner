using System;
using Xamarin.Forms;
namespace Scanner {
    public partial class App : Application {
        public App() {
            var startPage = new PopUpPage();
            MainPage = new NavigationPage(startPage);
        }


    }
}
