// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("write first number");
int m=int.Parse(Console.ReadLine());
Console.WriteLine("write second number");
int n=int.Parse(Console.ReadLine());
int akreman(int m,int n){
     
     if(m==0) return n+1;
    else if(m>0 && n==0){
        return akreman(m-1,1);

    }
    else 
        return akreman(m-1,akreman(m,n-1));
    
    
}

Console.WriteLine(akreman(m,n));