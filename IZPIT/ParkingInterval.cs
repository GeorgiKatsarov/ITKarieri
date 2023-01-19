using System;
using System.Collections.Generic;
using System.Text;

public class ParkingInterval
{
    private ParkingSpot parkingSpot;

    public ParkingSpot ParkingSpot
    {
        get
        {
            return this.parkingSpot;
        }

        set
        {
            this.parkingSpot = value;
        }
    }

    private string registrationPlate;

    public string RegistrationPlate
    {
        get
        {
            return this.registrationPlate;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Registration plate can’t be null or empty!");
            }
            this.registrationPlate = value;
        }
    }

    private int hoursParked;

    public int HoursParked
    {
        get
        {
            return this.hoursParked;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Hours parked can’t be zero or negative!");
            }
            this.hoursParked = value;
        }
    }

    public double Revenue
    {
        get
        {
            return this.ParkingSpot.Type == "subscription" ? 0 : (double)this.HoursParked * this.ParkingSpot.Price;
        }
    }

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        this.ParkingSpot = parkingSpot;
        this.RegistrationPlate = registrationPlate;
        this.HoursParked = hoursParked;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"> Parking Spot #{ParkingSpot.Id}");
        sb.AppendLine($"> RegistrationPlate: {RegistrationPlate}");
        sb.AppendLine($"> HoursParked: {HoursParked}");
        sb.AppendLine($"> Revenue: {Revenue:f2} BGN");

        return sb.ToString().Trim();
    }
}