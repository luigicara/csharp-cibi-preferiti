// See https://aka.ms/new-console-template for more information

//array contente cibi preferiti
string[] cibiPreferiti = { "Spaghetti alle vongole", "Linguine alla bolognese", "Patatine Fritte", "Nigiri di Salmone", "Udon alle verdure", "Orata al forno" };

Console.WriteLine($"Ci sono {cibiPreferiti.Length} cibi nella classifica");

for ( int i = 0; i < cibiPreferiti.Length; i++ )
{
    Console.WriteLine($"{i + 1} - {cibiPreferiti[i]}");
}

Console.WriteLine($"Il mio cibo preferito è \"{cibiPreferiti[0]}\"");

Console.WriteLine($"Il mio cibo \"meno\" preferito è \"{cibiPreferiti[cibiPreferiti.Length - 1]}\"");

var index = cibiPreferiti.Length / 2;

var food = cibiPreferiti[index];

if (cibiPreferiti.Length % 2 == 0)
{
    var food1 = cibiPreferiti[index - 1];

    Console.WriteLine($"I cibi mediani sono \"{food1}\" e \"{food}\"");

} else
    Console.WriteLine($"Il cibo mediano è \"{food}\"");

