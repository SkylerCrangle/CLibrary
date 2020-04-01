using System;
using System.Collections.Generic;
using CLibrary.Repositories;

namespace CLibrary.Services
{
  public class LibrariesService
  {
    private readonly LibrariesRepository _repo;
    public LibrariesService(LibrariesRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Library> Get()
    {
      return _repo.Get();
    }

    internal Library Create(Library newLibrary)
    {
      return _repo.Create(newLibrary);
    }


    internal Library Get(int id)
    {
      Library found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

  }
}