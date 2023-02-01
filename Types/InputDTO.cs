namespace OvulationCalc;

/// <summary>
/// Contains "gestage" value in the form of "Weeks" and "Days" properties; "Millimeters" represent the length of HC, BPD, AC, FL or OFD.
/// </summary>
public class InputDTO {
  public double Weeks { get; set; }
  public double Days { get; set; }
  public int Millimeters { get; set; }
}