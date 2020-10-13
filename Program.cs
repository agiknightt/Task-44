using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_44
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coldier> coldiers = new List<Coldier>();

            AddColdiers(coldiers);

            var fillteredColdiers = from Coldier coldier in coldiers select new
            {
                coldier.Name,
                coldier.Rank
            };
            foreach (var coldier in fillteredColdiers)
            {
                Console.WriteLine($"{coldier.Name} - {coldier.Rank}");                
            }
            Console.ReadKey();
        }

        private static void AddColdiers(List<Coldier> coldiers)
        {
            coldiers.Add(new Coldier("Сергеев Сергей", "Пистолет", "Рядовой", 2));
            coldiers.Add(new Coldier("Антонов Антон", "Автомат", "Сержант", 7));
            coldiers.Add(new Coldier("Васильев Василий", "Винтовка", "Сержант", 3));
            coldiers.Add(new Coldier("Викторов Виктор", "Пистолет", "Полковник", 5));
            coldiers.Add(new Coldier("Генералов Максим", "Ружье", "Лейтенант", 18));
        }
    }
    class Coldier
    {
        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string Rank { get; private set; }
        public int DutyTime { get; private set; }
        public Coldier(string name, string waepon, string rank, int dutyTime)
        {
            Name = name;
            Weapon = Weapon;
            Rank = rank;
            DutyTime = dutyTime;
        }
        
    }
}
