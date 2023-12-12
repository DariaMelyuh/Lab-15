namespace Mediator
{
    public class AlarmRequest : IRequest
    {
        public TimeOnly Time { get; private set; }

        public AlarmRequest(TimeOnly time)
        {
            Time = time;
        }
    }
}