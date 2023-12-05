using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 13.1 \n Заменить методы в классе на свойства для чтения");
            Console.WriteLine("Упражнение 13.2 \n Добавить в класс индексатор");
            BankAccount account = new BankAccount();
            account.AddTransaction(300);

            BankTransaction transaction1 = account[0];
            Console.WriteLine(transaction1.Money);

            Console.WriteLine("Домашнее задание 13.1 \n Методы заменить на свойства");
            Buildings building = new Buildings(50, 11, 40, 2);

            Console.WriteLine("Высота одного этажа: " + building.CalculateFloorHeight());
            Console.WriteLine("Количество квартир на подъезд: " + building.CalculateApartmentsPerEntrance());
            Console.WriteLine("Количество квартир на этаж: " + building.CalculateApartmentsPerFloor());

            building.PrintBuildingInfo();


            Console.WriteLine("Домашнее задание 13.2 \n Создать класс для нескольких зданий");

            Alotofbuildings alotofbuildings = new Alotofbuildings();
            alotofbuildings[0] = new Buildings1(51, 10, 50, 3);
            alotofbuildings[1] = new Buildings1(78, 5, 40, 2);
            alotofbuildings[2] = new Buildings1(62, 15, 42, 6);
            alotofbuildings[3] = new Buildings1(63, 10, 42, 2);
            alotofbuildings[4] = new Buildings1(55, 12, 45, 3);
            alotofbuildings[5] = new Buildings1(51, 20, 30 , 1);
            alotofbuildings[6] = new Buildings1(70, 20, 60, 5);
            alotofbuildings[7] = new Buildings1(80, 20, 60, 2);
            alotofbuildings[8] = new Buildings1(50, 10, 30, 1);
            alotofbuildings[9] = new Buildings1(62, 15, 40, 2);

            Buildings1 building1 = alotofbuildings[0];
            Buildings1 building2 = alotofbuildings[1];
            Buildings1 building3 = alotofbuildings[2];
            Buildings1 building4 = alotofbuildings[3];
            Buildings1 building5 = alotofbuildings[4];
            Buildings1 building6 = alotofbuildings[5];
            Buildings1 building7 = alotofbuildings[6];
            Buildings1 building8 = alotofbuildings[7];
            Buildings1 building9 = alotofbuildings[8];
            Buildings1 building10 = alotofbuildings[9];

            building1.PrintBuildingInfo();

            building2.PrintBuildingInfo();

            building3.PrintBuildingInfo();

            building4.PrintBuildingInfo();

            building5.PrintBuildingInfo();

            building6.PrintBuildingInfo();

            building7.PrintBuildingInfo();

            building8.PrintBuildingInfo();

            building9.PrintBuildingInfo();

            building10.PrintBuildingInfo();


            Console.ReadKey();
        }
    }
}
