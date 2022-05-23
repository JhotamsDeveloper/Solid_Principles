/*
 * SOLUCTION
 * 
 * Principio abierto-cerrado
 * Los objetos o entidades deben estar abiertos por extensión, pero cerrados por modificación.
 * ES DECIR, QUE NO SE PUEDE MODIFICAR EL OBJETO, PERO SE PUEDE EXTENDERLO.
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

using Suluction_O.Interfaces;
using Suluction_O.Models;

List<IApplicant> persons = new()
{
    new Ceo {FirstName = "Paulo", LastName = "Burgos"},
    new ProductOwner {FirstName = "Edwin", LastName = "Bonilla"},
    new ScrumMaster {FirstName = "Sebastian", LastName = "Veléz"},
    new Developer {FirstName = "Jhonatan", LastName = "Muñoz"},
    new Developer {FirstName = "Jorge", LastName = "Martínez"},
    new Developer {FirstName = "Deybi", LastName = "Suanca"},
    new QA {FirstName = "Lizeth", LastName = "Romero"},
    new QA {FirstName = "Juan", LastName = "Rendon"},
    new Candidate {FirstName = "Bill", LastName = "Gate"},
};

List<Staff> staffs = new();

persons.ForEach(person => staffs.Add(person.Processor.Create(person)));

staffs.ForEach(stf => Console
    .WriteLine($"{stf.FirstName}, {stf.LastName}, {stf.Email}"));