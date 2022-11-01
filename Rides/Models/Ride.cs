namespace Rides.Models;
    public class Ride
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string StartAddress { get; }
        public string EndAddress { get;  }
        public DateTime StartDateTime { get; }
        public DateTime EndDateTime { get; }
        public DateTime LastModifiedDateTime { get; }
        public string RideType {get; } 
        public double RidePrice {get; }
        public string RidePricePerKM {get; }
        public string RidePricePerMinute {get; }
        public string RidePricePerHour {get; }
        public string RidePricePerDay { get; } 

    /// <summary>
    ///  Constructor for a Ride...
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="startDateTime"></param>
    /// <param name="endDateTime"></param>
    /// <param name="lastModifiedDateTime"></param>
    /// <param name="rideType"></param>
    /// <param name="ridePrice"></param>
        public Ride(Guid id, 
            string name, 
            string description,
            //DateTime startDateTime, 
            //DateTime endDateTime,
            string startAddress,
            string endAddress,
            DateTime lastModifiedDateTime,
            string rideType,
            double ridePrice)
        {
            Id = id; // no public sets protect invariants and gives us more security for enforcement rules i.e name of description > 3 chars.
            Name = name;
            Description = description;
        //StartDateTime = startDateTime;
        //EndDateTime = endDateTime;
            StartAddress = startAddress;
            EndAddress = endAddress;
            LastModifiedDateTime = lastModifiedDateTime;
            RideType = rideType;
            RidePrice = ridePrice;                   

        }
    }    

