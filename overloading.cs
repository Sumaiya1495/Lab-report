using System;

public class Number

{

public int A;

public int B;

public Number(int a, int b)

{

A = a;

B = b;

}



public static Number operator +(Number p1, Number p2)

{

return new Number(p1.A + p2.A, p1.B + p2.B);

}

public void Display()

{

Console.WriteLine($"{A},{B}");

}

}

class Program

{

static void Main()

{

Number num1 = new Number(2, 3);

Number num2 = new Number(4, 5);

Number result = num1 +num2; 

num1.Display(); 

num2.Display();

result.Display(); 

}

}
