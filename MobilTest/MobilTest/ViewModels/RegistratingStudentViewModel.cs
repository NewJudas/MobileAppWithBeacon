using MobilTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilTest.ViewModels
{
    public class RegistratingStudentViewModel
    {
        
        public string Id { get; set; }

        public void AddId()
        {
            RegistrationCode code = new RegistrationCode();

            code.Id = Id;
            RegistrationCode.listan.Add(code);
        }
    }
}
