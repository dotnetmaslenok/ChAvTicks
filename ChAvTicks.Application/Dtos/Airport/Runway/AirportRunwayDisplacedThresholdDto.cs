using ChAvTicks.Application.Dtos.Base;

namespace ChAvTicks.Application.Dtos.Airport.Runway
{
    public sealed record AirportRunwayDisplacedThresholdDto(
            double Meter,
            double Km,
            double Mile,
            double NauticalMile,
            double Feet)
        : DistanceDtoBase(Meter, Km, Mile, NauticalMile, Feet);
}
