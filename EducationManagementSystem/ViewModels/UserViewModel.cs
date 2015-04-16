using EducationManagementSystem.HelperClasses;

namespace EducationManagementSystem.ViewModels
{
    public class UserViewModel : ObservableObject, IPageViewModel
    {
        #region Properties

        public string Name
        {
            get
            {
                return "User";
            }
        }

        #endregion
    }
}
