using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};
    
    public Parcel (int weight, int height, int length, int width)
    {
      Height = height;
      Width  = width;
      Length = length;
      Weight = weight;
      _instances.Add(this);
    }

    public int Volume(){
      return Length*Width*Height;
    }

    public double CostToShip(){
      double costPerMile = .50;
      double costToShip = Weight*costPerMile*this.Volume();
      return costToShip;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}