﻿using EducationManagementSystem.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagementSystem.Model
{
    class StudentModel : ObservableObject, IDataErrorInfo
    {
        #region Fields

        private long _id { get; set; }
        private string _firstName { get; set; }
        private string _middleName { get; set; }
        private string _lastName { get; set; }
        private DateTime _birthDate { get; set; }
        private string _gender { get; set; }
        private string _phone { get; set; }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public long Id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            } 
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName 
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }  
        }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>
        /// The name of the middle.
        /// </value>
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                if (_middleName != value)
                {
                    _middleName = value;
                    OnPropertyChanged("MiddleName");
                }
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }
        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                if (_birthDate != value)
                {
                    _birthDate = value;
                    OnPropertyChanged("BirthDate");
                }
            }
        }
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (_gender != value)
                {
                    _gender = value;
                    OnPropertyChanged("Gender");
                }
            }
        }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }

        #endregion

        /// <summary>
        /// Gets an error message indicating what is wrong with this object.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        /// <returns>An error message indicating what is wrong with this object. The default is an empty string ("").</returns>
        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the error message for the property with the given name.
        /// </summary>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case "FirstName": if (string.IsNullOrEmpty(FirstName)) result = "First Name is required!"; break;
                    case "LastName": if (string.IsNullOrEmpty(LastName)) result = "Last Name is required!"; break;
                    case "Gender": if (string.IsNullOrEmpty(Gender)) result = "Gender is required!"; break;
                };
                return result;
            }
        }
    }
}
