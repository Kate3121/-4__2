using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4__2
{
    using System;

    class HardDrive
    {
        // Поля класу
        private string manufacturer;//виробник жорсткого диска
        private string model;//модель жорсткого диска
        private double capacityGB;//обсяг жорсткого диска у гігабайтах.
        private string interfacetype;//тип інтерфейсу
        private int rpm;//кількість обертів за хвилину
        private double price;//ціна
        private bool isSSD;// чи є жорсткий диск SSD
        internal class Program
        {
            static void Main(string[] args)
            {

                /////
                Console.Write("Введiть виробника жорсткого диска: "); string manufacturer = Console.ReadLine();

                Console.Write("Введiть назву моделi: "); string model = Console.ReadLine();

                Console.Write("Введiть обсяг жорсткого диска (у гiгабайтах): "); string capacityGB = Console.ReadLine();

                Console.Write("Введiть тип iнтерфейсу: "); string interfacetype = Console.ReadLine();
                Console.Write("Введiть кiлькiсть обертiв за хвилину: "); string rpm = Console.ReadLine();

                Console.Write("Введiть цiну: "); string price = Console.ReadLine();

                Console.Write("Чи є жорсткий диск SSD? (y-так, n-нi) "); ConsoleKeyInfo isSSD = Console.ReadKey(); Console.WriteLine();

                // Console.Write("Чи? (y-так, n-нi): "); ConsoleKeyInfo keyHasAirport = Console.ReadKey(); Console.WriteLine();

                HardDrive HardDrive_ = new HardDrive();

                HardDrive_.manufacturer = manufacturer; 
                HardDrive_.model = model; 
                HardDrive_.capacityGB = double.Parse(capacityGB);
                HardDrive_.interfacetype = interfacetype;
                HardDrive_.rpm = int.Parse(rpm);
                HardDrive_.price = double.Parse(price);
                HardDrive_.isSSD = isSSD.Key == ConsoleKey.Y ? true : false;
                //OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;

                Console.WriteLine();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Данi про об'єкт: ");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Виробник жорсткого диску: " + HardDrive_.manufacturer);
                Console.WriteLine("Модель: " + HardDrive_.model);
                Console.WriteLine("Обсяг жорсткого диска (у гiгабайтах): " + HardDrive_.capacityGB.ToString());
                Console.WriteLine("Тип iнтерфейсу: " + HardDrive_.interfacetype);
                Console.WriteLine("Кiлькiсть обертiв за хвилину: " + HardDrive_.rpm.ToString());
                Console.WriteLine("Цiна: " + HardDrive_.price.ToString("0.000"));
                Console.WriteLine(HardDrive_.isSSD ? "Має жорсткий диск SSD" : "Немає жорсткого диску SSD");
                Console.ReadKey();
            }
        }
    }
}

