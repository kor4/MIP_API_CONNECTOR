using System.Net;
using System.Runtime.InteropServices;
using MIP_API_CONNECTOR.Models;

namespace MIP_API_CONNECTOR.Services
{
    public class DocumentSdkService : IDocumentSdkService
    {
        private readonly List<SdkDocument> _docs;

        public DocumentSdkService()
        {
            _docs = new List<SdkDocument>()
            {
                new SdkDocument()
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "№ 2040-ПП от 26.10.2023 «Об утверждении проекта планировки территории линейного объекта...",
                    Text =  "В соответствии с Градостроительным кодексом... ",
                    Source = "mos.ru",
                    Owner = "Иванов И.",
                    TimeStamp = new DateTime(2023, 09, 01),

                },
                new SdkDocument()
                {
                    Id = Guid.NewGuid(),
                    Name = "МЕТРОПОЛИТЕН И ОБЪЕКТЫ ЕГО ИНФРАСТРУКТУРЫ",
                    Text =  "СОДЕРЖАНИЕ\r\nСтр.\r\nВведение...",
                    Source = "mos.ru",
                    Owner = "Петров П."
                   
                },
                new SdkDocument()
                {
                    Id = Guid.NewGuid(),
                    Name = "Разрешение на ввод в эксплуатацию",
                    Text =  "...",
                    Source = "mosinzhproekt.ru",
                    Owner = "Сидоров С."
                }
            };

        }

        public SdkDocument? GetDocumentById(Guid id)
        {
            if (id == Guid.Empty)
                throw new Exception("Ошибка документа");

            var doc = _docs.FirstOrDefault(d => d.Id == id);
            return doc;
        }

        public IEnumerable<SdkDocument> GetDocumentsByUser(string username)
        {
            if (username == "error")//например. для вызова исключения 
            {
                throw new InvalidOperationException("Ошибка. Невозможно найти документы");
            }

            var docs = _docs.Where(x => x.Owner == username);
            return docs;
        }
    }
}
