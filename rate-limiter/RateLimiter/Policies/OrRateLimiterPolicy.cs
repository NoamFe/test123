using System.Collections.Generic;
using System.Threading.Tasks;

namespace RateLimiter.Policies;

public abstract class OrRateLimiterPolicy : IRateLimiterPolicy
{
    public IList<IRateLimiterPolicy> _conditionIsTrueList { get; }
    public IList<IRateLimiterPolicy> _conditionIsFalseList { get; }

    public OrRateLimiterPolicy(
        IList<IRateLimiterPolicy> conditionIsTrueList,
        IList<IRateLimiterPolicy> conditionIsFalseList)
    {
        _conditionIsTrueList = conditionIsTrueList;
        _conditionIsFalseList = conditionIsFalseList;
    }

    public abstract bool CheckCondition(Request request);

    public async Task<bool> Validate(Request request)
    {
        if (CheckCondition(request))
        {
            return await ExecutePolicies(request, _conditionIsTrueList);
        }
        else
        {
            return await ExecutePolicies(request, _conditionIsFalseList);
        }
    }

    private async Task<bool> ExecutePolicies(Request request, IList<IRateLimiterPolicy> policies)
    {
        foreach (var item in policies)
        {
            var response = await item.Validate(request);
            if (response == false)
                return false;
        }

        return true;
    }
}
