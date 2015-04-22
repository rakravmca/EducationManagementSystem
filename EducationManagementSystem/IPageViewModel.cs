
using EducationManagementSystem.HelperClasses;
namespace EducationManagementSystem
{
    public interface IPageViewModel
    {
        string Name { get; }
        Enums.PageType PageType { get; }
    }
}
