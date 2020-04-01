using System.ComponentModel.DataAnnotations;

namespace CLibrary
{
  public class Book
  {
    public int Id { get; set; }



    [Required]
    [MaxLength(20)]
    public string Title { get; set; }



    public string LibraryId { get; set; }
    public bool IsAvailable { get; set; }
  }
}