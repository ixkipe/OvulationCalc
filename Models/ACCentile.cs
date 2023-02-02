namespace OvulationCalc.Models;

public class ACCentile : ICentile, IGestage {
  public int Gestage { get; set; }
  public string Centile { get; set; }
  public float Ac { get; set; }
}