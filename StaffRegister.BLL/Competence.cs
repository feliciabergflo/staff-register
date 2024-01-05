namespace StaffRegister.BLL
{
    /// <summary>
    /// Represents a competence associated with a staff member.
    /// </summary>
    public class Competence
    {
        #region FIELDS
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string Name { get; set; }
        public CompetenceLevelEnum Level { get; set; }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of a competence with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier of the competence.</param>
        /// <param name="staffId">The staff member's identifier.</param>
        /// <param name="name">The name of the competence.</param>
        /// <param name="level">The competence level.</param>
        public Competence(int id, int staffId, string name, CompetenceLevelEnum level) {
            Id = id;
            StaffId = staffId;
            Name = name;
            Level = level;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Returns a string representation of the competence.
        /// </summary>
        public override string ToString()
        {
            return $"{Id, -10} {Name, -40} {Level, -10}";
        }
        #endregion
    }
}
