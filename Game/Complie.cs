using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Complie
    {
        /*public void Attack()  
    {
        이런식으로 전역으로 선언할 수 없음
    }*/

        public class Monster
        {
            private int attack = 10;

            public void Attack()
            {
                Console.WriteLine("공격 " + attack + " 데미지 추가");
            }
        }


        internal class Program //internal = 접근지정자 (같은 어셈블리내에서 동작하도록)
        {
            static void Information()
            {
                Console.WriteLine("Program 클래스의 정보");
            }

            // static을 사용하는 이유 : 
            // Main 메소드는 프로그램의 진입점(Entry point)이기에
            // 클래스 선언 없이 접근 할수 있어야 한다

            // static함수는 정적 data영역
            static void Main(string[] args)
            {
                // Console.WriteLine : 출력하는 함수입니다.
                Console.Write("Hello, World!");
                Console.WriteLine("Hello, World!");

                Information();

                // Monster monster; 라고 선언하면 자동으로 null이 들어감
                // monster변수에 동적할당 해줌 managed heap이라는 공간에 저장된 
                // Monster의 시작주소가 저장됨

                Monster monster = new Monster();
                monster.Attack();

            }
        }
    }
}
// c#은 값타입, 참조타입으로 나뉨
// 값타입 : byte,bool,char,short,int,long,float,double,decimal ...
// 참조타입 : 클래스,object,delegate,array,string 

// c/c++ 컴파일 과정
// source 코드 작성 (컴파일 ->) .obj (링킹 ->)
// StartUp CODE를 포함시킴 (->) .exe 파일 생성
// 장점 : 직관적   단점 : 운영체제에 제한적이다.

// c# 컴파일 과정 