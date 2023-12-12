using Mediator.Requests;
namespace Mediator
{
    internal class Sprinkler
    {
        public void Check(CalendarRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request), "Недопустимое значение");
            }

            if (request is CalendarEventRequest)
            {
                Console.WriteLine($"Система орашения будет включена {request.Date}");
            }
        }
        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Console.WriteLine($"Система орашения будет включена {request.Time}");
        }
    }
}