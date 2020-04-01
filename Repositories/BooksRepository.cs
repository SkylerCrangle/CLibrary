using System.Collections.Generic;
using System.Data;
using Dapper;

namespace CLibrary.Repositories
{
  public class BooksRepository
  {
    private readonly IDbConnection _db;
    public BooksRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Book> Get()
    {
      string sql = "SELECT * FROM books";
      return _db.Query<Book>(sql);
    }

    internal Book Create(Book newBook)
    {
      string sql = @"
            INSERT INTO blogs 
            (title, body, authorId, isPrivate) 
            VALUES 
            (@Title, @Body, @AuthorId, @IsPrivate);
            SELECT LAST_INSERT_ID()";
      newBook.Id = _db.ExecuteScalar<int>(sql, newBook);
      return newBook;
    }

    internal Book Get(int Id)
    {
      string sql = "SELECT * FROM blogs WHERE id = @Id";
      return _db.QueryFirstOrDefault<Book>(sql, new { Id });
    }
  }
}