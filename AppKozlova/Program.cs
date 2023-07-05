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
            Team team = new Team("Звезда", "115280, г. Москва, Автозаводская ул., 23А");
            team.Players.Add(new Player("Комаров Марк Миронович", "Центральный нападающий"));
            team.Players.Add(new Player("Кондратьев Лев Глебович", "Левый защитник"));
            team.Players.Add(new Player("Герасимов Иван Дмитриевич", "Правый защитник"));
            team.Players.Add(new Player("Никитин Арсений Макарович", "Вратарь"));
            team.ShowAll();
            Console.ReadKey();
        }
    }
}