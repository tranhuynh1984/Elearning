using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.Payment
{
    public interface IPaymentRepository
    {
        Task<IList<Database.Models.Payment>> AllPayments();
        Task<IList<CostEstimateItemType>> AllTypes(string unitType);
    }
}
