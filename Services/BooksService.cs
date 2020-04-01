using System;
using System.Collections.Generic;
using CLibrary.Repositories;

namespace CLibrary.Services
{
  public class BooksService
  {
    private readonly BooksRepository _repo;
    public BooksService(BooksRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Book> Get()
    {
      return _repo.Get();
    }

    internal Book Create(Book newBook)
    {
      return _repo.Create(newBook);
    }


    internal Book Get(int id)
    {
      Book found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

  }
}