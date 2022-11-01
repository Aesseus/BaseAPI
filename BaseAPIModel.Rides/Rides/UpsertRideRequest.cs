using System;
namespace BaseAPIModel.Rides.Rides
{
    public record UpsertRideRequest(
        string? Name,
        string? Description,
        string? StartAddress,
        string? EndAddress,
        DateTime StartDateTime,
        DateTime EndDateTime,
        string? RideType,
        double RidePrice);
}