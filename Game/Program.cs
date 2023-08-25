using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

namespace Game
{
   
    internal class Program 
    {
        static void Main(string[] args) 
        {

            // □□□□□
            // □□□□□
            // □□□□□

            Inventory inventory = new Inventory(5, 3);

            Cursor cursor = new Cursor();

            inventory.AddItem(new Item(100, "포션"));
            inventory.AddItem(new Item(1000, "투구"));
            inventory.AddItem(new Item(750, "조합석"));

            while (true)
            {
                inventory.Rendere();

                cursor.Input();

                Console.Clear();
            }



        }
    }

}







