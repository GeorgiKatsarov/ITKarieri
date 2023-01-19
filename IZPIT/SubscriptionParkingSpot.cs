using System;
using System.Collections.Generic;
using System.Text;

internal class SubscriptionParkingSpot : ParkingSpot
{
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

    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
    {
    }

    public override bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (!this.Occupied && this.Type == type)
        {
            this.parkingIntervals.Add(new ParkingInterval(this, registrationPlate, hoursParked));
            this.Occupied = true;
            this.RegistrationPlate = registrationPlate;
            return true;
        }
        return false;


    }

    public override double CalculateTotal()
    {
        return 0;
    }
}