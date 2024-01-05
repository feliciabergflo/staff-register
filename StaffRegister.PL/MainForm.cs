using StaffRegister.BLL;

namespace StaffRegister.PL
{
    /// <summary>
    /// Represents the main form of the Staff Register application. 
    /// </summary>
    public partial class MainForm : Form
    {
        #region FIELDS
        private StaffManager staffManager;
        private CompetenceManager competenceManager;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        /// <param name="staffManager">The StaffManager instance.</param>
        /// <param name="competenceManager">The CompetenceManager instance.</param>
        public MainForm(StaffManager staffManager, CompetenceManager competenceManager)
        {
            InitializeComponent();

            this.competenceManager = competenceManager;
            this.staffManager = staffManager;

            InitializeGUI();
        }
        #endregion

        #region METHODS
        #region GUI Methods
        /// <summary>
        /// Initializes the graphical user interface.
        /// </summary>
        private void InitializeGUI()
        {
            PopulateStaffListBox(staffManager.StaffMembers);
            PopulateComboBox<StaffTitleEnum>(cmbStaffTitle);
            PopulateComboBox<CompetenceLevelEnum>(cmbCompetenceLevel);
        }

        /// <summary>
        /// Populates the staff list box with the provided staff members.
        /// </summary>
        /// <param name="staffMembers">The list of staff members.</param>
        private void PopulateStaffListBox(List<StaffMember> staffMembers)
        {
            listStaffMembers.Items.Clear();
            foreach (var staffMember in staffMembers)
            {
                listStaffMembers.Items.Add(staffMember);
            }
        }

        /// <summary>
        /// Populates the competence list box based on the selected staff member.
        /// </summary>
        private void PopulateCompListBox()
        {
            StaffMember selectedMember = (StaffMember)listStaffMembers.SelectedItem;

            if (selectedMember != null)
            {
                List<Competence> membersCompetences = selectedMember.Competences;

                listCompetences.Items.Clear();

                foreach (var competence in membersCompetences)
                {
                    listCompetences.Items.Add(competence);
                }
            }
        }

        /// <summary>
        /// Populates a combo box with enum values.
        /// </summary>
        /// <typeparam name="TEnum">The enum type.</typeparam>
        /// <param name="comboBox">The combo box to populate.</param>
        private void PopulateComboBox<TEnum>(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (var enumValue in Enum.GetValues(typeof(TEnum)))
            {
                comboBox.Items.Add(enumValue);
            }
        }

        /// <summary>
        /// Resets controls related to staff members.
        /// </summary>
        private void ResetMemberControls()
        {
            txtStaffName.Clear();
            cmbStaffTitle.SelectedIndex = -1;
            PopulateStaffListBox(staffManager.StaffMembers);
        }

        /// <summary>
        /// Resets controls related to competences.
        /// </summary>
        private void ResetCompControls()
        {
            txtCompetenceName.Clear();
            cmbCompetenceLevel.SelectedIndex = -1;
            PopulateCompListBox();
        }

        /// <summary>
        /// Resets controls related to advanced search.
        /// </summary>
        private void ResetAdvSearch()
        {
            txtAdvSearchName.Clear();
            txtAdvSearchComp.Clear();
            cmbAdvSearchTitle.SelectedIndex = -1;
            cmbAdvSearchLevel.SelectedIndex = -1;
            pnlAdvSearch.Visible = false;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Populates the competence list box based on the selected staff member.
        /// </summary>
        private void listStaffMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCompListBox();
        }

        /// <summary>
        /// Adds a new staff member with the provided information.
        /// </summary>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string memberName = txtStaffName.Text.Trim();
            if (string.IsNullOrWhiteSpace(memberName) || cmbStaffTitle.SelectedItem == null)
            {
                MessageBox.Show("Invalid member name or title. Please provide valid values.");
                return;
            }
            StaffTitleEnum memberTitle = (StaffTitleEnum)cmbStaffTitle.SelectedItem;

            staffManager.NewMember(memberName, memberTitle);
            ResetMemberControls();
        }

        /// <summary>
        /// Edits the selected staff member with the provided information.
        /// </summary>
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (listStaffMembers.SelectedItem == null)
            {
                MessageBox.Show("Please select a staff member to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StaffMember selectedMember = (StaffMember)listStaffMembers.SelectedItem;

            string memberName = txtStaffName.Text.Trim();
            if (string.IsNullOrWhiteSpace(memberName) || cmbStaffTitle.SelectedItem == null)
            {
                MessageBox.Show("Please provide valid member name and title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StaffTitleEnum memberTitle = (StaffTitleEnum)cmbStaffTitle.SelectedItem;

            DialogResult result = MessageBox.Show("Are you sure you want to edit this staff member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            staffManager.UpdateMember(memberName, memberTitle, selectedMember);
            ResetMemberControls();
        }

        /// <summary>
        /// Deletes the selected staff member.
        /// </summary>
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            int memberIndex = listStaffMembers.SelectedIndex;
            if (memberIndex < 0 || memberIndex > staffManager.StaffMembers?.Count)
            {
                MessageBox.Show("Please select a staff member to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            staffManager.RemoveMember(memberIndex);
            ResetMemberControls();
        }

        /// <summary>
        /// Adds a new competence to the selected staff member.
        /// </summary>
        private void btnAddComp_Click(object sender, EventArgs e)
        {
            StaffMember selectedMember = (StaffMember)listStaffMembers.SelectedItem;
            if (selectedMember == null)
            {
                MessageBox.Show("Please select a staff member before adding a competence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string compName = txtCompetenceName.Text.Trim();
            if (string.IsNullOrWhiteSpace(compName) || cmbCompetenceLevel.SelectedItem == null)
            {
                MessageBox.Show("Please provide valid competence name and title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CompetenceLevelEnum compLevel = (CompetenceLevelEnum)cmbCompetenceLevel.SelectedItem;

            var newCompetence = competenceManager.NewCompetence(selectedMember.Id, compName, compLevel);
            staffManager.AddMemberComp(selectedMember, newCompetence);
            ResetCompControls();
        }

        /// <summary>
        /// Edits the selected competence of the selected staff member.
        /// </summary>
        private void btnEditComp_Click(object sender, EventArgs e)
        {
            if (listStaffMembers.SelectedItem == null)
            {
                MessageBox.Show("Please select a staff member before editing a competence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StaffMember selectedMember = (StaffMember)listStaffMembers.SelectedItem;

            if (listCompetences.SelectedItem == null)
            {
                MessageBox.Show("Please select a competence to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Competence selectedComp = (Competence)listCompetences.SelectedItem;

            string compName = txtCompetenceName.Text.Trim();
            if (string.IsNullOrWhiteSpace(compName) || cmbCompetenceLevel.SelectedItem == null)
            {
                MessageBox.Show("Please provide valid competence name and title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CompetenceLevelEnum compLevel = (CompetenceLevelEnum)cmbCompetenceLevel.SelectedItem;

            DialogResult result = MessageBox.Show("Are you sure you want to edit this competence?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            var updatedComp = competenceManager.UpdateCompetence(compName, compLevel, selectedComp);
            staffManager.UpdateMemberComp(selectedMember, selectedComp, updatedComp);
            ResetCompControls();
        }

        /// <summary>
        /// Removes the selected competence from the selected staff member.
        /// </summary>
        private void btnRemoveComp_Click(object sender, EventArgs e)
        {
            if (listStaffMembers.SelectedItem == null)
            {
                MessageBox.Show("Please select a staff member before deleting a competence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StaffMember selectedMember = (StaffMember)listStaffMembers.SelectedItem;

            if (listCompetences.SelectedItem == null)
            {
                MessageBox.Show("Please select a competence to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Competence selectedComp = (Competence)listCompetences.SelectedItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this competence?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            competenceManager.DeleteCompetence(selectedComp);
            staffManager.DeleteMemberComp(selectedMember, selectedComp);
            ResetCompControls();
        }

        /// <summary>
        /// Shows the advanced search panel.
        /// </summary>
        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            PopulateComboBox<StaffTitleEnum>(cmbAdvSearchTitle);
            PopulateComboBox<CompetenceLevelEnum>(cmbAdvSearchLevel);
            pnlAdvSearch.Visible = true;
        }

        /// <summary>
        /// Cancels the advanced search and resets related controls.
        /// </summary>
        private void btnAdvSearchCancel_Click(object sender, EventArgs e)
        {
            ResetAdvSearch();
        }

        /// <summary>
        /// Performs an advanced search based on the provided parameters and updates the staff list.
        /// </summary>
        private void btnAdvSearchApply_Click(object sender, EventArgs e)
        {
            string name = txtAdvSearchName.Text;
            string competence = txtAdvSearchComp.Text;
            StaffTitleEnum? title = cmbAdvSearchTitle.SelectedItem as StaffTitleEnum?;
            CompetenceLevelEnum? level = cmbAdvSearchLevel.SelectedItem as CompetenceLevelEnum?;

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(competence) && title == null && level == null)
            {
                MessageBox.Show("Please provide at least one search parameter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<StaffMember> searchResult = staffManager.AdvancedSearch(name, competence, title, level);
            PopulateStaffListBox(searchResult);
            btnResetSearch.Enabled = true;
            ResetAdvSearch();
        }

        /// <summary>
        /// Performs a simple search based on the entered name and updates the staff list.
        /// </summary>
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;
            List<StaffMember> searchResult = staffManager.SimpleSearch(name);
            PopulateStaffListBox(searchResult);
        }

        /// <summary>
        /// Resets the staff and competence lists to their original state.
        /// </summary>
        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            PopulateStaffListBox(staffManager.StaffMembers);
            PopulateCompListBox();
            btnResetSearch.Enabled = false;
        }
        #endregion
        #endregion
    }
}