using Newtonsoft.Json;
using StaffRegister.BLL;

namespace StaffRegister.PL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StaffManager staffManager = new StaffManager();
            CompetenceManager competenceManager = new CompetenceManager();

            string solutionDirectory = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\.."));
            string filePath = Path.Combine(solutionDirectory, "Data", "staff_data.json");
            string jsonContent = File.ReadAllText(filePath);

            staffManager.StaffMembers = JsonConvert.DeserializeObject<List<StaffMember>>(jsonContent);
            foreach (var staffMember in staffManager.StaffMembers)
            {
                competenceManager.Competences.AddRange(staffMember.Competences);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(staffManager, competenceManager));
        }
    }
}