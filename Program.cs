using System.Windows;

Console.Write("please enter a number :");

byte time = byte.Parse(Console.ReadLine());

if (time >= 0 && time <= 6)
    Console.WriteLine("good morning");
if (time >= 7 && time <= 12)
    Console.WriteLine("good morning");
if (time >= 13 && time <= 18)
    Console.WriteLine("good evening");
if (time >= 19 && time <= 24)
    Console.WriteLine("good night");
else
    Console.WriteLine("number must be in 0 and 24");