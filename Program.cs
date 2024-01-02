using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Criando Nokia");
Smartphone n = new Nokia(numero : "81997453840", modelo : "Nokia 8", imei : "33333333", memoria : 128);
n.Ligar();
n.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Criando Iphone");
Smartphone p = new Iphone(numero : "81996536533", modelo : "Iphone 8 plus", imei : "44444444", memoria : 256);
p.ReceberLigacao();
p.InstalarAplicativo("Kindle");