using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_13
{
    internal class Buildings
    {
        private static int lastBuildingNumber = 0;

        public int BuildingNumber { get; }
        public double Height { get; }
        public int Floors { get; }
        public int Apartments { get; }
        public int Entrances { get; }

        public Buildings(double height, int floors, int apartments, int entrances)
        {
            BuildingNumber = GenerateBuildingNumber();
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;
        }

        private int GenerateBuildingNumber()
        {
            return ++lastBuildingNumber;
        }

        public double CalculateFloorHeight()
        {
            return Height / Floors;
        }

        public int CalculateApartmentsPerEntrance()
        {
            return Apartments / Entrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            return Apartments / Floors;
        }

        public void PrintBuildingInfo()
        {
            Console.WriteLine("Номер дома: " + BuildingNumber);
            Console.WriteLine("Высота: " + Height + " метров");
            Console.WriteLine("Этажей: " + Floors);
            Console.WriteLine("Квартир: " + Apartments);
            Console.WriteLine("Подъездов: " + Entrances);
        }
    }
}
