namespace Soluction_S.Services
{
    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string fileName, CourseReport report)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
