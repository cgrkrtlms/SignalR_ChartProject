using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_ChartProject.API.Models
{
    public enum ECity
    {
        Istanbul=1,
        Ankara,
        Izmir,
        Konya,
        Antalya
    }
    public class Covid
    {
        public int ID { get; set; }
        public ECity City { get; set; }
        public int Count { get; set; }
        public DateTime CovidDate { get; set; }


    }
}
