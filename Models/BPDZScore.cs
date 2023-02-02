namespace OvulationCalc.Models;

public class BPDZScore : IGestage, IZScore {
  public int Gestage { get; set; }
  public string Sd { get; set; }
  public float Bpd { get; set; }
}