using MIP_API_CONNECTOR.Mappers;
using MIP_API_CONNECTOR.Models;

namespace MIP_API_CONNECTOR.Services
{
    public class DocumentService : IDocumentService

    {
        private readonly IDocumentSdkService _sdkService;
        public DocumentService(IDocumentSdkService sdk) 
        { 
            _sdkService = sdk;
        }
        public DocumentDto? GetById(Guid id)
        {
            var sdkDoc = _sdkService.GetDocumentById(id);
            return (sdkDoc?.ToDto());
        }

        public IEnumerable<DocumentDto> GetByUser(string username)
        {
            var sdkDocs = _sdkService.GetDocumentsByUser(username);
            return sdkDocs.ToListDto();
        }
    }
}
