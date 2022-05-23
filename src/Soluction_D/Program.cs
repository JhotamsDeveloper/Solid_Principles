using Soluction_D.Interfaces;
using Soluction_D.Services;

/*
 * SOLUCTION
 * 
 * Principio de inversión de dependencia
 * Las entidades deben depender de abstracciones, no de concreciones. Indica que el módulo de alto nivel no debe depender 
 * del módulo de bajo nivel, sino que deben depender de las abstracciones.
 * 
 * Aplicación
 * Notificaciones a empleador
 */

INotify notifyEmail = new EmailServices("jhotams@developer.com", "Descuentos en cursos de programación",
    "Hola, te informamos que se han aplicado descuentos en los cursos de programación.");

INotify notifySMS = new SMSServices("3105108287", "Hola, te informamos que se han aplicado descuentos en los cursos de programación.");

notifyEmail.Notify();
notifySMS.Notify();