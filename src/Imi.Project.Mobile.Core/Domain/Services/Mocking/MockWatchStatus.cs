using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockWatchStatus : IWatchStatusService
    {
        private static List<WatchStatus> watchStatusList = new List<WatchStatus>
        {
                new WatchStatus
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Watching"
                },
                new WatchStatus
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "To Watch"
                },
                new WatchStatus
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Watched"
                }
        };
        public async Task<WatchStatus> GetStatusById(Guid id)
        {
            var status = watchStatusList.FirstOrDefault(s => s.Id == id);
            return await Task.FromResult(status);
        }
        public async Task<IQueryable<WatchStatus>> GetStatusList()
        {
            var statuses = watchStatusList.AsQueryable();
            return await Task.FromResult(statuses);
        }
    }
}
