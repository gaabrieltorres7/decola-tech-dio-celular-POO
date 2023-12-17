using AbstracaoCelularPOO.Models;

Console.WriteLine("\niPhone \n");

var iphone = new Iphone("81999999999", "13 Pro Max", "000000-00-000000-0", 256);
iphone.Ligar();
iphone.InstalarAplicativo("ZapZap");
iphone.ReceberLigacao();

Console.WriteLine("\nNokia \n");

var nokia = new Nokia("81999999999", "Nokia Tijolão", "12345678964336", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();