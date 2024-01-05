namespace StaffRegister.BLL
{
    /// <summary>
    /// Represents a staff member with associated competences. 
    /// </summary>
    public class StaffMember
    {
        #region PROPERTIES
        public int Id { get; set; }
        public string Name { get; set; }
        public StaffTitleEnum Title { get; set; }
        public List<Competence> Competences { get; set; }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the StaffMember class.
        /// </summary>
        /// <param name="id">The id of the staff member.</param>
        /// <param name="name">The name of the staff member.</param>
        /// <param name="title">The title of the staff member.</param>
        public StaffMember(int id, string name, StaffTitleEnum title)
        {
            Id = id;
            Name = name;
            Title = title;
            Competences = new List<Competence>();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Returns a string representation of the staff member.
        /// </summary>
        public override string ToString()
        {
            return $"{Id, -10} {Name, -40} {Title, -10}";
        }
        #endregion
    }
}
