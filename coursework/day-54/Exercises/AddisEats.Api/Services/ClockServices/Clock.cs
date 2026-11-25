namespace AddisEats.Api.Services.ClockServices;

public class Clock : IClock
{
    // public DateTime GetCurrentTime()      //ex-3
    // {
    //     return DateTime.UtcNow;
    // }

    //ex-4
    private readonly DateTime _timeAtCreation;

    public Clock()
    {
        _timeAtCreation = DateTime.UtcNow;
    }

    public DateTime GetCurrentTime()
    {
        return _timeAtCreation;
    }
}