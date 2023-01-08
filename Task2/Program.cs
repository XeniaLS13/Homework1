int numberA = 22;
int numberB = 3;
int numberC = 9;

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max =");
Console.WriteLine(max);
