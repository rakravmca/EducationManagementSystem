using EducationManagementSystem.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagementSystem.ViewModels
{
    class StudentViewModel : ObservableObject, IPageViewModel
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
                return "Students";
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
                return Enums.UserType.User;
            }
        }

        #endregion
    }
}
