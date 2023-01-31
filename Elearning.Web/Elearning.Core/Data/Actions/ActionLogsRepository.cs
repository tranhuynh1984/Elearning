using System;
using System.Threading.Tasks;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.Actions;
using Elearning.Database;
using Elearning.Database.Models;
using Serilog;

namespace Elearning.Core.Data.Actions
{
    public class ActionLogsRepository : IActionLogsRepository
    {
        private readonly Context _ctx;
        public static int AllStat = 100;
        public ActionLogsRepository(Context ctx)
        {
            _ctx = ctx;
        }

        public async Task AddLogAsync(ActionLogs item)
        {
            try
            {
                await _ctx.ActionLogs.AddAsync(item);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Log.Error(e, "Error");
            }
        }
    }
}
