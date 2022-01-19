using Microsoft.AspNetCore.SignalR;
using SignalR_ChartProject.API.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_ChartProject.API.Models
{
    public class CovidService
    {
        private readonly ProjectContext _contex;
        private readonly IHubContext<CovidHub> _hubContext;
        public CovidService(ProjectContext contex, IHubContext<CovidHub> hubContext)
        {
            _contex = contex;
            _hubContext = hubContext;
        }

        public IQueryable<Covid> GetList()
        {
            return _contex.Covids.AsQueryable();
        }

        public async Task SaveCovid(Covid covid)
        {
            await _contex.Covids.AddAsync(covid);
            await _contex.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("ReceiveCovidList","data");
        }
    }
}
