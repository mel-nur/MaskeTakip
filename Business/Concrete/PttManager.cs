using Business.Abstract;
using Emtities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {


        IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            
            if (person == null)
            {
                Console.WriteLine("Personel bilgisi girilmemiştir. İstenilen işlem yapılamamaktadır....");

            }
            else if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "  için maske verildi");
            }
             else
             {
                 Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
             }
            
           
        

    }
    }
}
