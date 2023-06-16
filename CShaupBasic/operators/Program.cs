﻿namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 6;
            int c = 0;

            //  산술 연산자
            //=======================

            //더하기
            c = a + b;
            Console.WriteLine(c);

            //빼기
            c = a - b;
            Console.WriteLine(c);

            //곱하기
            c = a * b;
            Console.WriteLine(c);

            //나누기
            //정수 나눗셈을 했을때는 몫만 반환
            c = a / b;
            Console.WriteLine(c);

            //나머지
            c = a % b;
            Console.WriteLine(c);

            //복합 대입 연산자
            //=========================

            //더해서 대입
            c += a; //   : c= c+a;
            c -= a; //   : c= c-a;
            c *= a; //   : c= c*a;
            c  /= a; //   : c= c/a;
            c%= a; //   : c= c%a;

            //증감 연산자
            //=========================

            //전위연산
            c = 0;
            Console.WriteLine(++c);
            ++c; //  : c=c+1;
            --c;// : c=c-1

            //후위연산
            c = 0;
            Console.WriteLine(c++);
            Console.WriteLine(c);
            c++;
            //PPOP(ref c);
            c--;

            //관계 연산
            //같음, 다름, 크기비교 연산을 수행하며
            //연산 내용이 참일 경우 true, 거짓일 경우 flase 반환
            //===========================

            bool result = false;
            //같음
            result = a == b;
            //다름
            result = a != b;
            //큼
            result = a > b;
            //크거나 같음
            result = a >= b;
            //작음
            result = a < b;
            //작거나 같음
            result = a <= b;

            //논리 연산자
            //논리형 (bool)의 피연산자들로 연산을 수행
            //=====================================

            bool A = true;
            bool B = false;

            //  or
            //  A와 B 둘중 하나라도 true 면 true 면 true 반환 나머지 false 반환
            result = A | B;

            //and
            //A와 B 둘 다 true 면 true 반환 나머지 true 반환
            result = A & B;

            //xor
            //A와 B 둘 중 하나만 true 면 true 반환, 나머지 false 반환
            result = A ^ B;

            //not
            //피연산자가 true 면 false, false 면 true 반환
            result = !A;

            //조건부 논리 연산자
            //Conditional or, Conditional and
            //==================================

            //Condition or
            //왼쪽 피연산자가 true면 오른쪽 피연산자에 대한 연산은 수행하지 않고 true 반환
            result = A || B;

            //Condition and
            //왼쪽 피연산자가 false면 오른쪽 피연산자에 대한 연산은 수행하지 않고 false 반환
            result = A && B;

            //비트 연산자
            //정수형에 대해서만 연산을 수행함
            //===================================

            //or
            Console.WriteLine(a | b);
            //a == 14 == 2^3+ 2^2+ 2^1==...00001110
            //b == 6 ==            2^2+ 2^1==...00000110
            //----------------------------------------------------------------

            //and
            Console.WriteLine(a = b);
            //a == 14 == 2^3+ 2^2+ 2^1==...00001110
            //b == 6 ==            2^2+ 2^1==...00000110
            //----------------------------------------------------------------
            //and                                    ==...00000110 == 6

            //xor
            Console.WriteLine(a ^ b);
            //a == 14 == 2^3+ 2^2+ 2^1==...00001110
            //b == 6 ==            2^2+ 2^1==...00000110
            //----------------------------------------------------------------
            //xor                                    ==...00001000 == 8

            //not
            Console.WriteLine(~a);
            //a == 14 == 2^3+ 2^2+ 2^1==...00001110
            //----------------------------------------------------------------
            //not                                     ==...1111111 11111111 1111111
            //-a==~a+1

            //shift-left
            Console.WriteLine(a<<2);
            //a == 14 == 2^3+ 2^2+ 2^1==...00001110
            //----------------------------------------------------------------
            // << 2                                 ==...001110000

            //shift-right
            Console.WriteLine(a << 2);
            //a == 14 == 2^3+ 2^2+ 2^1==...00001110
            //----------------------------------------------------------------
            // >> 2                                 ==...001110000

            //ex. Layer
            //Default : 0 << 0 == 0
            //Player : 1 << 0 == 1
            //Enemy : 1 << 1 ==2
            //Ground : 1 << 2 ==4

            Collider player = new Collider();
            player.layer = 0;
            player.colliderMask = 1 << 1 | 1 << 2; // ... 00000110

            Collider enemy = new Collider();
            enemy.layer = 1;
            enemy.colliderMask = 1 << 0 | 1 << 2; //.. 00000101

            Console.WriteLine(player.TryCollide(enemy));
        }

        public class Collider
        {
            public int layer;
            public int colliderMask;

            public bool TryCollide(Collider other)
            {
                return ((1 << other.layer)&this.colliderMask) > 0;
            }
        }

        //private static int Sum(int a, int b)
        //{
        //    return a + b;
        //}


    }
}