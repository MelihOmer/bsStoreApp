namespace Entities.Exceptions
{
    public class PriceOutOfRangeBadRequestException : BadRequestException
    {
        public PriceOutOfRangeBadRequestException() : base("Maximum Price Should Be Less Than 1000 and Greater Than 1.")
        {
        }
    }
}
