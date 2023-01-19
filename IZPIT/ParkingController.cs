using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class ParkingController
{
    private List<ParkingSpot> parkingSpots;

    public ParkingController()
    {
        parkingSpots = new List<ParkingSpot>();
    }

    public string CreateParkingSpot(List<string> args)
    {
        if (this.parkingSpots.Any(x => x.Id == int.Parse(args[0])))
        {
            return $"Parking spot {args[0]} is already registered!";
        }
        if (args[2] == "subscription")
        {
            parkingSpots.Add(new SubscriptionParkingSpot(int.Parse(args[0]), bool.Parse(args[1]), double.Parse(args[3]), args[4]));
            return $"Parking spot {args[0]} was successfully registered in the system!";
        }
        else if (args[2] == "car")
        {
            parkingSpots.Add(new CarParkingSpot(int.Parse(args[0]), bool.Parse(args[1]), double.Parse(args[3])));
            return $"Parking spot {args[0]} was successfully registered in the system!";
        }
        else if (args[2] == "bus")
        {
            parkingSpots.Add(new BusParkingSpot(int.Parse(args[0]), bool.Parse(args[1]), double.Parse(args[3])));
            return $"Parking spot {args[0]} was successfully registered in the system!";
        }

        return "Unable to create parking spot!";
    }

    public string ParkVehicle(List<string> args)
    {
        if (!this.parkingSpots.Any(x => x.Id == int.Parse(args[0])))
        {
            return $"Parking spot {args[0]} not found!";
        }
        var spot = this.parkingSpots.FirstOrDefault(x => x.Id == int.Parse(args[0]));
        if (spot.Occupied || spot.Type != args[3])
        {
            return $"Vehicle {args[1]} can't park at {args[0]}.";
        }
        spot.ParkVehicle(args[1], int.Parse(args[2]), args[3]);
        return $"Vehicle {args[1]} parked at {args[0]} for {args[2]} hours.";
    }

    public string FreeParkingSpot(List<string> args)
    {

        if (!this.parkingSpots.Any(x => x.Id == int.Parse(args[0])))
        {
            return $"Parking spot {args[0]} not found!";
        }
        var spot = this.parkingSpots.FirstOrDefault(x => x.Id == int.Parse(args[0]));
        if (!spot.Occupied)
        {
            return $"Parking spot {args[0]} is not occupied.";
        }

        spot.Occupied = false;
        return $"Parking spot {args[0]} is now free!";
    }

    public string GetParkingSpotById(List<string> args)
    {
        if (!this.parkingSpots.Any(x => x.Id == int.Parse(args[0])))
        {
            return $"Parking spot {args[0]} not found!";
        }

        return parkingSpots.FirstOrDefault(x => x.Id == int.Parse(args[0])).ToString();
    }

    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        if (!this.parkingSpots.Any(x => x.Id == int.Parse(args[0])))
        {
            return $"Parking spot {args[0]} not found!";
        }

        var sb = new StringBuilder();
        var spot = this.parkingSpots.FirstOrDefault(x => x.Id == int.Parse(args[0]));

        sb.AppendLine($"Parking intervals for parking spot {spot.Id}:");

        foreach (var interval in spot.GetAllParkingIntervalsByRegistrationPlate(args[1]))
        {
            sb.AppendLine(interval.ToString());
        }

        return sb.ToString().Trim();
    }

    public string CalculateTotal(List<string> args)
    {
        return $"Total revenue from the parking: {this.parkingSpots.Sum(x => x.CalculateTotal()):F2} BGN";
    }

}