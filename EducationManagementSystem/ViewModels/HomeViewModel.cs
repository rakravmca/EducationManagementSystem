using EducationManagementSystem.HelperClasses;

namespace EducationManagementSystem.ViewModels
{
    public class HomeViewModel : ObservableObject, IPageViewModel
    {
        #region Properties

        public string Name
        {
            get
            {
                return "Home";
            }
        }

        #endregion
    }
}
