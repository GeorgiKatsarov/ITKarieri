﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ParkingSpot
{
    private int id;
    private bool occupied;
    private string type;
    private double price;
    protected List<ParkingInterval> parkingIntervals;

    public int Id
    {
        get
        {
            return this.id;
        }

        set
        {
            this.id = value;
        }
    }

    public bool Occupied
    {
        get
        {
            return this.occupied;
        }

        set
        {
            this.occupied = value;
        }
    }

    public string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            this.type = value;
        }

    }

    public double Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
            }
            this.price = value;
        }
    }

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }

    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (!this.Occupied && this.Type == type)
        {
            this.parkingIntervals.Add(new ParkingInterval(this, registrationPlate, hoursParked));
            this.Occupied = true;
            return true;
        }
        return false;
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return this.parkingIntervals.Where(x => x.RegistrationPlate == registrationPlate).ToList();
    }

    public virtual double CalculateTotal()
    {
        return this.parkingIntervals.Sum(x => x.Revenue);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"> Parking Spot #{Id}");
        sb.AppendLine($"> Occupied: {Occupied}");
        sb.AppendLine($"> Type: {Type}");
        sb.AppendLine($"> Price per hour: {Price:f2} BGN");

        return sb.ToString().Trim();
    }

}