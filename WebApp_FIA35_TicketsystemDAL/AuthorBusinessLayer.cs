using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_FIA35_TicketsystemDAL;
using WebApp_FIA35_TicketsystemDAL.Models;

namespace Con_FIA35_DAL
{
    internal class AuthorBusinessLayer
    {

        IData DataAccess;


        // Dependency injection
        public AuthorBusinessLayer(IData DataAccess)

        {
            this.DataAccess = DataAccess;

        }

        public List<Author> GetAllAuthors()
        {
            return DataAccess.SelectAllAuthors();
        }

        public Author GetAuthorById(int Id)
        {
            return DataAccess.SelectAuthorById(Id);
        }

        public int AddAuthor(Author author)
        {
            return DataAccess.InsertAuthor(author);

        }

        public bool RemoveAuthor(Author author)
        {
            return DataAccess.DeleteAuthor(author);

        }

        public bool RemoveAuthorById(int Id)
        {
            return DataAccess.DeleteAuthorById(Id);

        }

        public bool RefreshAuthor(Author author)
        {
            return DataAccess.UpdateAuthor(author);
        }


        public DateTime GetLastPostDateByAuthor(Author author)
        {
            return author.LastPost;
        }

        public DateTime GetActiveDateByAuthor(Author author)
        {
            return author.ActiveSince;
        }
        public List<Author> GetActiveAuthors()
        {
            List<Author> authorList = DataAccess.SelectAllAuthors();
            authorList.RemoveAll(p => p.Active == false);

            return authorList;
        }

        public int GetCountActiveAuthors()
        {
            List<Author> authorList = DataAccess.SelectAllAuthors();
            return authorList.Count;
        }
        public List<Author> GetAuthorsByCharInName(string charInName)
        {
            List<Author> authorList = DataAccess.SelectAllAuthors();
            return authorList.FindAll(p => p.Name.Contains(charInName));
        }
        public List<Author> GetAuthorsPostsInMonth(int month)
        {
            List<Author> authorList = DataAccess.SelectAllAuthors();
            return authorList.FindAll(p => p.LastPost.Month == DateTime.Now.Month);
        }

    }
}
