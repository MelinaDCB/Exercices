using DistribBoisson;

Distributeur distri1 = new Distributeur(2.00);

Console.WriteLine(distri1.ServirBoisson(3, 5));
Console.WriteLine(distri1.ServirBoisson(1, 12));
Console.WriteLine(distri1.ServirBoisson(2, 7));