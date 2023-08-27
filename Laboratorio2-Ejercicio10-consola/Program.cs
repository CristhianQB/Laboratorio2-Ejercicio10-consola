using System;

Console.WriteLine("Cuanto es su consumo");
int consumo = int.Parse(Console.ReadLine());

if (consumo<=100)
{
    double dsct = consumo * 0.10;
    double subtotal = consumo - dsct;
    double impuesto = subtotal * 0.18;
    double total = subtotal+ impuesto;
    Console.WriteLine("El descuento es "+dsct);
    Console.WriteLine("El sub total es "+subtotal);
    Console.WriteLine("El impuesto es "+impuesto);
    Console.WriteLine("El total es "+ total);
}
else
{
    double dsct = consumo * 0.20;
    double subtotal = consumo - dsct;
    double impuesto = subtotal * 0.18;
    double total = subtotal + impuesto;
    Console.WriteLine("El descuento es " + dsct);
    Console.WriteLine("El sub total es " + subtotal);
    Console.WriteLine("El impuesto es " + impuesto);
    Console.WriteLine("El total es " + total);
}