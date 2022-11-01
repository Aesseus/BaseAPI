using System;
namespace BaseAPIModel.Rides.Rides
{
    /// <summary>
    /// Class library to fascilitate data end and start points. Create a ride record.
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="Description"></param>
    /// <param name="StartAddress"></param>
    /// <param name="EndAddress"></param>
    /// <param name="StartDateTime"></param>
    /// <param name="EndDateTime"></param>
    /// <param name="LastModifiedDateTime"></param>
    /// <param name="RideType"></param>
    /// <param name="RidePrice"></param>
    /// <param name="RidePricePerKM"></param>
    /// <param name="RidePricePerMinute"></param>
    /// <param name="RidePricePerHour"></param>
    /// <param name="RidePricePerDay"></param>
    public record CreateRideRequest(
        string Name,
        string Description,
        string StartAddress,
        string EndAddress,
        DateTime StartDateTime,
        DateTime EndDateTime,
        //DateTime LastModifiedDateTime,
        string RideType,
        double RidePrice);

    // Create task method that loads data
    //public async Task<List<T>> CreateRide<T, U>(string sql, U parameters)
    //{
    //    string connectionString = _config.GetConnectionString(ConnectionStringName);
    //}
}