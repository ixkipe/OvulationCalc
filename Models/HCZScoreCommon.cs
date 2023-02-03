namespace OvulationCalc.Models;

public class HCZScoreCommon : IGestage, IZScore {
  public int Gestage { get; set; }
  public string Sd { get; set; }
  public float Hc { get; set; }
}