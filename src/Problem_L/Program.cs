using Problem_L.Models;

/*
 * PROBLEM
 * 
 * Principio de sustitución de Liskov
 * Si la clase A es un subtipo de la clase B , deberíamos poder reemplazar B  con  A  sin interrumpir el comportamiento de nuestro programa.
 * 
 * Aplicación
 * Listar un deportista de acuerdo por su equipo y su categoría
 */

Player football = new FootballPlayer();
football.FirstName = "Luis";
football.LastName = "Díaz";
football.AssignTeam(new Team { Name = "Liverpol" });
football.SetCategory(PlayerCategory.professional);

//Player tennis = new TennisPlayer();
//tennis.FirstName = "Santiago";
//tennis.LastName = "Giraldo";
//tennis.AssignTeam(new Team { Name = "Liverpol" });
//tennis.SetCategory(PlayerCategory.professional);

Console.Write($"{football.FirstName} {football.LastName}, esta en el equipo {football.GetTeam()} en la categoria {football.Category}");
//Console.Write($"{tennis.FirstName} {tennis.LastName}, esta en el equipo {tennis.GetTeam()} en la categoria {tennis.Category}");

Console.ReadLine();