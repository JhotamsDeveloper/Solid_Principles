using Models.Model_Solid_Principles_0_S;

namespace Problem
{
    public class CourseReport //Curso reporte
    {
        private readonly List<CourseReportEntry> _entries;

        public CourseReport()
        {
            _entries = new List<CourseReportEntry>();
        }

        public void AddEntry(CourseReportEntry entry) => _entries.Add(entry);
        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);
        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }

        public override string ToString() =>
         string.Join(Environment.NewLine, _entries.Select(x => $"Curso: {x.Name}, Estudiantes: {x.Students}, Valoración: {x.Rating}"));
    }
}
