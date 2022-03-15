using HW2Methods;

Console.WriteLine("Первое задание.Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B");
Console.WriteLine("Введите первое число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = HomeworkIfElse.СomparisonNumber(A, B);
Console.WriteLine(C);



Console.WriteLine("Второе задание. Определить какой четверти принадлежит точка с координатами (X, Y)");
Console.WriteLine("Введите число X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
string Z = HomeworkIfElse.BelongsQuarter(X, Y);
Console.WriteLine(Z);


Console.WriteLine("Третье задание. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.");
Console.WriteLine("Введите число A: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int NumberTree = Convert.ToInt32(Console.ReadLine());
int[] IO = HomeworkIfElse.PrintToConsoleInAscendingOrder();
HomeworkIfElse.Write(IO);


Console.WriteLine("Четвертое задание. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.");
Console.WriteLine("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int NumberC = Convert.ToInt32(Console.ReadLine());
string AG = HomeworkIfElse.PrintToTheConsoleTheSolutionOfTheQuadraticEquation(A, B, C);
Console.WriteLine(AG);


Console.WriteLine("Пятое задание. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.");
Console.WriteLine("Введите двузначное число.");
int number = Convert.ToInt32(Console.ReadLine());
string P = HomeworkIfElse.WritingInWords(number);
Console.WriteLine(P);

