using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

namespace Game
{
    #region 봉인 클래스
    // 클래스가 다른 클래스에 상속되는 것을 원하지 않을 때
    // 해당 클래스를 봉인하는 것입니다.
        public class Complete
        {
            public virtual void Skill()
            {
                 Console.WriteLine("완전체 스킬");
            }

        }

        public class Maturity : Complete
        {
            public sealed override void Skill()
            {
            Console.WriteLine("성숙기 스킬");
            }


        }

        public class Babyhood : Maturity
        {
        // 상위 클래스에서 봉인 함수로 선언된 함수는
        // 하위 클래스에서 더 이상 재정의 할 수 없습니다.
        //public sealed override void Skill() { } //(에러)
        


        }

    #endregion

    #region 인덱서
    // 인덱스를 이용해서 객체 내부에 존재하는 데이터에 접근할 수 있도록
    // 해주는 기능이며, 
    public class Player
    {
       
    }
    public class Bullet
    {
        public int[] index = new int[5];


        private int x;
        private int y;
        private string shape;

        public int this[int index]
        {
            get
            {
                if (index >= this.index.Length)
                {
                    Console.WriteLine("범위를 초과하였습니다.");
                    return 0;
                }
                else
                {
                    return this.index[index];
                }
            }

            set
            {
                if (index > this.index.Length)
                {
                    Console.WriteLine("범위를 초과하였습니다.");
                    
                }
                else
                {
                    this.index[index] = value;
                }
            }
        }

        public int X // 프로퍼티 getter,setter
        {
            set { x = value; }
        }

        public int Y // 프로퍼티 getter,setter
        {
            set { y = value; }
        }

        public string Shape
        {
            get { return shape; }
        }

    }


    


    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 봉인 클래스
            //Complete complete = new Complete();
            //complete.Skill();
            //
            //Maturity maturity = new Maturity();
            //maturity.Skill();
            //
            //Babyhood babyhood = new Babyhood();
            //babyhood.Skill();
            #endregion

            Player player = new Player();
            Bullet bullet = new Bullet();

            bullet[2] = 10;
            bullet[3] = 20;

            //Console.WriteLine("bullet[2]의 값 : " + bullet[2]);
            //Console.WriteLine("bullet[3]의 값 : " + bullet[3]);

        }
    }

}






