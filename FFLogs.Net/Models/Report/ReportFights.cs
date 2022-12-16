using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FFLogs.Net.Models.Report;

public class ReportFights
{
    [JsonPropertyName("fights")]
    public List<Fight> Fights { get; set; }

    [JsonPropertyName("lang")]
    public string Lang { get; set; }

    [JsonPropertyName("friendlies")]
    public List<Friendly> Friendlies { get; set; }

    [JsonPropertyName("enemies")]
    public List<Enemy> Enemies { get; set; }

    [JsonPropertyName("friendlyPets")]
    public List<FriendlyPet> FriendlyPets { get; set; }

    [JsonPropertyName("enemyPets")]
    public List<object> EnemyPets { get; set; }

    [JsonPropertyName("phases")]
    public List<Phase> Phases { get; set; }

    [JsonPropertyName("logVersion")]
    public int LogVersion { get; set; }

    [JsonPropertyName("gameVersion")]
    public int GameVersion { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    [JsonPropertyName("start")]
    public long Start { get; set; }

    [JsonPropertyName("end")]
    public long End { get; set; }

    [JsonPropertyName("zone")]
    public int Zone { get; set; }

    [JsonPropertyName("exportedCharacters")]
    public List<ExportedCharacter> ExportedCharacters { get; set; }
}

public class Map
{
    [JsonPropertyName("mapID")]
    public int MapID { get; set; }

    [JsonPropertyName("mapName")]
    public string MapName { get; set; }

    [JsonPropertyName("mapFile")]
    public string MapFile { get; set; }
}

public class Fight
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("boss")]
    public int Boss { get; set; }

    [JsonPropertyName("start_time")]
    public int StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public int EndTime { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("zoneID")]
    public int ZoneID { get; set; }

    [JsonPropertyName("zoneName")]
    public string ZoneName { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("difficulty")]
    public int Difficulty { get; set; }

    [JsonPropertyName("kill")]
    public bool Kill { get; set; }

    [JsonPropertyName("partial")]
    public int Partial { get; set; }

    [JsonPropertyName("inProgress")]
    public bool InProgress { get; set; }

    [JsonPropertyName("standardComposition")]
    public bool StandardComposition { get; set; }

    [JsonPropertyName("hasEcho")]
    public bool HasEcho { get; set; }

    [JsonPropertyName("bossPercentage")]
    public int BossPercentage { get; set; }

    [JsonPropertyName("fightPercentage")]
    public int FightPercentage { get; set; }

    [JsonPropertyName("lastPhaseAsAbsoluteIndex")]
    public int LastPhaseAsAbsoluteIndex { get; set; }

    [JsonPropertyName("lastPhaseForPercentageDisplay")]
    public int LastPhaseForPercentageDisplay { get; set; }

    [JsonPropertyName("maps")]
    public List<Map> Maps { get; set; }

    [JsonPropertyName("instances")]
    public int Instances { get; set; }

    [JsonPropertyName("groups")]
    public int? Groups { get; set; }
}

public class Friendly
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("guid")]
    public int Guid { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("server")]
    public string Server { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("fights")]
    public List<Fight> Fights { get; set; }
}

public class Enemy
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

    [JsonPropertyName("fights")]
    public List<Fight> Fights { get; set; }
}

public class FriendlyPet
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

    [JsonPropertyName("petOwner")]
    public int PetOwner { get; set; }

    [JsonPropertyName("fights")]
    public List<Fight> Fights { get; set; }
}

public class Phase
{
    [JsonPropertyName("boss")]
    public int Boss { get; set; }

    [JsonPropertyName("phases")]
    public List<string> Phases { get; set; }
}

public class ExportedCharacter
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("server")]
    public string Server { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }
}