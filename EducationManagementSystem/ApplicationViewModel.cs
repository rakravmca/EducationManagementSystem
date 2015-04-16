using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using EducationManagementSystem.Data;
using EducationManagementSystem.HelperClasses;
using EducationManagementSystem.ViewModels;

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

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        private List<IPageViewModel> _currentViewModels;
        private List<IPageViewModel> _administrationViewModels;
        private bool _isLoginPopupOpen;
        private User _currentUser;
        private string _userName;
        private string _userDisplayName;
        private bool _isAuntheticated;

        #endregion

        #region Constructor

        public ApplicationViewModel()
        {
            // Add available pages
            PageViewModels.Add(new HomeViewModel());
            CurrentViewModels = PageViewModels.ToList();

            // Set starting page
            CurrentPageViewModel = CurrentViewModels[0];
        }

        #endregion

        #region Commands

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

        #endregion

        #region Properties

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public List<IPageViewModel> AdministrationViewModels
        {
            get
            {
                if (_administrationViewModels == null)
                    _administrationViewModels = PageViewModels.Where(w => !w.Name.Equals("Home")).ToList();

                return _administrationViewModels;
            }
        }

        public List<IPageViewModel> CurrentViewModels
        {
            get
            {
                return _currentViewModels;
            }
            set
            {
                if (_currentViewModels != value)
                {
                    _currentViewModels = value;
                    OnPropertyChanged("CurrentViewModels");
                }
            }
        }

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

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public string UserDisplayName
        {
            get { return _userDisplayName; }
            set
            {
                _userDisplayName = value;
                RaisePropertyChanged("UserDisplayName");
            }
        }

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

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        private void OpenLoginUserPopup()
        {
            IsLoginPopupOpen = true;
        }

        private void CloseLoginUserPopup()
        {
            IsLoginPopupOpen = false;
        }

        private void LoginUser(Object objPasswordBox)
        {
            PasswordBox pwBox = objPasswordBox as PasswordBox;

            using (EducationManagementSystemEntities entities = new EducationManagementSystemEntities())
            {
                CurrentUser = (from user in entities.Users
                               where
                               (
                               user.UserName == UserName &&
                               user.Password == pwBox.Password
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

                //PageViewModels.Add(new HomeViewModel());
                PageViewModels.Add(new UserViewModel());
                CurrentViewModels = PageViewModels.ToList();

                // Set starting page
                CurrentPageViewModel = CurrentViewModels[0];
            }
        }

        private void Logout()
        {
            CurrentUser = null;
            IsAuntheticated = false;
            UserDisplayName = string.Empty;

            //Clear Page View Model
            PageViewModels.Clear();

            // Add available pages
            PageViewModels.Add(new HomeViewModel());
            CurrentViewModels = PageViewModels.ToList();

            // Set starting page
            CurrentPageViewModel = CurrentViewModels[0];
        }

        #endregion
    }
}
