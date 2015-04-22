using EducationManagementSystem.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EducationManagementSystem.Views.Reports
{
    /// <summary>
    /// Interaction logic for UserReportView.xaml
    /// </summary>
    public partial class UserReportView : UserControl
    {
        public UserReportView()
        {
            InitializeComponent();

            LoadReport();
        }

        /// <summary>
        /// Loads the report.
        /// </summary>
        private void LoadReport()
        {
            ReportDataSource reportDataSource = new ReportDataSource();

            // Name of the DataSet we set in .rdlc
            reportDataSource.Name = "UserDataSet";
            reportDataSource.Value = GetUsers();

            UserReportViewer.LocalReport.DataSources.Clear();
            UserReportViewer.LocalReport.ReportEmbeddedResource = "EducationManagementSystem.Reports.UserReport.rdlc";
            UserReportViewer.LocalReport.DataSources.Add(reportDataSource);

            UserReportViewer.RefreshReport();
        }

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns></returns>
        private List<User> GetUsers()
        {
            using (EducationManagementSystemEntities entities = new EducationManagementSystemEntities())
            {
                return (from user in entities.Users
                        select user).ToList();
            }
        }
    }
}
