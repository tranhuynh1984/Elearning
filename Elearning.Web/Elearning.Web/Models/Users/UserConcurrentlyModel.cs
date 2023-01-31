using System.Collections.Generic;
using Elearning.Database.Models;

namespace Elearning.Web.Models.Users
{
    public class UserConcurrentlyModel
    {
        public IList<UserConcurrently> UserConcurrently { get; set; }
        public bool AnyConcurrently { get; set; }
    }
}
