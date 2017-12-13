using MobilTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilTest.ViewModels
{
    public class MainPageViewModel
    {

        public ObservableCollection<RegistrationCode> obsLista { get; set; } = new ObservableCollection<RegistrationCode>();
        public string Id { get; set; }
        public MainPageViewModel()
        {
            RegistrationCode code = new RegistrationCode();
            code.Id = "asd";
            obsLista.Add(code);
            

            foreach(var id in RegistrationCode.listan)
            {
                obsLista.Add(id);
            }

        }

    }
}
