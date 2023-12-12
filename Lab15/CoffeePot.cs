using Mediator.Requests;
namespace Mediator
{
    internal class CoffeePot
    {
        public void Check(CalendarRequest request)
        {
            if (request == null) 
            { 
                throw new ArgumentNullException(nameof(request), "Недопустимое значение"); 
            }

            if (request is NewDayRequest)
            {
                if (request.Date.DayOfWeek == DayOfWeek.Saturday || request.Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("Выходной день");
                }
                else
                {
                    Console.WriteLine("Будний день");

                    if (DateTime.Now.Hour < 12)
                    {
                        Console.WriteLine("Варим кофе");
                    }
                }

            }
        }

        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request), "Недопустимое значение");
            }

            Console.WriteLine($"Кофе будет готов в {request.Time}");
        }
    }
}