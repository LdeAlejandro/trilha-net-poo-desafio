using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("119567896", "NOKIA 3210", "8032748932", 8);

Console.WriteLine($"Numero do nokia: {n1.Numero}");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Whatsapp");

Console.WriteLine("*********************************************");

Iphone ip1 = new Iphone("1195678555", "Iphone 8", "80327445123932", 8);

Console.WriteLine($"Numero do nokia: {ip1.Numero}");
ip1.Ligar();
ip1.ReceberLigacao();
ip1.InstalarAplicativo("icloud");