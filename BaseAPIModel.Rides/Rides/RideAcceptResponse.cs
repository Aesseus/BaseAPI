using System;
namespace BaseAPIModel.Rides.Rides
{
    public record RideAcceptResponse(
        Guid Id,
        string Name,
        string Description,
        string StartAddress,
        string EndAddress,
        DateTime StartDateTime,
        //DateTime EndDateTime,
        //DateTime LastModifiedDateTime,
        string RideType,
        double RidePrice);
}