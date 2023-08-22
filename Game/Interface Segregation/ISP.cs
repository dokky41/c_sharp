using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interface_Segregation
{
    public class Pistol : IGun
    {

        public void Shot()
        {
            Console.WriteLine("권총 격발");
        }

        public void reload()
        {
            Console.WriteLine("권총 재장전");
        }

    }

    public class SniferRifle : IGun, IScope
    {
        public void Shot()
        {
            Console.WriteLine("스나이퍼 격발");
        }

        public void reload()
        {
            Console.WriteLine("스나이퍼 재장전");
        }

        public void Zoom(float value)
        {
            Console.WriteLine("현재 확대 값: "+value);
        }

    }


    public class Rifle : IGun
    {
        public void reload()
        {
            Console.WriteLine("소총 재장전");
        }

        public void Shot()
        {
            Console.WriteLine("소총 격발");
        }
    }
}
