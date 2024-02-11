using Business.Concrete;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;

internal class Program
{
    private static void Main(string[] args)
    {

        Person person = new Person();
        Console.WriteLine("                            ######## MASKE TAKİP SİSTEMİ #######\n");

        Console.WriteLine("Merhaba, maske hakkınızı sorgulamak için sizden istenen bilgileri ekiksiz girmeniz gerekmektedir.");
        
        bool isValid = false;
        while (!isValid) 
        {
           
            try
            {
                Console.Write("Adınızı Giriniz : ");
                person.Name = Console.ReadLine();
                Console.Write("Soyadınızı Giriniz : ");
                person.Surname = Console.ReadLine();
                Console.Write("Doğum Yılınızı Giriniz : ");
                person.DateOfBrithYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tc Kimlik Numaranızı Giriniz : ");
                person.NationalIdentity = Convert.ToInt64(Console.ReadLine());

                PttManager pttManager = new PttManager(new PersonManager());
                pttManager.GiveMask(person);

                isValid = true;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Girilen bilgileriniz doğrulanamadı. Bilgilerinizi doğru girdiğinize emin olarak tekrar deneyiniz.   ");
                Console.ResetColor();
            }
       
        }
    }
    
}