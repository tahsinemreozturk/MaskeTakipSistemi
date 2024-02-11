using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine( person.Name + "'e maske verilebilir. Sağlıklı günler dileriz. "  );
                Console.ResetColor();
            }

            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(person.Name + "'e maske takibi kontrol edilemedi. Girdiğiniz bilgilerin doğruluğunu kontrol ediniz. ");
                Console.ResetColor();
            }
            
        }

    }
}
