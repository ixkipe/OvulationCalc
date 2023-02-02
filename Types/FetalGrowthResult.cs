using MathNet.Numerics.Distributions;
using OvulationCalc.Consts;

namespace OvulationCalc;

public class FetalGrowthResult {
  public double Weeks { get; }
  public double Days { get; }
  public KeyValuePair<double, double> HC { get; }
  public KeyValuePair<double, double> BPD { get; }
  public KeyValuePair<double, double> AC { get; }
  public KeyValuePair<double, double> FL { get; }
  public KeyValuePair<double, double> OFD { get; }

  public FetalGrowthResult(
    double weeks,
    double days,
    int? headCircumference = null,
    int? biparietalDiameter = null,
    int? occipitofrontalDiameter = null,
    int? abdominalCircumference = null,
    int? femurLength = null
  )
  {
    this.Weeks = weeks;
    this.Days = days;

    var ga = weeks + (days / 7d);
    var computationValues = new ReadOnlySpan<double>(new[] {
      Math.Pow(ga, 2d),
      Math.Pow(ga, 3d),
      Math.Log(ga),
      ga
    });

    this.HC = headCircumference is null ? new(0d, 0d) : computationValues.HCResult((int)headCircumference);
    this.BPD = biparietalDiameter is null ? new(0d, 0d) : computationValues.BPDResult((int)biparietalDiameter);
    this.AC = abdominalCircumference is null ? new(0d, 0d) : computationValues.ACResult((int)abdominalCircumference);
    this.FL = femurLength is null ? new(0d, 0d) : computationValues.FLResult((int)femurLength);
    this.OFD = occipitofrontalDiameter is null ? new(0d, 0d) : computationValues.OFDResult((int)occipitofrontalDiameter);
  }
}