using Newtonsoft.Json;
using OvulationCalc.Models;

namespace OvulationCalc;

public class DataDeserializer {
  public IEnumerable<HCCentile> HCCentileStandards { get; }
  public IEnumerable<HCZScore> HCZScoreStandards { get; }
  public IEnumerable<BPDCentile> BPDCentileStandards { get; }
  public IEnumerable<BPDZScore> BPDZScoreStandards { get; }
  public IEnumerable<ACCentile> ACCentileStandards { get; }
  public IEnumerable<ACZScore> ACZScoreStandards { get; }
  public IEnumerable<FLCentile> FLCentileStandards { get; }
  public IEnumerable<FLZScore> FLZScoreStandards { get; }
  public IEnumerable<OFDCentile> OFDCentileStandards { get; }
  public IEnumerable<OFDZScore> OFDZScoreStandards { get; }

  public DataDeserializer()
  {
    this.HCCentileStandards = JsonConvert.DeserializeObject<IEnumerable<HCCentile>>(File.ReadAllText(@"OvulationCalc\Data\hc_centile_new.json"));
    this.HCZScoreStandards = JsonConvert.DeserializeObject<IEnumerable<HCZScore>>(File.ReadAllText(@"OvulationCalc\Data\hc_zscores_new.json"));
    this.BPDCentileStandards = JsonConvert.DeserializeObject<IEnumerable<BPDCentile>>(File.ReadAllText(@"OvulationCalc\Data\bpd_gestage_centile.json"));
    this.BPDZScoreStandards = JsonConvert.DeserializeObject<IEnumerable<BPDZScore>>(File.ReadAllText(@"OvulationCalc\Data\bpd_gestage_sd.json"));
    this.ACCentileStandards = JsonConvert.DeserializeObject<IEnumerable<ACCentile>>(File.ReadAllText(@"OvulationCalc\Data\ac_gestage_centile.json"));
    this.ACZScoreStandards = JsonConvert.DeserializeObject<IEnumerable<ACZScore>>(File.ReadAllText(@"OvulationCalc\Data\ac_gestage_sd.json"));
    this.FLCentileStandards = JsonConvert.DeserializeObject<IEnumerable<FLCentile>>(File.ReadAllText(@"OvulationCalc\Data\fl_gestage_centile.json"));
    this.FLZScoreStandards = JsonConvert.DeserializeObject<IEnumerable<FLZScore>>(File.ReadAllText(@"OvulationCalc\Data\fl_gestage_sd.json"));
    this.OFDCentileStandards = JsonConvert.DeserializeObject<IEnumerable<OFDCentile>>(File.ReadAllText(@"OvulationCalc\Data\ofd_gestage_centile.json"));
    this.OFDZScoreStandards = JsonConvert.DeserializeObject<IEnumerable<OFDZScore>>(File.ReadAllText(@"OvulationCalc\Data\ofd_gestage_sd.json"));
  }
}