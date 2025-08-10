using System.Collections;
using MIP_API_CONNECTOR.Models;

namespace MIP_API_CONNECTOR.Services
{
    public interface IDocumentService
    {
        IEnumerable<DocumentDto> GetByUser(string username);
        DocumentDto? GetById(Guid id);
    }
}
