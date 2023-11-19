namespace Less_9_itogi_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем массив исключений
            // задание 1.2
            // в массив добавляю исключения на свой вкус + пользовательское исключенние 

            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine();

            Exception[] exceptions = new Exception[5];
            exceptions[0] = new OverflowException("Арифметическое, приведение или операция преобразования приводят к переполнению");     // Арифметическое, приведение или операция преобразования приводят к переполнению.
            exceptions[1] = new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю"); // Знаменатель в операции деления или целого числа Decimal равен нулю.
            exceptions[2] = new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым");     // Непустой аргумент, передаваемый в метод, является недопустимым.
            exceptions[3] = new TimeoutException("Срок действия интервала времени, выделенного для операции, истек");      // Срок действия интервала времени, выделенного для операции, истек.
            exceptions[4] = new PersonException("Фамилия не может быть меньше двух знаков!");       // Пользовательское исключение

            // готовим конструкцию try - catch
            // задание 1.2
            // немного не понял задание
            // я бы сделал через несколько блоков cath
            // но тут стоит слово итерация
            // по этому я буду делать через foreach

            // запускаем цикл
            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType());
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }

                // finally { } - этот блок к данной задаче не подойдет
            }

            Console.WriteLine();
            Console.WriteLine("ЗАДАНИЕ 1 ОКОНЧАНИЕ");
            Console.WriteLine("===========================================================================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine();

            // объявляем кол-во фамилий (сколько эл-ментов в массиве)
            int valSecondName;
            int paramSort;


            Console.WriteLine("Для проверки задания 2 необходимо создать массив!");
            Console.Write("Сколько фамилий Вы хотите ввести для проверки задания 2: ");

            // проверяем прямоту рук пользователя при внесении числа фамилий
            try
            {
                valSecondName = Convert.ToInt32(Console.ReadLine());
                Person person = new Person(valSecondName);

                // вводим параметр сортировки
                Console.WriteLine("Как Вы хотите отсортиртировать массив?");
                Console.Write("Введите - 1 (по возрастанию) / 2 (по убыванию): ");
                try
                {
                    paramSort = Convert.ToInt32(Console.ReadLine());
                    if (paramSort == 1 || paramSort == 2)
                    {
                        
                        person.CreateArray(paramSort);
                    }
                    else
                    {
                        Console.WriteLine("Вы  ввели недопустимое число!");
                    }
                }
                catch
                {
                    Console.WriteLine("Вы ввели текст, который невозможно превратить в число! Программа будет закрыта!");
                }
            }
            catch
            {
                Console.WriteLine("Вы вместо числа ввели бред. Программа будет закрыта!");
            }


        }

        
    }
}