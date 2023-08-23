using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.virtual_function
{
    
    public class Unit
    {
        protected int hp;
        protected int attack;

        public virtual void Created() { }
    }

    public class Vulture : Unit
    {
        public void SetHp(int hp)
        {
            this.hp = hp;
        }
        public void SetAttack(int attack)
        {
            this.attack = attack;
        }

        public override void Created()
        {
            Console.WriteLine("벌처 생성");
        }
        
    }

    public class SiegeTank : Unit
    {
        public void SetHp(int hp)
        {
            this.hp = hp;
        }
        public void SetAttack(int attack)
        {
            this.attack = attack;
        }

        public override void Created()
        {
            Console.WriteLine("시즈탱크 생성");
        }
    }

    public class Goliath : Unit
    {
        public void SetHp(int hp)
        {
            this.hp = hp;
        }
        public void SetAttack(int attack)
        {
            this.attack = attack;
        }

        public override void Created()
        {
            Console.WriteLine("골리앗 생성");
        }
    }


}
