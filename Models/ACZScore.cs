namespace OvulationCalc.Models;

public class ACZScore : IGestage, IZScore {
  public int Gestage { get; set; }
  public string Sd { get; set; }
  public float Ac { get; set; }
}