using System.Collections.Generic;
using Elearning.Database.Models;

namespace Elearning.Web.Models
{
    public class MenuBuilder
    {
        public Functions Parent { get; set; }
        public IList<MenuBuilder> ChildFunctions { get; set; }
    }
}
