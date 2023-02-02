namespace OvulationCalc.Models;

public class OFDZScore : IGestage, IZScore {
  public int Gestage { get; set; }
  public string Sd { get; set; }
  public float Ofd { get; set; }
}