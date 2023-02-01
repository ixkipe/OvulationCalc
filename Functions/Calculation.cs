using MathNet.Numerics.Distributions;
using OvulationCalc.Consts;

namespace OvulationCalc;

public static class Calculation {
  public static KeyValuePair<double, double> ZIndexAndCentile(this InputDTO input, InputType type) {
    switch (type) {
      case InputType.HC:
        return input.HCResult();
      case InputType.BPD:
        return input.BPDResult();
      case InputType.AC:
        return input.ACResult();
      case InputType.FL:
        return input.FLResult();
      case InputType.OFD:
        return input.OFDResult();

      default:
        throw new ArgumentException("Unidentified value type.");
    }
  }

  private static KeyValuePair<double, double> HCResult(this InputDTO input) {
    var ga = input.Weeks + (input.Days / 7d);
    ReadOnlySpan<double> values = new ReadOnlySpan<double>(array: new[] {Math.Pow(ga, 2d), Math.Pow(ga, 3d), Math.Log(ga)});

    var zScore = (input.Millimeters - (HC.MedianValue1 + HC.MedianValue2 * values[0] - HC.MedianValue3 * values[0] * values[2])) / (HC.StdDevValue1 + HC.StdDevValue2 * values[1] - HC.StdDevValue3 * values[1] * values[2] + HC.StdDevValue4 * values[1] * Math.Pow(values[2], 2d));

    return new(zScore, Normal.CDF(0, 1, zScore) * 100);
  }

  private static KeyValuePair<double, double> BPDResult(this InputDTO input) => throw new NotImplementedException();

  private static KeyValuePair<double, double> ACResult(this InputDTO input) => throw new NotImplementedException();

  private static KeyValuePair<double, double> FLResult(this InputDTO input) => throw new NotImplementedException();

  private static KeyValuePair<double, double> OFDResult(this InputDTO input) => throw new NotImplementedException();
}