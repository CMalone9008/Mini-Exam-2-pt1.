using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

  int radius = 0;
  int height = 0;
  double volume = 3.14;
  double cylVolume =0;
  

  Console.WriteLine("Enter the radius:");
  radius = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the height:");
  height = Convert.ToInt32(Console.ReadLine());
  cylVolume = volume*radius*radius*height;
  Console.WriteLine("The volume is: " + cylVolume);

  }
}