using Problem_D;

/*
 * PROBLEM
 * 
 * Principio de inversión de dependencia
 * Las entidades deben depender de abstracciones, no de concreciones. Indica que el módulo de alto nivel no debe depender 
 * del módulo de bajo nivel, sino que deben depender de las abstracciones.
 * 
 * Aplicación
 * Notificaciones a empleador
 */


NotifyEmployee notifyEmployee = new NotifyEmployee("jhotams@developer.com", "Descuentos en cursos de programación", 
    "Hola, te informamos que se han aplicado descuentos en los cursos de programación.", "3105108287");

notifyEmployee.Notify();