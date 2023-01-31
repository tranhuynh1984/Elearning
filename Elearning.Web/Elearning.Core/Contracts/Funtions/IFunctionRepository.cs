using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.Funtions
{
    public interface IFunctionRepository
    {
       Task<IList<Functions>> GetAll();
    }
}
