using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kozlova19;

namespace AppKozlova
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("IT Top", " г. Москва, Кутузовский просп., 36, стр. 2");
            team.Players.Add(new Player("Комаров Марк Миронович", ""));
            team.Players.Add(new Player("Кондратьев Лев Глебович", ""));
            team.Players.Add(new Player("Спиридонова Есения Алексеевна", ""));
            team.Players.Add(new Player("Евдокимова Надежда Кирилловна", ""));
            team.ShowAll();
            Console.ReadKey();
        }
    }
}