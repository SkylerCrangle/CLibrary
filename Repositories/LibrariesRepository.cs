using System.Collections.Generic;
using System.Data;
using Dapper;

namespace CLibrary.Repositories
{
  public class LibrariesRepository
  {
    private readonly IDbConnection _db;
    public LibrariesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Library> Get()
    {
      string sql = "SELECT * FROM books";
      return _db.Query<Library>(sql);
    }

    internal Library Create(Library newLibrary)
    {
      string sql = @"
            INSERT INTO blogs 
            (title, body, authorId, isPrivate) 
            VALUES 
            (@Title, @Body, @AuthorId, @IsPrivate);
            SELECT LAST_INSERT_ID()";
      newLibrary.Id = _db.ExecuteScalar<int>(sql, newLibrary);
      return newLibrary;
    }

    internal Library Get(int Id)
    {
      string sql = "SELECT * FROM blogs WHERE id = @Id";
      return _db.QueryFirstOrDefault<Library>(sql, new { Id });
    }
  }
}