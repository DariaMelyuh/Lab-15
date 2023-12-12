using Mediator.Requests;
namespace Mediator
{
    internal class Calendar
    {
        private CalendarMediator _mediator { get; set; }

        public Calendar(CalendarMediator calendarMediator)
        {
            if (calendarMediator == null)
            {
                throw new ArgumentNullException(nameof(calendarMediator), "Недопустимое значение");
            }

            _mediator = calendarMediator;
        }

        public void OnEvent()
        {
            _mediator.Execute(new NewDayRequest());
        }
    }
}