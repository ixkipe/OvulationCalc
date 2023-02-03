using OvulationCalc.Models;
using System.Diagnostics;

namespace OvulationCalc;

public static class HCMapper {
  public static IEnumerable<HCCentileCommon> MapCentileToCommon(this HCCentile obj) {
    yield return new HCCentileCommon() {
      Gestage = obj.Week,
      Centile = "3rd",
      Hc = obj.Third
    };
    yield return new HCCentileCommon() {
      Gestage = obj.Week,
      Centile = "5th",
      Hc = obj.Fifth
    };
    yield return new HCCentileCommon() {
      Gestage = obj.Week,
      Centile = "10th",
      Hc = obj.Tenth
    };
    yield return new HCCentileCommon() {
      Gestage = obj.Week,
      Centile = "50th",
      Hc = obj.Fiftieth
    };
    yield return new HCCentileCommon() {
      Gestage = obj.Week,
      Centile = "90th",
      Hc = obj.Ninetieth
    };
    yield return new HCCentileCommon() {
      Gestage = obj.Week,
      Centile = "95th",
      Hc = obj.NinetyFifth
    };
    yield return new HCCentileCommon() {
      Gestage = obj.Week,
      Centile = "97th",
      Hc = obj.NinetySeventh
    };
  }

  public static IEnumerable<HCCentileCommon> MapCentileToCommon(this IEnumerable<HCCentile> obj) {
    foreach (var value in obj) foreach (var result in value.MapCentileToCommon()) yield return result;
  }

  public static IEnumerable<HCZScoreCommon> MapZScoreToCommon(this HCZScore obj) {
    yield return new HCZScoreCommon() {
      Gestage = obj.Week,
      Sd = "-3SD",
      Hc = obj.NegativeThree
    };
    yield return new HCZScoreCommon() {
      Gestage = obj.Week,
      Sd = "-2SD",
      Hc = obj.NegativeTwo
    };
    yield return new HCZScoreCommon() {
      Gestage = obj.Week,
      Sd = "-1SD",
      Hc = obj.NegativeOne
    };
    yield return new HCZScoreCommon() {
      Gestage = obj.Week,
      Sd = "0",
      Hc = obj.Zero
    };
    yield return new HCZScoreCommon() {
      Gestage = obj.Week,
      Sd = "1SD",
      Hc = obj.One
    };
    yield return new HCZScoreCommon() {
      Gestage = obj.Week,
      Sd = "2SD",
      Hc = obj.Two
    };
    yield return new HCZScoreCommon() {
      Gestage = obj.Week,
      Sd = "3SD",
      Hc = obj.Three
    };
  }

  public static IEnumerable<HCZScoreCommon> MapZScoreToCommon(this IEnumerable<HCZScore> obj) {
    foreach (var value in obj) foreach (var result in value.MapZScoreToCommon()) yield return result;
  }
}