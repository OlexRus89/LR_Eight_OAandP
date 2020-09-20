using System;
using System.Security.Cryptography.X509Certificates;

namespace LR_Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 уровень: КомпТехника, 2 уровень: Сервер, Ноутбук, ПК.
            // Из 2 уровня переходит в 1
            // Вариант 2
            string PC = "PersonalComputer";
            ComputerTechnology[] mas = new ComputerTechnology[10];

            mas[0] = new ComputerTechnology("base-1000", 2000, 20000);
            mas[1] = new Notebook("base-1085", 2017, 49990, Models.HP);
            mas[2] = new Server("RS300-E10-PS4", 2019, 61770, Models.Asus);
            mas[3] = new Server("ProLiant DL380 Gen10", 2020, 273920, Models.HPE);
            mas[4] = new Notebook("Slim 1-11AST-05 Серый", 2015, 19999, Models.Lenovo);
            mas[5] = new PersonalComputer( "нет_данных", 2020, 49500, MotherBroad.Asus, Memory.SSD, VideoGame.NVIDIA, Processor.AMD, RAM.Gigabyte);
            mas[6] = new PersonalComputer("Своя_сборка", 2017, 15490, MotherBroad.Asrock, Memory.HDD, VideoGame.Нет_данных, Processor.AMD, RAM.QUMO);
            mas[7] = new Notebook("G315-5904 Белый", 2018, 101299, Models.Dell);
            mas[8] = new Server("R1208WFTYS", 2016, 111610, Models.Intel);
            mas[9] = new PersonalComputer("Olex", 2020, 200150, MotherBroad.Gigabyte, Memory.SSD, VideoGame.NVIDIA, Processor.Intel, RAM.AMD_Radeon);

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(">>>>>>>>>>      " + mas[i].GetType().Name + " " + mas[i].MPPY);
                Console.WriteLine("Год производства: " + mas[i].Production_Year.ToString());
                Console.WriteLine("Модель: " + mas[i].Model.ToString());
                if (mas[i].GetType().Name == PC)
                {
                    Console.WriteLine("Материнская плата: " + mas[i].Материнская_Плата);
                    Console.WriteLine("Внутренняя память: " + mas[i].Память);
                    Console.WriteLine("Видеокарта: " + mas[i].Видео_Карта);
                    Console.WriteLine("Процессор: " + mas[i].Процессор);
                    Console.WriteLine("Оперативная память: " + mas[i].Оперативная_Память);
                }
                Console.WriteLine("Цена: " + mas[i].Price.ToString());

                Console.WriteLine("\n");
            }

            Console.ReadKey();

        }
    }
}
