namespace OvulationCalc.Models;

public class FLCentile : ICentile, IGestage {
  public int Gestage { get; set; }
  public string Centile { get; set; }
  public float Fl { get; set; }
}