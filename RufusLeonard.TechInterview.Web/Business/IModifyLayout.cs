using RufusLeonard.TechInterview.Web.Models.ViewModels;

namespace RufusLeonard.TechInterview.Web.Business
{
    /// <summary>
    /// Defines a method which may be invoked by PageContextActionFilter allowing controllers
    /// to modify common layout properties of the view model.
    /// </summary>
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}
