using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RateLimiter.Policies;

namespace RateLimiter;

public class TimePassedSinceLastRequestPolicy : IRateLimiterPolicy
{ 
    Dictionary<Resource, TimeSpan> resourceMapping = new();

    public TimePassedSinceLastRequestPolicy(Resource resource, TimeSpan time)
    {
        if (!resourceMapping.ContainsKey(resource))
        {
            resourceMapping.Add(resource, time);
        }
    }

    public Task<bool> Validate(Request request)
    {
        throw new NotImplementedException();
    }
}
