using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("99999-8888", "Modelo 1", "77777777", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n-----------------------------------------------\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("66666-5555", "Modelo 2", "44444444", 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("LinkedIn");