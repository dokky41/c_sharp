using System.Data;

namespace Game
{

    public class Cat
    {
        private int age;

        // 프로퍼티 (getter와 setter를 따로 구현하지 않아도 됨)
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value >= 10)
                {
                    age = 10;
                }
                else
                {
                    age = value;
                }
            }
        }

    }

    
    internal class Program 
    {
        static void Main(string[] args) 
        {
            #region 박싱과 언박싱
            // // 박싱 : 값 타입의 객체를 참조 타입으로 변환하는 작업입니다.
            // int data = 100;
            // 
            // // 박싱은 암묵적으로 형 변환이 발생합니다.
            // object obj = data; // 참조 타입에 값 타입을 저장 boxing
            // Console.WriteLine("obj : "+obj);
            // 
            // // 언박싱 : 참조 타입을 값 타입으로 변환하는 작업입니다.
            // // 언박싱은 명시적으로 형 변환이 발생합니다.
            // int x = (int)obj;
            // Console.WriteLine("x : " + x);

            //object[] array = new object[5];
            //
            //array[0] = 10;  //박싱이 일어남
            //array[1] = 6.5f;
            //array[2] = 'A';
            //array[3] = true;
            //array[4] = "kim";
            //
            //foreach (object element in array)
            //{
            //    Console.WriteLine(element);
            //}

            // 모든 자료형들을 저장할 수 있는 동적 배열 (vector 유사)
            // 제네릭을 통해 일반화시켜줌
            // ArrayList

            #endregion

            #region 프로퍼티

            //Cat cat = new Cat();
            //cat.Age = 20;
            //
            //Console.WriteLine("cat의 나이 : " + cat.Age);

            #endregion

            #region 가비지 컬렉터
            // 프로그램이 동적으로 할당했던 메모리 영역 중에서
            // 더 이상 참조되지 않은 메모리를 자동으로 해제하는 기능입니다.

            if (true)
            {
                int[] ints = new int[2];
                
            }
                
                
            #endregion


        }
    }

}

// object는 모든 자료형들의 최상위 자료형 (참조타입)
// 값타입과 참조타입 모두의 최상위

// 박싱과 언박싱
// 값 타입 -> 참조타입
// 참조 타입 -> 값타입






