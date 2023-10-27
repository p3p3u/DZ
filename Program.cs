// Задайте значение N. Напишите программу, которая выведет все натуральные числа
//в промежутке от N до 1. Выполнить с помощью рекурсии.

void printNtoOne(int N){
  Console.Write(N + " ");
  if (N > 1)
  {
    printNtoOne(N-1);
  }
}

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//в промежутке от M до N.

int sum(int M, int N){
  int res = 0;
  if (M > N)
  {
    int temp = M;
    M = N;
    N = temp;
  }
  for (int i = M+1; i < N; i++) //по условию "промежуток", поняла как числа МЕЖДУ М и N
  {
    res += i;
  }
  return res;
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

int akk(int m, int n){
  if (n == 0)
  {
    return m + 1;
  }
  else
  {
    if ((n != 0) && (m == 0))
    {
      return akk(n - 1, 1);
    }
    else
    {
      return akk(n - 1, akk(n, m - 1));
    }
  }
}

printNtoOne(5);
Console.WriteLine();
Console.WriteLine(sum(10,5));
Console.WriteLine(akk(0, 0));