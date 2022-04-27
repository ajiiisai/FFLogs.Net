using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FFLogs.Net.Models.Reports;
public class ReportsTables
{
    [JsonPropertyName("totalTime")]
    public int TotalTime { get; set; }

    [JsonPropertyName("itemLevel")]
    public int ItemLevel { get; set; }

    [JsonPropertyName("logVersion")]
    public int LogVersion { get; set; }

    [JsonPropertyName("gameVersion")]
    public int GameVersion { get; set; }

    [JsonPropertyName("composition")]
    public List<Composition> Composition { get; set; }

    [JsonPropertyName("damageDone")]
    public List<DamageDone> DamageDone { get; set; }

    [JsonPropertyName("healingDone")]
    public List<HealingDone> HealingDone { get; set; }

    [JsonPropertyName("damageTaken")]
    public List<DamageTaken> DamageTaken { get; set; }

    [JsonPropertyName("deathEvents")]
    public List<DeathEvent> DeathEvents { get; set; }
}


public class SpecRole
{
    [JsonPropertyName("spec")]
    public string Spec { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }
}

public class Composition
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("guid")]
    public int Guid { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("specs")]
    public List<SpecRole> Specs { get; set; }
}

public class DamageDone
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("guid")]
    public int Guid { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class HealingDone
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("guid")]
    public int Guid { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class DamageTaken
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("guid")]
    public int Guid { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("abilityIcon")]
    public string AbilityIcon { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class Ability
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("guid")]
    public int Guid { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("abilityIcon")]
    public string AbilityIcon { get; set; }
}

public class DeathEvent
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("guid")]
    public int Guid { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("deathTime")]
    public int DeathTime { get; set; }

    [JsonPropertyName("ability")]
    public Ability Ability { get; set; }
}
