using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface DocumentIDAL
    {
        List<Document> GetAllDocuments();
        Document GetDocumentById(int Id);

        int AddDocument(Document d);
        void UpdateDocument(int Id, Document d);
        void DeleteDocument(int Id);
    }
}
