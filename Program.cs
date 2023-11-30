
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("¡Hola, Mundo!");
Console.WriteLine("Bonjour, le Monde!");
Console.WriteLine("Hallo, Welt!");
Console.WriteLine("Ciao, Mondo!");
Console.WriteLine("Olá, Mundo!");
Console.WriteLine("你好，世界！");
Console.WriteLine("こんにちは、世界！");
Console.WriteLine("Привет, мир!");
Console.WriteLine("مرحبًا، العالم!");
Console.WriteLine("नमस्ते, दुनिया!");
Console.WriteLine("হ্যালো, বিশ্ব!");
Console.WriteLine("Marhaban, Al-Alam!");
Console.WriteLine("안녕하세요, 세계!");
Console.WriteLine("Merhaba, Dünya!");
Console.WriteLine("Hallo, Wereld!");
Console.WriteLine("Hej, Världen!");
Console.WriteLine("Γειά σου, Κόσμε!");
Console.WriteLine("שלום, עולם!");
Console.WriteLine("Witaj, Świecie!");
Console.OutputEncoding = Encoding.UTF8; // Establecer la codificación de salida a UTF-8

Console.OutputEncoding = Encoding.UTF8; // Establecer la codificación de salida a UTF-8

Console.Clear(); // Limpiar la consola al inicio

Random random = new Random();
int iterations = 50; // Reducido a 50 para mostrar resultados más rápidamente

List<string> printedGreetings = new List<string>();

for (int i = 0; i < iterations; i++)
{
    Console.SetCursorPosition(0, 0); // Establecer la posición del cursor para sobreimprimir en la misma línea

    string greeting = PrintRandomGreeting(random);
    printedGreetings.Add(greeting);

    DrawHeart();

    for (int j = printedGreetings.Count - 1; j >= 0; j--)
    {
        Console.WriteLine(printedGreetings[j]);
    }

    Thread.Sleep(4000); // Esperar 4 segundos antes de la próxima iteración
}

static string PrintRandomGreeting(Random random)
{
    string[] greetings = new string[]
    {
          "Afrikáans: Hallo, Wêreld!",
"Albanés: Përshendetje, Bote!",
"Amárico: ሰላም, ልዑል!",
"Armenio: Բարեւ, աշխարհ!",
"Azerí: Salam, Dünya!",
"Bielorruso: Прывітанне, Сусвет!",
"Bosnio: Zdravo, Svijete!",
"Búlgaro: Здравей, Свят!",
"Catalán: Hola, Món!",
"Checo: Ahoj, Světe!",
"Chichewa: Moni, Dziko!",
"Cingalés: හෙලෝ, වේල්වාව!",
"Coreano: 안녕하세요, 세계!",
"Corso: Bonghjornu, Mondu!",
"Croata: Bok, Svijete!",
"Danés: Hej, Verden!",
"Esperanto: Saluton, Mondo!",
"Estonio: Tere, Maailm!",
"Finlandés: Hei, Maailma!",
"Georgiano: გამარჯობა, მსოფლიო!",
"Hawaiano: Aloha, Honua!",
"Hebreo: שלום, עולם!",
"Húngaro: Helló, Világ!",
"Islandés: Halló, Heimur!",
"Javanés: Halo, Jagad!",
"Kazajo: Сәлем, Әлем!",
"Lao: ສະບາຍດີ, ໂລກ!",
"Latín: Salve, Mundus!",
"Letón: Sveiki, Pasaule!",
"Luxemburgués: Moien, Welt!",
"Macedonio: Здраво, Свету!",
"Malayo: Hello, Dunia!",
"Mongol: Сайн байна уу, Дэлхий!",
    };

    int index = random.Next(greetings.Length);
    string greeting = greetings[index] + " :)"; // Añadir un smile al final del saludo
    Console.WriteLine(greeting);
    Console.Clear();
    return greeting;
}

static void DrawHeart()
{
    Console.WriteLine("  ♥   ♥  ");
    Console.WriteLine(" ♥ ♥ ♥ ♥ ");
    Console.WriteLine("  ♥ ♥ ♥  ");
    Console.WriteLine("   ♥ ♥   ");
    Console.WriteLine("    ♥    ");
    Console.WriteLine();
}