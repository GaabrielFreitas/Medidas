double metros, centimetros, quilometros;

Console.Write("Entre com a medida (em metros): ");

metros = Convert.ToDouble(Console.ReadLine());

centimetros = metros * 100;
quilometros = metros / 1000;

Console.WriteLine("--- Equivalência ---");
Console.WriteLine($"{centimetros} centimetros");
Console.WriteLine($"{metros} metros");
Console.WriteLine($"{quilometros} quilometros");