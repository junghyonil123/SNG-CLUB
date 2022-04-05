using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXT_RPG
{
    class GAME
    {
       

        static void Main(string[] args)
        {
            Player player = new Player();
            Monster_1 monster = new Monster_1();
            player.information();
            Console.WriteLine();
            monster.information();
            Console.ReadLine();
            player.fight(monster);
            Console.ReadLine();
        }
    }
}
