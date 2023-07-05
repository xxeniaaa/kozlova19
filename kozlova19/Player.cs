using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozlova19
{
    public class Player: IComparable<Player>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Player(string nm, string dscp)
        {
            Name = nm;
            Description = dscp;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Название: {Name}, Описание - {Description}");
        }
        public int CompareTo(Player? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
