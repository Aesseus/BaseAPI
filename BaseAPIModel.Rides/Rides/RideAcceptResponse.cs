using System;
namespace BaseAPIModel.Rides.Rides
{

    public record RideAcceptResponse(
        Guid Id,
        string? Name = "Enter your Name.",
        string? Description = null,
        string? StartAddress = null,
        string? EndAddress = null,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDateTime,
        string? RideType = null,
        string? RidePrice = null,
        string? RidePricePerKM = null,
        string? RidePricePerMinute = null,
        string? RidePricePerHour = null,
        string? RidePricePerDay = null);

}