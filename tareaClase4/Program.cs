// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cuenta cuenta1 = new CuentaCorrientePesos(); 
Cuenta cuenta2 = new CuentaCorrientePesos(2000);

System.Console.WriteLine("la cuenta1 tiene: " + cuenta1.fondos + " fondos");
System.Console.WriteLine("la cuenta2 tiene: " + cuenta2.fondos + " fondos");

cuenta2.extraccion(100,TipoDeExtraccion.CajeroAutomatico);
cuenta1.insercion(400);
System.Console.WriteLine("la cuenta1 tiene: " + cuenta1.fondos + " fondos");