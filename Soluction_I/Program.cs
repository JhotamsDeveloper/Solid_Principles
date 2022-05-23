using Soluction_I.Interfaces;
using Soluction_I.Services;

/*
 * SOLUCTION
 * 
 * Principio de segregación de interfaz
 * Un cliente nunca debe ser forzado a implementar una interfaz que no usan ni los clientes no 
 * deben ser forzados a depender de métodos que no usan.
 * 
 * Aplicación
 * Caracteristicas de un vehículo
 */




IBicycle bicycle = new BicycleServices();
bicycle.NumberOfWheel = 2;

Console.WriteLine($"{bicycle.Move()} {bicycle.GetNumberOfWheel()} ruedas");

ICar car = new CarServices();
car.NumberOfWheel = 4;
Console.WriteLine($"{car.Move()} {car.GetNumberOfWheel()} ruedas, {car.StartEngine()} y {car.StopEngine()}");