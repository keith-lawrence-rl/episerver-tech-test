using EPiServer.Core;

namespace RufusLeonard.TechInterview.Web.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
