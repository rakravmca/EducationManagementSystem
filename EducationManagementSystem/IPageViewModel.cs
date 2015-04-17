
using EducationManagementSystem.HelperClasses;
namespace EducationManagementSystem
{
    public interface IPageViewModel
    {
        string Name { get; }
        Enums.UserType UserType { get; }
    }
}
