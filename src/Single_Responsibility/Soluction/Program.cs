

/*
 * SOLUCTION
 * 
 * Principio de responsabilidad única
 * Una clase debe tener una y una sola razón para cambiar, lo que significa que una clase debe tener solo un trabajo.
 * 
 * Aplicación:
 * Debo de crear un reporte de los curso que se imparten en una universidad y que estos reportes se puedan
 * guardar tanto en local y en un servicio en la nube.
 * 
 * RECOMENDACIONES
 * Trabajar con pruebas unitarias TDD
 * Desarrolladr de la manera que mejor se sienta y por último factorizar
 */


using Soluction_S.Model;
using Soluction_S.Services;

var report = new CourseReport();
report.AddEntry(new CourseReportEntry { Name = "Patrones de diseño", Students = 1000, Rating = 5 });
report.AddEntry(new CourseReportEntry { Name = ".Net", Students = 5200, Rating = 5 });
report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 1900, Rating = 4.5 });

Console.WriteLine(report.ToString());

FileSaver fileSaver = new FileSaver();
fileSaver.SaveToFile(@"Reports", "WorkReport.txt", report);