using MobilTest.Models;
using MobilTest.ViewModels;
using MobilTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilTest
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            InitializeComponent();
 
            BindingContext = vm =new MainPageViewModel();
        }

    }
}
