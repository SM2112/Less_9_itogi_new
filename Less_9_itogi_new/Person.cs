using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_9_itogi_new
{
    
    internal class Person
    {
        // поля класса 
        private int valFam;

        // свойства класса
        public int ValFam
        {
            get
            {
                return valFam;
            }
            set
            {
                valFam = value;
            }
        }

        // конструктор класса
        public Person (int valSecondName)
        {
            ValFam = valSecondName;
        }


        // метод! Создает стринговый массив
        public void CreateArray(int paramSort)
        {
            string[] ArraySecName = new string[valFam];
            Console.WriteLine(ArraySecName.Length);


            try
            {
                for (int i=0; i < valFam; i++)
                {
                    Console.Write("Введите {0}-ую фамилию: ", i+1);
                    ArraySecName[i] = Console.ReadLine();
                    if (ArraySecName[i].Length < 2)
                    {
                        throw new PersonException("Фамилия не может быть меньше двух знаков!");
                    }
                }

                // сортируем массив
                Array.Sort(ArraySecName);

                if (paramSort == 1)
                {
                    foreach (string s in ArraySecName)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    for ( int i = ArraySecName.Length; i > 0; i--)
                    {
                        Console.WriteLine(ArraySecName[i-1]);
                    }
                
                }
             }
            catch (PersonException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine("Программа будет закрыта!");
            }
        }


    }
}
