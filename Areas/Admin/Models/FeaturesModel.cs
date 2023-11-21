using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Areas.Admin.Models;

public class Feature
{
    public int Id { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    [StringLength(30)]
    [Required]
    public string Content { get; set; }
}