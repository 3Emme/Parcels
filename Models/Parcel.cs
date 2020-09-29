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
    
    public Parcel (int weight, int height, int length)
    {
      int volume = Volume;
      

    }
  }
}