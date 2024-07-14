using System;
using System.Drawing;
using System.Numerics;

namespace consoleApp1
{
    class HW
    {
        public class Complex
        {
            double ReZ;
            double ImZ;

            public Complex()
            {
                ReZ = 0;
                ImZ = 0;
            }

            public Complex (double reZ, double imZ)
            {
                ReZ = reZ;
                ImZ = imZ;
            }

            public static Complex operator ++(Complex a)
            {
                a.ReZ++;
                return a;
            }

            public static Complex operator --(Complex a)
            {
                a.ReZ--;
                return a;
            }

            public static Complex operator +(Complex a, Complex b)
            {
                Complex sum = new Complex();
                {
                    sum.ReZ = a.ReZ + b.ReZ;
                    sum.ImZ = a.ImZ + b.ImZ;
                    return sum;
                };
            }

            public static Complex operator -(Complex a, Complex b)
            {
                Complex sub = new Complex();
                {
                    sub.ReZ = a.ReZ - b.ReZ;
                    sub.ImZ = a.ImZ - b.ImZ;
                    return sub;
                };
            }

            public static Complex operator *(Complex a, Complex b)
            {
                Complex mul = new Complex();
                {
                    mul.ReZ = a.ReZ - b.ReZ;
                    mul.ImZ = a.ImZ - b.ImZ;
                    return mul;
                };
            }

            public static bool operator true(Complex a)
            {
                if (a.ImZ != 0)
                {
                    return true; 
                }
                else return false;
            }

            public static bool operator false(Complex a)
            {
                if (a.ImZ == 0)
                {
                    return false;
                }
                else return true;
                
            }

            public static Complex operator |(Complex a, Complex b)
            {
                if ((a.ImZ != 0 || a.ReZ != 0) || (b.ImZ !=
                0 || b.ReZ != 0))
                    return b;
                return new Complex();
            }
     
            public static Complex operator &(Complex a, Complex b)
            {
                if ((a.ImZ != 0 && a.ReZ != 0) && (b.ImZ !=
                0 && b.ReZ != 0))
                    return b;
                return new Complex();
            }
        }

        static void Main()
        {
            Complex number = new Complex(3, 5);
            Complex number2 = new Complex(1, 7);
            Complex multi = number * number2;
            Console.WriteLine("Комплексное число: " + multi);
        }
    }
}