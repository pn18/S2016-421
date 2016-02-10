using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public object Weapon { get; set; }
        public Armor Armor { get; set; }

        Player()
        {
            Armor = new Pants();
        }
    
    }




}
