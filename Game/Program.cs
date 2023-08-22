﻿using Game.Open_Closed;
using Game.Single_Responsibility;
using Game.Interface_Segregation;
using System.Collections;
using System.Data;
using Game.Dependency_Inversion;

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


        }
    }

}







