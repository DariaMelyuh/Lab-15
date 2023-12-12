using Mediator.Requests;
namespace Mediator
{
    internal class CalendarMediator : IMediator
    {
        private CoffeePot _coffeePot { get; set; }
        private Sprinkler _sprinkler { get; set; }

        public CalendarMediator(CoffeePot coffeePot, Sprinkler sprinkler)
        {
            if (coffeePot == null) 
            { 
                throw new ArgumentNullException(nameof(coffeePot), "Недопустимое значение"); 
            }

            if (sprinkler == null) 
            { 
                throw new ArgumentNullException(nameof(sprinkler), "Недопустимое значение"); 
            }

            _coffeePot = coffeePot;
            _sprinkler = sprinkler;
        }

        public void Execute(IRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request is CalendarRequest calendarRequest)
            {
                _coffeePot.Check(calendarRequest);
                _sprinkler.Check(calendarRequest);
            }
        }
    }
}