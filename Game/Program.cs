using Game.Open_Closed;
using Game.Single_Responsibility;
using Game.Interface_Segregation;
using System.Collections;
using System.Data;
using Game.Dependency_Inversion;
using Game.Liskov_Substitution;
using Game.virtual_function;

namespace Game
{

    internal class Program 
    {
        static void Main(string[] args) 
        {

            #region 단일 책임 원칙
            // Module , class , function은 하나의 책임만 가져야 합니다.
            // Dog dog = new Dog();
            // 
            // Information info = new Information();    
            // info.Show(dog);
            #endregion

            #region 개방 폐쇄 원칙
            // Module, class, function은 확장에 대해 열려 있어야 하며,
            // 수정에 대해서는 닫혀 있어야 합니다.

            //UnitManager unit = new UnitManager();
            //
            //unit.Create(new Marin());
            //unit.Create(new Firebat());
            //unit.Create(new Ghost());
            //unit.Create(new Medic());

            #endregion

            #region 인터페이스 분리 원칙
            // 클라이언트는 자신이 사용하지 않는 함수에 대해
            // 영향을 받지 않아야 하며, 인터페이스를 구체적이고 작은 단위의 
            // 역할로 인터페이스를 분리시켜 클라이언트가 꼭 필요한 함수만
            // 이용할 수 있도록 해야합니다.

            //Pistol pistol = new Pistol();
            //SniferRifle sniferRifle = new SniferRifle();     
            //Rifle Rifle = new Rifle();
            //
            //pistol.reload();
            //pistol.Shot();
            //Console.WriteLine();
            //
            //sniferRifle.reload();
            //sniferRifle.Shot();
            //sniferRifle.Zoom(50);
            //Console.WriteLine();
            //
            //Rifle.Shot();
            //Rifle.reload();



            #endregion

            #region 의존관계 역전 원칙
            // 의존 관계를 맺을 때 자신보다 변화하기 쉬운 것보다는 
            // 변화하지 않는 것에 의존해야 합니다.

            //ItemManager itemManager = new ItemManager();
            //
            //itemManager.AddItem(new Potion());
            //itemManager.AddItem(new Gem());
            //itemManager.AddItem(new Stone());
            //
            //itemManager.UseAllItem();

            #endregion

            #region 리스코프 치환 원칙
            // 상위 클래스와 하위 클래스가 있을 때 상위 클래스 객체를
            // 호출하는 동작에서 하위클래스 객체가 상위 클래스 객체를
            // 완전하게 대체할 수 있어야 합니다.

            //Rectangle rect = new Rectangle();
            //rect.SetWidth(10);
            //rect.SetHeight(20);
            //Console.WriteLine("직사격형 넓이 : " + rect.GetArea());
            //
            //Square square = new Square();
            //square.SetSide(30);
            //Console.WriteLine("정사격형 넓이 : " + square.GetArea());

            #endregion

            #region 가상 함수
            int num = 5;

            Unit unit;

            ConsoleKeyInfo consoleKey;

            while(num>0)
            {
                consoleKey = Console.ReadKey(true);
            
                switch (consoleKey.Key)
                {
                    case ConsoleKey.D1:
                        unit = new Vulture();
                        unit.Created();
                        num--; break;

                    case ConsoleKey.D2:
                        unit = new SiegeTank();
                        unit.Created();
                        num--; break;

                    case ConsoleKey.D3: 
                        unit = new Goliath();
                        unit.Created();
                        num--; break;
                }
           
            }


            #endregion


        }
    }

}







