using EducationManagementSystem.Data;
using EducationManagementSystem.HelperClasses;
using EducationManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace EducationManagementSystem
{
    public class ApplicationViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;
        private ICommand _openLoginUserCommand;
        private ICommand _closeLoginUserCommand;
        private ICommand _loginUserCommand;
        private ICommand _logoutCommand;
        private ICommand _cancelLoginCommand;
        private ICommand _redirectToHomePageCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        private List<IPageViewModel> _userViewModels;
        private List<IPageViewModel> _administratorViewModels;
        private bool _isLoginPopupOpen;
        private User _currentUser;
        private string _userName;
        private string _userDisplayName;
        private bool _isAuntheticated;

        public PasswordBox MyPasswordBox;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationViewModel"/> class.
        /// </summary>
        public ApplicationViewModel()
        {
            //Add Page View Models
            PageViewModels.Add(new UserViewModel());
            PageViewModels.Add(new StudentViewModel());

            RedirectToHomePage();

            OpenLoginUserPopup();
        }

        #endregion

        #region Commands

        /// <summary>
        /// Gets the change page command.
        /// </summary>
        /// <value>
        /// The change page command.
        /// </value>
        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }

        /// <summary>
        /// Gets the open login user command.
        /// </summary>
        /// <value>
        /// The open login user command.
        /// </value>
        public ICommand OpenLoginUserCommand
        {
            get
            {
                if (_openLoginUserCommand == null)
                {
                    _openLoginUserCommand = new RelayCommand(
                        p => OpenLoginUserPopup());
                }
                return _openLoginUserCommand;
            }
        }

        /// <summary>
        /// Gets the close login user command.
        /// </summary>
        /// <value>
        /// The close login user command.
        /// </value>
        public ICommand CloseLoginUserCommand
        {
            get
            {
                if (_closeLoginUserCommand == null)
                {
                    _closeLoginUserCommand = new RelayCommand(
                        p => CloseLoginUserPopup());
                }
                return _closeLoginUserCommand;
            }
        }

        /// <summary>
        /// Gets the login user command.
        /// </summary>
        /// <value>
        /// The login user command.
        /// </value>
        public ICommand LoginUserCommand
        {
            get
            {
                if (_loginUserCommand == null)
                {
                    _loginUserCommand = new RelayCommand(
                        p => LoginUser((Object)p),
                            p => p is Object);
                }

                return _loginUserCommand;
            }
        }

        /// <summary>
        /// Gets the login user command.
        /// </summary>
        /// <value>
        /// The login user command.
        /// </value>
        public ICommand CancelLoginCommand
        {
            get
            {
                if (_cancelLoginCommand == null)
                {
                    _cancelLoginCommand = new RelayCommand(
                        p => CancelLogin((Object)p),
                            p => p is Object);
                }

                return _cancelLoginCommand;
            }
        }

        /// <summary>
        /// Gets the logout command.
        /// </summary>
        /// <value>
        /// The logout command.
        /// </value>
        public ICommand LogoutCommand
        {
            get
            {
                if (_logoutCommand == null)
                {
                    _logoutCommand = new RelayCommand(
                        p => Logout());
                }

                return _logoutCommand;
            }
        }

        /// <summary>
        /// Gets the redirect to home page command.
        /// </summary>
        /// <value>
        /// The redirect to home page command.
        /// </value>
        public ICommand RedirectToHomePageCommand
        {
            get
            {
                if (_redirectToHomePageCommand == null)
                {
                    _redirectToHomePageCommand = new RelayCommand(
                        p => RedirectToHomePage());
                }

                return _redirectToHomePageCommand;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the page view models.
        /// </summary>
        /// <value>
        /// The page view models.
        /// </value>
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        /// <summary>
        /// Gets the administration view models.
        /// </summary>
        /// <value>
        /// The administration view models.
        /// </value>
        public List<IPageViewModel> AdministratiorViewModels
        {
            get
            {
                return _administratorViewModels;
            }
            set
            {
                if (_administratorViewModels != value)
                {
                    _administratorViewModels = value;
                    OnPropertyChanged("AdministratiorViewModels");
                }
            }
        }

        /// <summary>
        /// Gets or sets the current view models.
        /// </summary>
        /// <value>
        /// The current view models.
        /// </value>
        public List<IPageViewModel> UserViewModels
        {
            get
            {
                return _userViewModels;
            }
            set
            {
                if (_userViewModels != value)
                {
                    _userViewModels = value;
                    OnPropertyChanged("UserViewModels");
                }
            }
        }

        /// <summary>
        /// Gets or sets the current page view model.
        /// </summary>
        /// <value>
        /// The current page view model.
        /// </value>
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is login popup open.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is login popup open; otherwise, <c>false</c>.
        /// </value>
        public bool IsLoginPopupOpen
        {
            get
            {
                return _isLoginPopupOpen;
            }
            set
            {
                if (_isLoginPopupOpen != value)
                {
                    _isLoginPopupOpen = value;
                    OnPropertyChanged("IsLoginPopupOpen");
                }
            }
        }

        /// <summary>
        /// Gets or sets the current user.
        /// </summary>
        /// <value>
        /// The current user.
        /// </value>
        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (value != _currentUser)
                {
                    _currentUser = value;
                    OnPropertyChanged("CurrentUser");
                }
            }
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        /// <summary>
        /// Gets or sets the display name of the user.
        /// </summary>
        /// <value>
        /// The display name of the user.
        /// </value>
        public string UserDisplayName
        {
            get { return _userDisplayName; }
            set
            {
                _userDisplayName = value;
                RaisePropertyChanged("UserDisplayName");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is auntheticated.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is auntheticated; otherwise, <c>false</c>.
        /// </value>
        public bool IsAuntheticated
        {
            get { return _isAuntheticated; }
            set
            {
                _isAuntheticated = value;
                RaisePropertyChanged("IsAuntheticated");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Changes the view model.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        /// <summary>
        /// Opens the login user popup.
        /// </summary>
        private void OpenLoginUserPopup()
        {
            IsLoginPopupOpen = true;
        }

        /// <summary>
        /// Closes the login user popup.
        /// </summary>
        private void CloseLoginUserPopup()
        {
            UserName = string.Empty;

            if (MyPasswordBox != null)
            {
                MyPasswordBox.Password = string.Empty;
            }

            IsLoginPopupOpen = false;
        }

        /// <summary>
        /// Logins the user.
        /// </summary>
        /// <param name="objPasswordBox">The object password box.</param>
        private void LoginUser(Object objPasswordBox)
        {
            MyPasswordBox = objPasswordBox as PasswordBox;

            using (EducationManagementSystemEntities entities = new EducationManagementSystemEntities())
            {
                CurrentUser = (from user in entities.Users
                               where
                               (
                               user.UserName == UserName &&
                               user.Password == MyPasswordBox.Password
                               )
                               select user).SingleOrDefault();
            }

            if (CurrentUser != null)
            {
                IsAuntheticated = true;
                UserDisplayName = (!String.IsNullOrWhiteSpace(CurrentUser.Initial) ? CurrentUser.Initial + " " : string.Empty) +
                                    CurrentUser.FirstName + " " + (!String.IsNullOrWhiteSpace(CurrentUser.MiddleName) ? CurrentUser.MiddleName + " " : string.Empty) + 
                                    " " + CurrentUser.LastName;
                CloseLoginUserPopup();

                UserViewModels = PageViewModels.Where(w=>w.UserType == Enums.UserType.User).ToList();
                AdministratiorViewModels = PageViewModels.Where(w => w.UserType == Enums.UserType.Admin).ToList();

                // Set starting page
                RedirectToHomePage();
            }
        }

        /// <summary>
        /// Cancels the login.
        /// </summary>
        /// <param name="objPasswordBox">The object password box.</param>
        private void CancelLogin(Object objPasswordBox)
        {
            MyPasswordBox = objPasswordBox as PasswordBox;
            CloseLoginUserPopup();
        }

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        private void Logout()
        {
            CurrentUser = null;
            IsAuntheticated = false;
            UserDisplayName = string.Empty;

            //Clear Curent View Models
            UserViewModels.Clear();
            AdministratiorViewModels.Clear();

            // Set starting page
            RedirectToHomePage();

            OpenLoginUserPopup();
        }

        /// <summary>
        /// Redirects to home page.
        /// </summary>
        private void RedirectToHomePage()
        {
            CurrentPageViewModel = new HomeViewModel();
        }

        #endregion
    }
}
