using System.Numerics;

namespace kozlova19
{
    // Козлова К.А. 31ИС
    // класс Team
    public class Team
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Player> Players = new List<Player>();
        public Team(string nm, string ad)
        {
            Name = nm;
            Address = ad;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Команда: Название - {Name}, Адрес - {Address}");
            Console.WriteLine("Состав команды:");
            Players.Sort();
            foreach (Player players in Player)
            {
                players.Show();
            }
        }
    }
}