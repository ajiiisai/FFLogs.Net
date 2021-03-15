# FFLogsAPI
[![Build, test and publish](https://github.com/Shiroifuyu/FFLogsAPI/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Shiroifuyu/FFLogsAPI/actions/workflows/dotnet.yml)

A WIP FFLogs API implementation for .NET 5

## Usage
Generate client:
```csharp
var client = new FFLogsClient("FFLOGS_API_KEY");
```
You can generate your API key [here](https://www.fflogs.com/profile).

### Zones
```csharp
// Get all zones
var zones = await client.GetZonesAsync();

// Get all Eden's Verse encounters
var encounter = zones.FirstOrDefault(x=>x.Name = "Eden's Verse")?.Encounters;

// Get Ramuh encounter ID
var ramuhId = zones.FirstOrDefault(x=>x.Name = "Eden's Verse")?.Encounters
  .FirstOrDefault(x=>x.Name = "Ramuh")?.Id;
```
### Jobs
```csharp
// Get all jobs
var jobs = await client.GetJobsAsync();

// Get Black Mage job Id
var blmId = jobs.FirstOrDefault(x=> x.Name == "Black Mage")?.Id;

// Get job name of the job with Id: 8
var jobName = jobs.FirstOrDefault(x=> x.Id == 8)?.Name; // Returns Ninja
```

### Rankings
Encounter rankings
```csharp
// Get Ramuh encounter ID
var zones = await client.GetZonesAsync();
var ramuhId = zones.FirstOrDefault(x=>x.Name = "Eden's Verse")?.Encounters
  .FirstOrDefault(x=>x.Name = "Ramuh")?.Id;
  
// Get all rankings from that fight
var encounterRankings = await client.GetEncounterRankingsAsync(ramuhId);
```
Character rankings
```csharp
// Get all rankings from a specific character
var characterRankings = await client.GetCharacterRankingsAsync("Ame Aghalair", Server.Europe.Chaos.Ragnarok);
```

### Parses
```csharp
// Get all parses from a specific character
var characterParses = await client.GetCharacterParsesAsync("Ame Aghalair", Server.Europe.Chaos.Ragnarok);
```

### Reports
Guild reports
```csharp
// Get all reports from a specific guild
var guildReports = await client.GetGuildReportsAsync("EXPLOSION MAGIC", Server.Europe.Chaos.Cerberus);
```
User reports
```csharp
// Get all reports from a specific user on FFLogs
var userReports = await client.GetUserReportsAsync("userName");
```
