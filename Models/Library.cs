using System.ComponentModel.DataAnnotations;

namespace CLibrary
{
  public class Library
  {
    public int Id { get; set; }



    [Required]
    [MaxLength(20)]
    public string Name { get; set; }



    public string Location { get; set; }

  }
}