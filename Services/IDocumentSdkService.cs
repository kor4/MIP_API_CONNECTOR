using MIP_API_CONNECTOR.Models;

namespace MIP_API_CONNECTOR.Services
{
    public interface IDocumentSdkService
    {
        IEnumerable<SdkDocument> GetDocumentsByUser(string username);
        SdkDocument? GetDocumentById(Guid id);
    }
}
