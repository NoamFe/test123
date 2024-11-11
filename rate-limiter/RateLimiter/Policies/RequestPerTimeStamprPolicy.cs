using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RateLimiter.Policies;

public class RequestPerTimeStamprPolicy : IRateLimiterPolicy
{
    private record RequestsPerTimeSpan(int requests, TimeSpan time);

    Dictionary<Resource, RequestsPerTimeSpan> resourceMapping = new();

    public RequestPerTimeStamprPolicy(Resource resource, int numberOfRequests, TimeSpan time)
    {
        if (!resourceMapping.ContainsKey(resource))
        {
            resourceMapping.Add(resource, new RequestsPerTimeSpan(numberOfRequests, time));
        }
    }
    public Task<bool> Validate(Request request)
    {
        throw new NotImplementedException();
    }
}
