using System.Collections.Generic;

namespace RateLimiter.Policies;

public class TokenRegionPolicy : OrRateLimiterPolicy
{
    public TokenRegionPolicy(IList<IRateLimiterPolicy> conditionIsTrueList,
        IList<IRateLimiterPolicy> conditionIsFalseList) 
        : base(conditionIsTrueList, conditionIsFalseList)
    {
    }

    public override bool CheckCondition(Request request) => request.token.IsUSToken();
}