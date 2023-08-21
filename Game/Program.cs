﻿using System.Collections;
using System.Data;

namespace Game
{
    public class Dog
    {
        private string name;
        private int age;

        public Dog()
        {
            age = 1;
            name = "Alistar";
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Walk()
        {
            Console.WriteLine("Walk");
        }

        public string Representation()
        {
            return $"Name : {name}, Age : {age}";
        }
    }

    class Information
    {
        public void Show(Dog dog)
        {
            Console.WriteLine(dog.Representation());
        }

    }

    public abstract class TerranUnit
    {
        public abstract void Speak();
    }

    public class Marin : TerranUnit
    {
        public override void Speak()
        {
            Console.WriteLine("마린 생성");
        }
    }

    public class Medic : TerranUnit
    {
        public override void Speak()
        {
            Console.WriteLine("메딕 생성");
        }
    }

    public class Firebat : TerranUnit
    {
        public override void Speak()
        {
            Console.WriteLine("파이어벳 생성");
        }
    }

    public class Ghost : TerranUnit
    {
        public override void Speak()
        {
            Console.WriteLine("고스트 생성");
        }
    }

    class UnitManager
    {
        public void Create(TerranUnit Unit)
        {
            Unit.Speak();
        }
    }

    public interface IGun
    {
        // 발사
       

        // 장전
    }
    public interface IScope
    {
        // 줌

    }

    public class Pistol : IGun
    {

    }

    public class SniferRifle : IGun,IScope
    {

    }

    public class Rifle : IGun
    {

    }

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


            #endregion


        }
    }

}







