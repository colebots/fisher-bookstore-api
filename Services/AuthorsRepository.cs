using System.Collections.Generic;
using Fisher.Bookstore.Data;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Services
{

    public class AuthorsRepository : IAuthorsRepository
    {
        private readonly BookstoreContext db;

        public AuthorsRepository(BookstoreContext db)
        {
            this.db = db;
        }


        public int AddAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public bool AuthorExists(int authorId)
        {
            throw new System.NotImplementedException();
        }

        public bool BookExists(int bookId)
        {
            return (db.Books.Find(bookId) != null);

        }

        public void DeleteAuthor(int authorId)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            var book = db.Books.Find(bookId);
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public Author GetAuthor(int authorId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors()
        {
            throw new System.NotImplementedException();
        }

        public Book GetBook(int bookId)
        {
            return db.Books.Find(bookId);
        }

        public IEnumerable<Book> GetBooks()
        {
            return db.Books;
        }

        public void UpdateAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            var updateBook = db.Books.Find(book.Id);
            updateBook.Title = book.Title;
            db.Books.Update(updateBook);
            db.SaveChanges();
        }
    }
}