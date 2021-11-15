using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_FIA35_TicketsystemDAL.Models;

namespace WebApp_FIA35_TicketsystemDAL
{
    internal interface IData
    {
        List<Author> SelectAllAuthors();
        Author SelectAuthorById(int Id);
        int InsertAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool DeleteAuthorById(int Id);
        bool UpdateAuthor(Author author);
    }
}
