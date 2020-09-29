using System.Collections.Generic;

namespace Parcel.Models
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
    }

    public int Volume(){
      return Length*Width*Height;
    }

    public Float CostToShip(){
      float costPerMile = .50;
      float costToship = Weight*costPerMile*this.Volume();
      return costToShip;
    }
  }
}