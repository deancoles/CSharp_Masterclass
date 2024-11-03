// Thread.Sleep freezes the program


for (int counter = 10; counter >= 0; counter--)
{
    Console.WriteLine("Counter is " + counter);
    Thread.Sleep(1000);
}


Console.ReadKey();