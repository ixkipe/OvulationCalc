namespace OvulationCalc.Models;

public class OFDCentile : ICentile, IGestage {
  public int Gestage { get; set; }
  public string Centile { get; set; }
  public float Ofd { get; set; }
}