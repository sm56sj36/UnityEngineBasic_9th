﻿namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 14.1f;
            float b = 6.1f;
            float c = 0;

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

            c = 0;
            //전위연산
            Console.WriteLine(++c);
            ++c; //  : c=c+1;
            --c;// : c=c-1

            //후위연산
            c = 0;
            Console.WriteLine(c++);
            c++;
            //PPOP(ref c);
            c--;

        }
    }
}