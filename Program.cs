using DesafioPOO.Models;

Nokia nokia = new Nokia("123435", "tijolão", "435", 8);
nokia.Ligar();
nokia.Dados();
nokia.InstalarAplicativo("ZipZap");

Console.WriteLine("\n");

Iphone iphone = new Iphone("43567", "17 pro max", "756", 16);
iphone.Ligar();
iphone.Dados();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tigrinho");
