using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            char[] letters = { 'a', 'b', 'c', 'd' };
            float[]sides;
            GeometryFigures figure;
            Console.WriteLine("Виберiть тип фiгури: " + '\n' + "1- коло" + '\n' + "2-трикутник" + '\n' + "3-чотирикутник");
            while (true)
            {
                bool res=Int32.TryParse(Console.ReadLine(),out int type);
                if(res)
                {
                    if(type==1)
                    sides = new float[type];
                    else
                    sides = new float[type+1];

                    figure = new GeometryFigures(type);
                      break;
                }
                else
                {
                    Console.WriteLine("Невiрний тип!");
                }
            }
           bool SetSides()
            {
                Console.WriteLine((sides.Length > 1) ? "Введiть сторони" : "Введiть радiус");
                if (sides.Length == 1)
                {
                    while (true)
                    {
                        bool res = float.TryParse(Console.ReadLine(), out float side);
                        if (res)
                        {
                            if (side!=0) {
                                sides[0] = side;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Не може бути нулем!");
                            }
                        }
                        else Console.WriteLine("Невiрний тип!");

                    }
                }
                else
                {
                    int i = 0;
                    while (i < sides.Length)
                    {
                        Console.WriteLine("Сторона " + letters[i]);
                        bool res = float.TryParse(Console.ReadLine(), out float side);
                        if (res)
                        {
                            if (side != 0)
                            {
                                sides[i] = side;
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("Не може бути нулем!");
                            }
                            }
                        else
                        {
                            Console.WriteLine("Невiрний тип!");
                        }

                    }

                }
                return figure.setSides(sides);
            }

            while (!SetSides())
            {
                Console.WriteLine("Фiгура не може iснувати!");
            }
            Console.WriteLine(((sides.Length > 1) ? "Пермитер фiгури- " : "Довжина кола- ") + figure.getPerim());
            Console.WriteLine(((sides.Length > 1) ? "Площа фiгури- " : "Площа круга- ") + figure.getArea());
            Console.ReadKey();
        }
    }
}
