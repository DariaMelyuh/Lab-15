using Mediator.Requests;
namespace Mediator
{
    public class CalendarEventRequest : CalendarRequest
    {
        public CalendarEventRequest(DateOnly date) 
            : base(date) { }
    }
}