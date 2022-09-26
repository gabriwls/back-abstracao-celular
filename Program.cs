using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "937459254", modelo: "5.4", imei: "111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "958673492", modelo: "Pro Max 13", imei: "222222222", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");