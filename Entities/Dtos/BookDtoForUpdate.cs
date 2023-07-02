using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; set; }
    }
}
