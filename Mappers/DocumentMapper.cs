using System.Runtime.CompilerServices;
using MIP_API_CONNECTOR.Models;

namespace MIP_API_CONNECTOR.Mappers
{
    public static class DocumentMapper
    {
        public static DocumentDto ToDto(this SdkDocument doc)
        {
            return new DocumentDto
            {
                Id = doc.Id,
                Name = doc.Name,
                Text = doc.Text,
                Owner = doc.Owner,
                TimeStamp = doc.TimeStamp,
                Information = $"Источник:{(doc==null?"?":doc.Source)}, актуально на {(doc==null?"?":doc.TimeStamp.ToString("dd.MM.yyyy"))}"
            };
        }

        public static IEnumerable<DocumentDto> ToListDto(this IEnumerable<SdkDocument> docs)
        {
            return docs.Select(doc => ToDto(doc));
        }
    }
}
