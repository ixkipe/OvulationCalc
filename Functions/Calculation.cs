using MathNet.Numerics.Distributions;
using OvulationCalc.Consts;

namespace OvulationCalc;

public static class Calculation {

  public static KeyValuePair<double, double> HCResult(this ReadOnlySpan<double> values, int millimeters) {
    var zScore = (millimeters - (HC.MedianValue1 + HC.MedianValue2 * values[0] - HC.MedianValue3 * values[0] * values[2])) / (HC.StdDevValue1 + HC.StdDevValue2 * values[1] - HC.StdDevValue3 * values[1] * values[2] + HC.StdDevValue4 * values[1] * Math.Pow(values[2], 2d));

    return new(zScore, Normal.CDF(0, 1, zScore) * 100);
  }

  public static KeyValuePair<double, double> BPDResult(this ReadOnlySpan<double> values, int millimeters) {
    var zScore = (millimeters - (BPD.MedianValue1 + BPD.MedianValue2 * values[0] - BPD.MedianValue3 * values[1])) / Math.Exp(BPD.StdDevValue1 + BPD.StdDevValue2 * values[1] - BPD.StdDevValue3 * values[1] * values[2] + BPD.StdDevValue4 * values[1] * Math.Pow(values[2], 2d));

    return new(zScore, Normal.CDF(0, 1, zScore) * 100);
  }

  public static KeyValuePair<double, double> ACResult(this ReadOnlySpan<double> values, int millimeters) {
    var zScore = (millimeters - (AC.MedianValue1 + AC.MedianValue2 * values[3] - AC.MedianValue3 * values[1])) / (AC.StdDevValue1 + AC.StdDevValue2 * values[0] - AC.StdDevValue3 * values[1] + AC.StdDevValue4 * values[1] * values[2]);

    return new(zScore, Normal.CDF(0, 1, zScore) * 100);
  }

  public static KeyValuePair<double, double> FLResult(this ReadOnlySpan<double> values, int millimeters) {
    var zScore = (millimeters - (FL.MedianValue1 + FL.MedianValue2 * values[3] - FL.MedianValue3 * values[0])) / Math.Exp(FL.StdDevValue1 - FL.StdDevValue2 * Math.Pow(values[3], -2d) + FL.StdDevValue3 * values[1]);

    return new(zScore, Normal.CDF(0, 1, zScore) * 100);
  }

  public static KeyValuePair<double, double> OFDResult(this ReadOnlySpan<double> values, int millimeters) {
    var zScore = (millimeters - (OFD.MedianValue1 + OFD.MedianValue2 * values[0] - OFD.MedianValue3 * values[0] * values[2])) / Math.Exp(OFD.StdDevValue1 + OFD.StdDevValue2 * values[0] - OFD.StdDevValue3 * values[0] * values[2] + OFD.StdDevValue4 * values[0] * Math.Pow(values[2], 2d));

    return new(zScore, Normal.CDF(0, 1, zScore) * 100);
  }
}