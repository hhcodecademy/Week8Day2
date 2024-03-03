using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApp.Operations
{
    internal class MenuManagement
    {
        public int  SearchOperation()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Bir işçinin məlumatlarının göstərilməsi");
                Console.WriteLine("2. Bir işçinin məlumatlarının göstərilməsi və həmin ay üzrə iş məlumatların göstərilməsi");
                Console.WriteLine("3. Müəyyən bir ünvana görə işçilərin siyahısının görüntülənməsi");
                Console.WriteLine("4. İşə qəbul olunan işçilərin sayının illər üzrə bölgüsünün görüntülənməsi");
                Console.WriteLine("5. İşə gec gələn işçilərin siyahısı");
                Console.WriteLine("6. Müəyyən bir günün əlavə iş qeydlərinin sadalanması");
                Console.WriteLine("7. Esas Menu");
                Console.WriteLine("Zehmet olmasa seciminizi edin: ");
                option = int.Parse(Console.ReadLine());

            } while (option < 0 || option > 7);
            return option;

        }
        public int DoOperation()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Yeni işçinin əlavə edilməsi");
                Console.WriteLine("2. İşçi məlumatlarının yenilənməsi");
                Console.WriteLine("3. Müəyyən bir günün iş qeydlərinin əlavə edilməsi ");
                Console.WriteLine("4. İşçi məlumatlarının dosyalardan silinməsi");
                Console.WriteLine("5. Işçilər faylının ehtiyat nüsxəsinin çıxarılması");
                Console.WriteLine("6. Esas Menu");
                Console.WriteLine("Zehmet olmasa seciminizi edin: ");
                option = int.Parse(Console.ReadLine());

            } while (option < 0 || option > 6);
            return option;
        }

        public void SelectOperation()
        {
            Console.WriteLine("1. Sorgulama Programı");
            Console.WriteLine("2. Yeniləmə Proqramı");
            Console.WriteLine("3. Cixis");
        }
    }
}
