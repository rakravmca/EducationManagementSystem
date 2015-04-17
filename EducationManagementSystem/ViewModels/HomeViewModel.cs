﻿using EducationManagementSystem.HelperClasses;

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
