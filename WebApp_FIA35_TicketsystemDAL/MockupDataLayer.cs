using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_FIA35_TicketsystemDAL.Models;

namespace WebApp_FIA35_TicketsystemDAL
{
    internal class MockupDataLayer : IData
    {

        public List<Author> ListAllAuthors;

        public MockupDataLayer()
        {
            ListAllAuthors = new List<Author>
            {
                new Author {AId = 1, Name="Hein Blöd",Created=new DateTime(2021,11,11), Active=true, ActiveSince=new DateTime(2021,11,12),LastPost=new DateTime(2021,11,14)},
                new Author {AId = 1, Name="Ute Unruh",Created=new DateTime(2021,10,07), Active=true, ActiveSince=new DateTime(2021,10,12),LastPost=new DateTime(2021,11,13)}
            };
        }

        public bool DeleteAuthor(Author author)
        {
            if (ListAllAuthors.Remove(author))
            {
                return true;
            }

            return false;
        }

        public bool DeleteAuthorById(int Id)
        {
            Author author2Delete = ListAllAuthors.FirstOrDefault(p => p.AId == Id);

            if (ListAllAuthors.Remove(author2Delete))
            {
                return true;
            }

            return false;
        }

        public int InsertAuthor(Author author)
        {
            ListAllAuthors.Add(author);

            return 1;
        }

        public List<Author> SelectAllAuthors()
        {
            return ListAllAuthors;

        }

        public Author SelectAuthorById(int Id)
        {
            Author author = ListAllAuthors.FirstOrDefault(p => p.AId == Id);

            return author;
        }

        public bool UpdateAuthor(Author author)
        {
            Author author2Update = ListAllAuthors.FirstOrDefault(p => p.AId == author.AId);

            author2Update.Name = author.Name;
            author2Update.Created = author.Created;
            author2Update.Active = author.Active;
            author2Update.ActiveSince = author.ActiveSince;
            author2Update.LastPost = author.LastPost;

            if (ListAllAuthors.Remove(author))
            {
                ListAllAuthors.Add(author2Update);

                return true;
            }

            return false;
        }
    }
}
