using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter.Policies;

public interface IRateLimiterPolicy
{
    Task<bool> Validate(Request request);
    //   public abstract IEnumerable<Resource> ValidatedTypes();
}
