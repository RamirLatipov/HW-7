

namespace тумаков
{
    using System;

    class Building
    {
        // ---------- закрытые поля ----------
        private int id;          // уникальный номер здания
        private double height;      // высота здания, м
        private int floors;      // этажность
        private int apartments;  // количество квартир
        private int entrances;   // количество подъездов

        // статическое поле — последний использованный номер
        private static int lastId = 0;

        // ---------- конструкторы ----------
        public Building()
        {
            id = ++lastId;
        }

        public Building(double height, int floors, int apartments, int entrances)
        {
            id = ++lastId;
            SetAll(height, floors, apartments, entrances);
        }

        // ---------- сеттеры ----------
        public void SetHeight(double h) { height = h; }
        public void SetFloors(int f) { floors = f; }
        public void SetApartments(int a) { apartments = a; }
        public void SetEntrances(int e) { entrances = e; }

        public void SetAll(double h, int f, int a, int e)
        {
            height = h; floors = f; apartments = a; entrances = e;
        }

        // ---------- геттеры ----------
        public int GetId() => id;
        public double GetHeight() => height;
        public int GetFloors() => floors;
        public int GetApartments() => apartments;
        public int GetEntrances() => entrances;

        // ---------- вычисляемые методы ----------
        // высота одного этажа
        public double FloorHeight()
            => floors > 0 ? height / floors : 0.0;

        // квартир в одном подъезде
        public double ApartmentsPerEntrance()
            => entrances > 0 ? (double)apartments / entrances : 0.0;

        // квартир на одном этаже (по всему дому)
        public double ApartmentsPerFloor()
            => floors > 0 ? (double)apartments / floors : 0.0;

        // квартир на этаже в одном подъезде
        public double ApartmentsPerFloorPerEntrance()
            => (floors > 0 && entrances > 0)
               ? (double)apartments / (floors * entrances) : 0.0;

        // ---------- печать ----------
        public void Print()
        {
            Console.WriteLine($"----- Здание #{id} -----");
            Console.WriteLine($"Высота:                    {height} м");
            Console.WriteLine($"Этажей:                    {floors}");
            Console.WriteLine($"Квартир:                   {apartments}");
            Console.WriteLine($"Подъездов:                 {entrances}");
            Console.WriteLine($"Высота этажа:              {FloorHeight():F2} м");
            Console.WriteLine($"Квартир в подъезде:        {ApartmentsPerEntrance():F2}");
            Console.WriteLine($"Квартир на этаже:          {ApartmentsPerFloor():F2}");
            Console.WriteLine($"Квартир на этаже/подъезд:  {ApartmentsPerFloorPerEntrance():F2}");
        }
    }

    // ---------- демонстрация ----------
    class Program
    {
        static void Main()
        {
            Building b1 = new Building();
            b1.SetAll(30.0, 10, 120, 4);        // id = 1
            b1.Print();

            Building b2 = new Building(45.5, 15, 180, 6);   // id = 2
            b2.Print();

            Building b3 = new Building();                   // id = 3
            b3.SetHeight(12.0);
            b3.SetFloors(4);
            b3.SetApartments(32);
            b3.SetEntrances(2);
            b3.Print();
        }
    }












}
