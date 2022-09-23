using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, a1, b1, c1, d, Q, R, S, F, x1=0, x2=0, x3=0;
            Console.WriteLine("Введите а");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите с");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите d");
            d = Convert.ToDouble(Console.ReadLine());
            a = b1 / a1;
            b= c1 / a1;
            c= d / a1;
                // 1 Находим:
                Q = (Math.Pow(a, 2) - 3 * b) / 9;
                R=(2*Math.Pow(a, 3) - 9 * a*b+27*c) / 54;
                //2. Подставляем полученные значения и находим:
                S = Math.Pow(Q, 3)-Math.Pow(R,2);
            //3.Далее выбираем вариант решения в зависимости от S:
            //a) Когда S > 0, то применяем нижеследующие формулы:
                if (S>0)
                {
                    F = (Math.Pow(Math.Cos(R / Math.Pow(Q, 3 / 2)),-1) / 3);
                    //У уравнения будет 3 корня (вещественных):
                    x1=-2*Math.Pow(Q,1/2)*Math.Cos(F)-(a/3);
                    x2=-1*Math.Pow(Q,1/2)* Math.Cos(F+2*Math.PI/3)-(a/3);
                    x3 = -1 * Math.Pow(Q, 1 / 2) * Math.Cos(F - 2 * Math.PI / 3) - (a / 3);
                }

                //б) Когда S< 0, то заменяем тригонометрические функции гиперболическими.
                //Находим:
                if (S < 0)
                {
                    F = Math.Log10((Math.Abs(R) / Math.Pow(Math.Abs(Q), 3 / 2))+Math.Sqrt(Math.Pow((Math.Abs(R) / Math.Pow(Math.Abs(Q), 3 / 2)),2)-1))/3;
                    //В результате получаем один единственный корень(вещественный):
                    x1 = -2 * Math.Sign(R) * Math.Pow(Math.Abs(Q), 1 / 2) * ((Math.Pow(Math.E, F)+ Math.Pow(Math.E, -F))/2)-a/3;
                    //Мнимые корни:
                    x2 = Math.Sign(R) * Math.Pow(Math.Abs(Q), 1 / 2) * ((Math.Pow(Math.E, F) + Math.Pow(Math.E, -F)) / 2) - a / 3 + Math.Pow(3 * Math.Abs(Q), 1 / 2)*((Math.Pow(Math.E, F) - Math.Pow(Math.E, -F)) / 2);
                    x3 = Math.Sign(R) * Math.Pow(Math.Abs(Q), 1 / 2) * ((Math.Pow(Math.E, F) + Math.Pow(Math.E, -F)) / 2) - a / 3 - Math.Pow(3 * Math.Abs(Q), 1 / 2) * ((Math.Pow(Math.E, F) - Math.Pow(Math.E, -F)) / 2);
                }
                //в) Когда S = 0, то уравнение имеет меньше трех различных решений:
                //Находим:
                if (S==0)
                {
                    x1 = -2 * Math.Pow(R, 1 / 3) - (a / 3);
                    x2 = Math.Pow(R, 1 / 3) - (a / 3);
                    x3 = x2;
                }
            Console.WriteLine($"x1 = {x1}\n x2 = {x2}\n x3 = {x3}");
            Console.ReadKey();
            }
        }
    }

