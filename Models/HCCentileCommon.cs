namespace OvulationCalc.Models;

public class HCCentileCommon : ICentile, IGestage {
  public int Gestage { get; set; }
  public string Centile { get; set; }
  public float Hc { get; set; }
}