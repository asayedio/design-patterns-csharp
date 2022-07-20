/** Creational -> Singleton **/
using DesignPatterns.Creational.Singleton;

// Thread unSafety (Single thread)
/*Counter counter1 = Counter.GetInstance();
counter1.AddOne();
counter1.AddOne();

Counter counter2 = Counter.GetInstance();
counter2.AddOne();
counter2.AddOne();

Console.WriteLine(counter1.count.ToString());*/

// Thread Safety (Multi thread)
Task task1 = Task.Factory.StartNew(() =>
{
    Counter counter1 = Counter.GetInstance();
    counter1.AddOne();
    Console.WriteLine($"counter1: {counter1.count.ToString()}");
});

Task task2 = Task.Factory.StartNew(() =>
{
    Counter counter2 = Counter.GetInstance();
    counter2.AddOne();
    Console.WriteLine($"counter2: {counter2.count.ToString()}");
    Console.WriteLine();
});
