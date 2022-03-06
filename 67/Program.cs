//Задача 67: Показать натуральные числа от N до 1, N задано.

int func(int n){
    if (n==1) return n;
    else
    Console.Write($"{n} ");
    return func(n-1);
   
}
Console.WriteLine(func(15));