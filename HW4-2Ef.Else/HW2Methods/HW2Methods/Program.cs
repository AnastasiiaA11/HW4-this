using HW2Methods;

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

int C = HomeworkIfElse.СomparisonNumber(A, B);
Console.WriteLine(C);

//

Console.WriteLine("Определить какой четверти принадлежит точка с координатами (X, Y)");

Console.WriteLine("Введите число X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

string Z = HomeworkIfElseSecond.BelongsQuarter(X, Y);
Console.WriteLine(Z);

//
Console.WriteLine("Введите двузначное число.");
int number = Convert.ToInt32(Console.ReadLine());


string P = HomeworkIfElseFive.WritingInWords(number);
Console.WriteLine(P);
