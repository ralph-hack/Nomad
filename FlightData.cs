using System;

namespace Nomad
{
    public class FlightData
    {
        public DateTime DepartTime { get; set; }
		
		public DateTime ArrivalTime { get; set; }

        public string Destination { get; set; }        

        public string Origin  { get; set; }
    }
}
