using SingeltonHM;


Clock clock1 = Clock.GetInstance();
Clock clock2 = Clock.GetInstance();

if (clock1 == clock2)
{
    Console.WriteLine("Singleton works!");
}
else
{
    Console.WriteLine("Ooops .... try again ...");
}

clock1.GetTime();
clock2.GetTime();
Console.ReadLine();