﻿//На вход принимает число А и видает сумму от 1 до А

Console.WriteLine("Enter number");
int num=int.Parse(Console.ReadLine()!);


int GetSumNum(int number)

{
        int sum=0;
        while(number>0)
        {
                Console.WriteLine(number);
                sum=sum+number;
                number--;
                
        }
        return sum;
}

Console.WriteLine($"Sum of numbers: {GetSumNum (num)}");


// var name=Console.ReadLine();

// if(name.ToLower() =="gulnoza")
// {
//         Console.WriteLine("Uraaa Gulnoza welcome!");
// }
// else
// {
//    Console.Write("Oh, no ");
//    Console.Write(name); 
// }