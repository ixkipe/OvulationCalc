namespace OvulationCalc.Models;

public class BPDCentile : ICentile, IGestage {
  public int Gestage { get; set; }
  public string Centile { get; set; }
  public float Bpd { get; set; }
}