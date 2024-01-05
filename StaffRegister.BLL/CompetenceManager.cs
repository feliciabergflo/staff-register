namespace StaffRegister.BLL
{
    /// <summary>
    /// Manages competences for staff members.
    /// </summary>
    public class CompetenceManager
    {
        #region FIELD
        private const int CompetenceIdOffset = 100;
        #endregion

        #region PROPERTIES
        public List<Competence> Competences { get; set; } = new List<Competence>();
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the CompetenceManager class.
        /// </summary>
        public CompetenceManager()
        {
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Creates a new competence for a staff member.
        /// </summary>
        /// <param name="staffMemberId">The ID of the staff member.</param>
        /// <param name="name">The name of the competence.</param>
        /// <param name="level">The competence level.</param>
        /// <returns>The newly created competence.</returns>
        public Competence NewCompetence(int staffMemberId, string name, CompetenceLevelEnum level)
        {
            Competence newCompetence = new Competence(GenerateUniqueId(staffMemberId), staffMemberId, name, level);
            Competences.Add(newCompetence);

            return newCompetence;
        }

        /// <summary>
        /// Updates the details of a competence.
        /// </summary>
        /// <param name="newName">The new name of the competence.</param>
        /// <param name="newLevel">The new competence level.</param>
        /// <param name="compToUpdate">The competence to update.</param>
        /// <returns>The updated competence.</returns>
        public Competence UpdateCompetence(string newName, CompetenceLevelEnum newLevel, Competence compToUpdate)
        {
            if (compToUpdate == null)
            {
                return null;
            }

            compToUpdate.Name = newName;
            compToUpdate.Level = newLevel;

            return compToUpdate;
        }

        /// <summary>
        /// Deletes a competence.
        /// </summary>
        /// <param name="compToDelete">The competence to delete.</param>
        public void DeleteCompetence(Competence compToDelete)
        {
            if (compToDelete == null)
            {
                return;
            }

            Competences.Remove(compToDelete);
        }

        /// <summary>
        /// Gets a competence by its ID.
        /// </summary>
        /// <param name="compId">The ID of the competence.</param>
        /// <returns>The competence with the specified ID, or null if not found.</returns>
        public Competence GetById(int compId)
        {
            return Competences?.FirstOrDefault(competence => competence.Id == compId);
        }

        // <summary>
        /// Generates a unique ID for a new competence based on the staff member's ID.
        /// </summary>
        /// <param name="staffMemberId">The ID of the staff member.</param>
        /// <returns>The unique ID for the new competence.</returns>
        public int GenerateUniqueId(int staffMemberId)
        {
            // Get the maximum existing Id or start from 1 if the list is empty
            int maxId = GetMaxCompetenceIdForStaffMember(staffMemberId);

            // Generate a new Id that is one greater than the maximum existing Id
            int newId = (staffMemberId * CompetenceIdOffset) + maxId + 1; 

            // Ensure the new Id is unique
            while (Competences.Any(competence => competence.Id == newId))
            {
                newId++;
            }

            return newId;
        }

        /// <summary>
        /// Gets the maximum competence ID for a staff member.
        /// </summary>
        /// <param name="staffMemberId">The ID of the staff member.</param>
        /// <returns>The maximum competence ID for the staff member.</returns>
        private int GetMaxCompetenceIdForStaffMember(int staffMemberId)
        {
            var staffCompetences = Competences
                .Where(comp => comp.StaffId == staffMemberId)
                .ToList();

            Console.WriteLine($"Competences for Staff Member {staffMemberId}: {string.Join(", ", staffCompetences.Select(c => c.Id))}");

            if (staffCompetences.Any())
            {
                int maxId = staffCompetences.Max(competence => competence.Id % CompetenceIdOffset);
                Console.WriteLine($"Max Competence ID for Staff Member {staffMemberId}: {maxId}");
                return maxId;
            }

            Console.WriteLine($"No competences found for Staff Member {staffMemberId}");
            return 0;
        }
        #endregion
    }
}
