namespace Mediator.Requests
{
    public class CalendarRequest : IRequest
    {
        public DateOnly Date { get; private set; }
       
        public CalendarRequest(DateOnly date)
        {
            Date = date;
        }
    }
}