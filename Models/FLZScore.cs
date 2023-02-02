namespace OvulationCalc.Models;

public class FLZScore : IGestage, IZScore {
  public int Gestage { get; set; }
  public string Sd { get; set; }
  public float Fl { get; set; }
}