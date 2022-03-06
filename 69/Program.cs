// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.

Console.WriteLine("write first number");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("write second number");
int num2=int.Parse(Console.ReadLine());
int Summ(int num1,int num2){
    if (num2<num1)return 0;
   return num1+ Summ(num1+1,num2);
   //if (num2==num1)return 0;
}
Console.WriteLine(Summ(num1,num2));