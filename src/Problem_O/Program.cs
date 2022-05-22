
using Models.Model_Solid_Principles_1_O;
using Problem_O;

/*
 * PROBLEM
 * 
 * Principio abierto-cerrado
 * Los objetos o entidades deben estar abiertos por extensión, pero cerrados por modificación.
 * 
 * Aplicación
 * Categorización de equipo de trabajo
 * 
 * Primer requerimiento: Todo el personal debe de tener un correo con dominio @company.com
 * 
 * Segundo requerimiento: Identificar el rol de cada persona
 * 
 * Tercer requerimiento: El personal debe de tener un correo con el dominio de acuerdo al departamento, 
 * ejemplo: @desarrollador, @scrum
 */

List<Person> persons = new()
{
    new Person{FirstName = "Paulo", LastName = "Burgos", Role = Role.Ceo },
    new Person{FirstName = "Edwin", LastName = "Bonilla", Role = Role.ProductOwner },
    new Person{FirstName = "Sebastian", LastName = "Veléz", Role = Role.ScrumMaster },
    new Person{FirstName = "Jhonatan", LastName = "Muñoz", Role = Role.Desarrollador },
    new Person{FirstName = "Jorge", LastName = "Martínez", Role = Role.Desarrollador },
    new Person{FirstName = "Deybi", LastName = "Suanca", Role = Role.Desarrollador },
    new Person{FirstName = "Lizeth", LastName = "Romero", Role = Role.QA },
    new Person{FirstName = "Juan", LastName = "Rendon", Role = Role.QA },
};

List<Staff> staffs = new();

persons.ForEach(person => staffs.Add(new AccountService().Create(person)));

staffs.ForEach(stf => Console
    .WriteLine($"Bienvenido {stf.FirstName}, {stf.LastName}, {stf.Email}, Rol = {stf.Role}"));

