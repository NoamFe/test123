//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace RateLimiter;

//internal class RulesFactory
//{
//}

//public interface IValidator
//{
//    Task Validate(object request);

//    IEnumerable<Resource> ValidatedTypes();
//}
 

//public class PerTimeSpanValidator : AbstractValidator
//{
//    public override Task Validate(object request)
//    {
//        throw new NotImplementedException();
//    }

//    public override IEnumerable<Resource> ValidatedTypes()
//    {
//        return new List<Resource>() {
//            Resource.User,
//            Resource.History,
//            Resource.Company
//        };
//    }
//}

//public class SinceLastTimeSpanValidator : AbstractValidator
//{ 
//    private Dictionary<Resource, TimeSpan> _timeSpans
//    = new Dictionary<Resource, TimeSpan>();

//    public override Task Validate(object request)
//    {
//        throw new NotImplementedException();
//    }

//    public override IEnumerable<Resource> ValidatedTypes()
//    {
//        return new List<Resource>() { 
//            Resource.User,
//            Resource.History
//        };
//    }
//}


