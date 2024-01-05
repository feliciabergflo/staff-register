namespace StaffRegister.BLL
{
    /// <summary>
    /// Manages staff members and their competences. 
    /// </summary>
    public class StaffManager
    {
        #region PROPERTIES
        public List<StaffMember> StaffMembers { get; set; } = new List<StaffMember>();
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the StaffManager class.
        /// </summary>
        public StaffManager()
        { 
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Creates a new staff member.
        /// </summary>
        /// <param name="name">The name of the staff member.</param>
        /// <param name="title">The title of the staff member.</param>
        public void NewMember(string name, StaffTitleEnum title)
        {
            StaffMember newMember = new StaffMember(GenerateUniqueId(), name, title);
            StaffMembers.Add(newMember);
        }

        /// <summary>
        /// Updates the details of a staff member.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <param name="newTitle">The new title.</param>
        /// <param name="memberToUpdate">The staff member to update.</param>
        public void UpdateMember(string newName, StaffTitleEnum newTitle, StaffMember memberToUpdate)
        {
            if (memberToUpdate == null)
            {
                return;
            }

            memberToUpdate.Name = newName;
            memberToUpdate.Title = newTitle;
        }

        /// <summary>
        /// Removes a staff member.
        /// </summary>
        /// <param name="memberId">The index of the staff member to remove.</param>
        public void RemoveMember(int memberId)
        {
            if (memberId == -1)
            {
                return;
            }

            StaffMembers.RemoveAt(memberId);
        }

        /// <summary>
        /// Adds a competence to a staff member.
        /// </summary>
        /// <param name="staffMember">The staff member to add the competence to.</param>
        /// <param name="competence">The competence to add.</param>
        public void AddMemberComp(StaffMember staffMember, Competence competence)
        {
            if (staffMember == null && competence == null)
            {
                return;
            }

            staffMember.Competences.Add(competence);
            foreach (var comp in staffMember.Competences)
            {
                Console.WriteLine(comp);
            }
        }

        /// <summary>
        /// Updates a competence of a staff member.
        /// </summary>
        /// <param name="staffMember">The staff member whose competence is being updated.</param>
        /// <param name="compToUpdate">The competence to update.</param>
        /// <param name="updatedComp">The updated competence.</param>
        public void UpdateMemberComp(StaffMember staffMember, Competence compToUpdate, Competence updatedComp)
        {
            if (staffMember == null || compToUpdate == null || updatedComp == null)
            {
                return;
            }

            int indexToUpdate = staffMember.Competences.FindIndex(comp => comp.Id == compToUpdate.Id);
            if (indexToUpdate != -1)
            {
                staffMember.Competences[indexToUpdate] = updatedComp;
            }
        }

        /// <summary>
        /// Deletes a competence from a staff member.
        /// </summary>
        /// <param name="staffMember">The staff member from whom to delete the competence.</param>
        /// <param name="compToDelete">The competence to delete.</param>
        public void DeleteMemberComp(StaffMember staffMember, Competence compToDelete)
        {
            if (staffMember == null || compToDelete == null)
            {
                return;
            }

            staffMember.Competences.Remove(compToDelete);
        }

        /// <summary>
        /// Gets a staff member by its index.
        /// </summary>
        /// <param name="staffMemberIndex">The index of the staff member.</param>
        /// <returns>The staff member with the specified index.</returns>
        public StaffMember GetById(int staffMemberIndex)
        {
            return StaffMembers[staffMemberIndex];
        }

        /// <summary>
        /// Performs a simple search for staff members based on a search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns>A list of staff members matching the search criteria.</returns>
        public List<StaffMember> SimpleSearch(string searchText)
        {
            var results = StaffMembers
                .Where(member => member.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return results;
        }

        /// <summary>
        /// Performs an advanced search for staff members based on various criteria.
        /// </summary>
        /// <param name="name">The name of the staff member.</param>
        /// <param name="competence">The competence of the staff member.</param>
        /// <param name="title">The title of the staff member.</param>
        /// <param name="level">The competence level of the staff member.</param>
        /// <returns>A list of staff members matching the search criteria.</returns>
        public List<StaffMember> AdvancedSearch(string name, string competence, StaffTitleEnum? title, CompetenceLevelEnum? level)
        {
            var results = StaffMembers
                .Where(member =>
                    (string.IsNullOrEmpty(name) || member.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(competence) || member.Competences.Any(comp => comp.Name.Contains(competence, StringComparison.OrdinalIgnoreCase))) &&
                    (!title.HasValue || member.Title == title) &&
                    (!level.HasValue || member.Competences.Any(comp => comp.Level == level)))
                .ToList();

            return results;
        }

        /// <summary>
        /// Generates a unique ID for a new staff member.
        /// </summary>
        private int GenerateUniqueId()
        {
            // Gets the maximum existing Id or start from 1 if the list is empty
            int maxId = StaffMembers.Any() ? StaffMembers.Max(member => member.Id) : 0;

            // Generates a new Id that is one greater than the maximum existing Id
            int newId = maxId + 1;

            // Ensures the new Id is unique
            while (StaffMembers.Any(member => member.Id == newId))
            {
                newId++;
            }

            return newId;
        }
        #endregion
    }
}
