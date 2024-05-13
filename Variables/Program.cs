// See https://aka.ms/new-console-template for more information
int year = 10;
int year2 = Convert.ToInt16("23");
//Float 32 bit
float flotante = 8.9F;
//64 bit
double doble = 3.27;
string nombre = "Fernando";

//Clase String
String nombres = "Allie Rashell";
//cantidad exacta y abarca mas espacio de almacenamiento 128 bit
decimal decimals = 2.07M;

//imprimir en consola
Console.WriteLine(nombres+ " {0} | {1} | {2} | {3} | {4}" , year, doble, nombre, decimals, flotante);
Console.WriteLine("Hello, World! "+ year);
Console.WriteLine("Hola esta es una Prueba de conversion " + year2);

bool valor = false;
char letra = 'A';
//Clase decimal
Decimal de = 34.45M;
Double dobles = 23.43;
Boolean valor2 = false;

Console.WriteLine("{0} | {1} | {2} | {3} | {4}", valor, letra, de, dobles, valor2);


Console.ReadLine();