using Models.Model_Solid_Principles_0_S;
using Problem;

/*
 * PROBLEM
 * 
 * Principio de responsabilidad única
 * Una clase debe tener una y una sola razón para cambiar, lo que significa que una clase debe tener solo un trabajo.
 * 
 * Aplicación
 * Debo de crear un reporte de los curso que se imparten en una universidad y guardar los reportes en local en un txt.
 */

var report = new CourseReport();
report.AddEntry(new CourseReportEntry { Name = "Patrones de diseño", Students = 1000, Rating = 5 });
report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 1900, Rating = 4.5 });

Console.WriteLine(report.ToString());

report.SaveToFile(@"Reports", "WorkReport.txt");