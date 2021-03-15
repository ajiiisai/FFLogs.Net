using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FFLogsAPI.Models.Classes;
using FFLogsAPI.Models.Helpers;
using FFLogsAPI.Models.Parses;
using FFLogsAPI.Models.Rankings;
using FFLogsAPI.Models.Reports;
using FFLogsAPI.Models.Zones;

namespace FFLogsAPI
{
    public class FFLogsClient : IDisposable
    {

        #region Consturctor

        private string _apiKey;
        public FFLogsClient(string apiKey) => _apiKey = apiKey;

        #endregion
        
        #region Client
        
        private readonly HttpClient _client = new HttpClient();
        
        #endregion

        #region Urls

        protected virtual string ApiRootUrl => "https://www.fflogs.com:443/v1";

        #endregion

        #region Data urls

        protected virtual string GetZonesUrl()
        {
            return $"{ApiRootUrl}/zones/?api_key={_apiKey}";
        }
        
        protected virtual string GetJobsUrl()
        {
            return $"{ApiRootUrl}/classes/?api_key={_apiKey}";
        }
        
        protected virtual string GetEncounterRankingsUrl(int encounterId)
        {
            return $"{ApiRootUrl}/rankings/encounter/{encounterId}/?api_key={_apiKey}";
        }
        
        protected virtual string GetCharacterRankingsUrl(string characterName, string serverName, string serverRegion)
        {
            return $"{ApiRootUrl}/rankings/character/{characterName}/{serverName}/{serverRegion}/?api_key={_apiKey}";
        }
        
        protected virtual string GetCharacterParsesUrl(string characterName, string serverName, string serverRegion)
        {
            return $"{ApiRootUrl}/parses/character/{characterName}/{serverName}/{serverRegion}/?api_key={_apiKey}";
        }
        
        protected virtual string GetGuildReportsUrl(string guildName, string serverName, string serverRegion)
        {
            return $"{ApiRootUrl}/reports/guild/{guildName}/{serverName}/{serverRegion}/?api_key={_apiKey}";
        }
        
        protected virtual string GetUserReportsUrl(string userName)
        {
            return $"{ApiRootUrl}/reports/user/{userName}/?api_key={_apiKey}";
        }

        #endregion

        #region Utilities

        protected virtual async Task<TOutput> GetData<TOutput>(string rootUrl)
        {
            try
            {
                var json = await _client.GetStringAsync(rootUrl);
                return JsonSerializer.Deserialize<TOutput>(json);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        protected virtual async Task<Job[]> GetJobData<TOutput>(string rootUrl)
        {
            try
            {
                var json = await _client.GetStringAsync(rootUrl);
                return JsonSerializer.Deserialize<Class[]>(json).FirstOrDefault()?.Jobs;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region Zones

        public virtual Task<Zone[]> GetZonesAsync()
        {
            var url = GetZonesUrl();
            return GetData<Zone[]>(url);
        }

        #endregion
        
        #region Jobs

        public virtual Task<Job[]> GetJobsAsync()
        {
            var url = GetJobsUrl();
            return GetJobData<Class[]>(url);
        }

        #endregion

        #region Rankings

        public virtual Task<EncounterRankings> GetEncounterRankingsAsync(int encounterId)
        {
            var url = GetEncounterRankingsUrl(encounterId);
            return GetData<EncounterRankings>(url);
        }
        
        public virtual Task<CharacterRankings[]> GetCharacterRankingsAsync(string characterName, ServerObject server)
        {
            var url = GetCharacterRankingsUrl(characterName, server.ServerName, server.ServerRegion);
            return GetData<CharacterRankings[]>(url);
        }

        #endregion

        #region Parses

        public virtual Task<Parses[]> GetCharacterParsesAsync(string characterName, ServerObject server)
        {
            var url = GetCharacterParsesUrl(characterName, server.ServerName, server.ServerRegion);
            return GetData<Parses[]>(url);
        }

        #endregion

        #region Reports

        public virtual Task<Reports[]> GetGuildReportsAsync(string guildName, ServerObject server)
        {
            var url = GetGuildReportsUrl(guildName, server.ServerName, server.ServerRegion);
            return GetData<Reports[]>(url);
        }
        
        public virtual Task<Reports[]> GetUserReportsAsync(string userName)
        {
            var url = GetUserReportsUrl(userName);
            return GetData<Reports[]>(url);
        }

        #endregion
        

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}