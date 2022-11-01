using Microsoft.AspNetCore.Mvc;
using BaseAPIModel.Rides.Rides;
using Rides.Models;

namespace Rides.Controllers;

/// <summary>Defining endpoint, inheriting controller base.</summary>
[Route ("api/[controller]")]
[ApiController]
public class RidesController : ControllerBase
{
    /// <summary>
    /// Post to DB our ride data, with created {id} per post request.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult CreateRide(CreateRideRequest request)
    {
        // Mapping data that we get from the request to the language our app speaks.
        var ride = new Ride(Guid.NewGuid(), 
            request.Name, 
            request.Description,
            request.StartAddress,
            request.EndAddress,
            //request.StartDateTime, 
            //request.EndDateTime, 
            DateTime.UtcNow,
            request.RideType,
            request.RidePrice);

        // Save to DB

        var response = new RideAcceptResponse(
            ride.Id,
            ride.Name,
            ride.Description,
            ride.StartAddress,
            ride.EndAddress,
            //ride.LastModifiedDateTime,
            DateTime.UtcNow,
            ride.RideType,
            ride.RidePrice );

        //return CreatedAtAction(nameof(GetRide), new { id = ride.Id}, response);
        return Ok(ride.Id);
    }

    [HttpGet("/{id:guid}")]
    public IActionResult GetRide(Guid id)
    {
        return Ok(id);
    }
    [HttpPut("/{id:guid}")]
    public IActionResult UpsertRide(Guid id, UpsertRideRequest request)
    {
        return Ok(request);
    }
    [HttpDelete("/{id:guid}")]
    public IActionResult DeleteRide(Guid id)
    {
        return Ok(id);
    }
}