using HW3Methods;

Console.WriteLine("Первое задание.Пользователь вводит 2 числа (A и B). Возвести число A в степень B.");
Console.WriteLine("Введите число которое хотите возвести в степень");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int B = Convert.ToInt32(Console.ReadLine());
int AC=HomeworkCycles.SquaringNumber(A, B);
Console.WriteLine(AC);



Console.WriteLine("Второе задание.Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.");
Console.WriteLine("Введите число A");
int NumberOneNumber = Convert.ToInt32(Console.ReadLine());
string AT=HomeworkCycles.OutputAllNumbers(NumberOneNumber);
Console.WriteLine(AT);



Console.WriteLine("Третье задание.Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.");
Console.WriteLine("Введите одно число");
int numberA = Convert.ToInt32(Console.ReadLine());
int z = 0;
int AB = HomeworkCycles.FindTheNumberOfPositiveIntegers(numberA);
Console.WriteLine(AB);



Console.WriteLine("Четвертое занятие.Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.");
Console.WriteLine("Введите число");
int numberOne = Convert.ToInt32(Console.ReadLine());
int AZ = HomeworkCycles.OutputTheLargestDivisor(numberOne);
Console.WriteLine(AZ);



Console.WriteLine("Пятое задание.Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).");
Console.WriteLine("Введите первое число");
int numberOneA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberOneB = Convert.ToInt32(Console.ReadLine());
int AS = HomeworkCycles.GetTheSumOfAllNumbersinaGroup(numberOneA, numberOneB);
Console.WriteLine(AS);


Console.WriteLine("Шестое задание.Введите первое число N");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int AK = HomeworkCycles.PrintTheNthNumberOfTheFibonacciSeries(N);
Console.WriteLine(AK);


Console.WriteLine("Седьмое задание.Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида");
Console.WriteLine("Введите первое число ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int Q = Convert.ToInt32(Console.ReadLine());
int AY = HomeworkCycles.FindTheGreatestComminDivisor(M,Q);
Console.WriteLine(AY);


Console.WriteLine("Восьмое задание.Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.");
Console.WriteLine("Введите число N");
int enteredNumber = Convert.ToInt32(Console.ReadLine());
int AЗ = HomeworkCycles.FindaNumberUsingTheHalfDivisionMethod(enteredNumber);
Console.WriteLine(AY);



Console.WriteLine("Девятое задание.Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.");
Console.WriteLine("Введите число");
int NumberEntered = Convert.ToInt32(Console.ReadLine());
int AO = HomeworkCycles.FindNumberOfOddDigits(NumberEntered);
Console.WriteLine(AO);


Console.WriteLine("Десятое задание.Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.");
Console.WriteLine("Введите число");
int NumberEnteredUser = Convert.ToInt32(Console.ReadLine());
int AE = HomeworkCycles.FindaNumberThatIsaMirrorImageOfaSequencefDigitsOfaGivenNumber(NumberEnteredUser);
Console.WriteLine(AE);


Console.WriteLine("Двенадцатое задание.Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.");
Console.WriteLine("Введите первое число");
int NumberEnteredA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int NumberEnteredB = Convert.ToInt32(Console.ReadLine());
HomeworkCycles.TellMeIfThereAreTheSameDigitsInTheSpellingOfTwoNumbers(NumberEnteredA,NumberEnteredB);
Console.WriteLine();