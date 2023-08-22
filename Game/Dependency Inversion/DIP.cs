using Game.Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Dependency_Inversion
{
    public abstract class Item
    {
        public abstract void Use();     

    }

    public class ItemManager
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void UseAllItem()
        {
            foreach (var i in items)
            {
                i.Use();
            }
        }
    }

    public class Potion : Item
    {
        public override void Use()
        {
            Console.WriteLine("포션 사용");
        }
    }

    public class Gem : Item
    {
        public override void Use()
        {
            Console.WriteLine("젬 사용");
        }
    }
    public class Stone : Item
    {
        public override void Use()
        {
            Console.WriteLine("돌 사용");
        }
    }
}
