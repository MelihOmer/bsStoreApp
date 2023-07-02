using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record BookDtoForInsertion : BookDtoForManipulation
    {
        [Required(ErrorMessage ="CategoryId is required.")]
        public int CategoryId { get; init; }
    }
}
