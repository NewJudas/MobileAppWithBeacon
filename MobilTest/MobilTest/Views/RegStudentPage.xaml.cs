using MobilTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegStudentPage : ContentPage
    {
        RegistratingStudentViewModel vm;

        public RegStudentPage()
        {
            InitializeComponent();
            vm = new RegistratingStudentViewModel();
            BindingContext = vm;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            vm.AddId();
            Navigation.PushAsync(new MainPage());

        }
    }
}