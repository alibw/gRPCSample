using Grpc.Core;

namespace gRPCSample.Services;

public class TimeService : Time.TimeBase
{
    public override Task<getTime> whatTimeItIs(EmptyTime request, ServerCallContext context)
    {
        return Task.FromResult(new getTime
            ()
            {
                Day = DateTime.Now.Day.ToString(),
                Year = DateTime.Now.Year.ToString()
            });
    }
}