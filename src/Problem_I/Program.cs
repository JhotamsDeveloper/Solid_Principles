using Problem_I.Interfaces;
using Problem_I.Services;

/*
 * PROBLEM
 * 
 * Principio de segregación de interfaz
 * Un cliente nunca debe ser forzado a implementar una interfaz que no usan ni los clientes no 
 * deben ser forzados a depender de métodos que no usan.
 * 
 * Aplicación
 * Caracteristicas de un vehículo
 */


IVehicle bicycle = new BicycleServices();
bicycle.NumberOfWheel = 2;

Console.WriteLine($"{ bicycle.Move() } { bicycle.GetNumberOfWheel()   } ruedas; { bicycle.StartEngine() }, { bicycle.StopEngine() }");
