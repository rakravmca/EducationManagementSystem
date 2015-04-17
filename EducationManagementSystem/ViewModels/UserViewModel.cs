using EducationManagementSystem.HelperClasses;

namespace EducationManagementSystem.ViewModels
{
    public class UserViewModel : ObservableObject, IPageViewModel
    {
        #region Properties

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return "Users";
            }
        }

        /// <summary>
        /// Gets the type of the user.
        /// </summary>
        /// <value>
        /// The type of the user.
        /// </value>
        public Enums.UserType UserType
        {
            get
            {
                return Enums.UserType.Admin;
            }
        }

        #endregion
    }
}
