/** Creational -> Singleton **/
// Thread unSafety (Single thread)
using DesignPatterns.Creational.Singleton;

Counter counter1 = Counter.GetInstance();
counter1.AddOne();
counter1.AddOne();

Counter counter2 = Counter.GetInstance();
counter2.AddOne();
counter2.AddOne();


Console.WriteLine(counter1.count.ToString());
