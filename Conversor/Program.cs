using Conversor.uteis;

try
{
    double milimetros = MetrosMilimetros.Conversor(1.8);
    Console.WriteLine(milimetros);
}
catch(Exception e)
{
    Console.WriteLine("Tente um número correspondente!");
}