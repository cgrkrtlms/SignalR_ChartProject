using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_ChartProject.API.Hubs
{
    public class CovidHub:Hub
    {
        public async Task GetCovidList()
        {
            await Clients.All.SendAsync("ReceiveCovidList","serviceden covid 19 verilerini al");
        }
    }
}
