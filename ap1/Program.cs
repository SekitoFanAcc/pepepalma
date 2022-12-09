System.Console.WriteLine("Introduce una palabra");

string entrada = Console.ReadLine();

char[] palabra = entrada.ToCharArray();

for (int i = 0; i < palabra.Length; i++)
{

    System.Console.WriteLine(palabra[i]);
}