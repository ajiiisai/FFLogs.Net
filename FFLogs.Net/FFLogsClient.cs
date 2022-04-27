using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using FFLogs.Net.Models.Classes;
using FFLogs.Net.Models.Helpers;
using FFLogs.Net.Models.Parses;
using FFLogs.Net.Models.Rankings;
using FFLogs.Net.Models.Reports;
using FFLogs.Net.Models.Zones;

namespace FFLogs.Net
{
    public class FFLogsClient : IDisposable
    {
        
        
        public void Dispose() => _client.Dispose();

        #region Consturctor

        private readonly string _apiKey;
        private readonly string _apiRootUrl;

        public FFLogsClient(string apiKey,string ApiRootUrl = "https://www.fflogs.com:443/v1") {
            _apiKey = apiKey;
            _apiRootUrl = ApiRootUrl;
        }

        #endregion
        
        #region Client
        
        private readonly HttpClient _client = new HttpClient();

        #endregion

        #region Urls

        protected virtual string ApiRootUrl => _apiRootUrl;

        private static string GetQuery<T>(T options)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);
            foreach(PropertyInfo i in properties)
            {
                var value = i.GetValue(options);
                if (value!= null)
                {
                    query[i.Name.ToLower()] = value.ToString();
                }
                
            }
            return query.ToString();
        }
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
            string json = await _client.GetStringAsync(rootUrl);
            return JsonSerializer.Deserialize<TOutput>(json);
        }
        
        protected virtual async Task<Job[]> GetJobData<TOutput>(string rootUrl)
        {
            string json = await _client.GetStringAsync(rootUrl);
            return (JsonSerializer.Deserialize<Class[]>(json) ?? Array.Empty<Class>()).FirstOrDefault()?.Jobs;
        }

        #endregion

        #region Zones

        public virtual Task<Zone[]> GetZonesAsync()
        {
            string url = GetZonesUrl();
            return GetData<Zone[]>(url);
        }

        #endregion
        
        #region Jobs

        public virtual Task<Job[]> GetJobsAsync()
        {
            string url = GetJobsUrl();
            return GetJobData<Class[]>(url);
        }

        #endregion

        #region Rankings

        public virtual Task<EncounterRankings> GetEncounterRankingsAsync(int encounterId)
        {
            string url = GetEncounterRankingsUrl(encounterId);
            return GetData<EncounterRankings>(url);
        }
        
        public virtual Task<CharacterRankings[]> GetCharacterRankingsAsync(string characterName, ServerObject server)
        {
            string url = GetCharacterRankingsUrl(characterName, server.ServerName, server.ServerRegion);
            return GetData<CharacterRankings[]>(url);
        }
        public virtual Task<CharacterRankings[]> GetCharacterRankingsAsync(string characterName, ServerObject server,RankingOptions options)
        {
            string url = GetCharacterRankingsUrl(characterName, server.ServerName, server.ServerRegion);
            return GetData<CharacterRankings[]>($"{url}&{GetQuery(options)}");
        }
        #endregion

        #region Parses

        public virtual Task<Parses[]> GetCharacterParsesAsync(string characterName, ServerObject server)
        {
            string url = GetCharacterParsesUrl(characterName, server.ServerName, server.ServerRegion);
            return GetData<Parses[]>(url);
        }
        public virtual Task<Parses[]> GetCharacterParsesAsync(string characterName, ServerObject server, ParsesOptions options)
        {
            string url = GetCharacterParsesUrl(characterName, server.ServerName, server.ServerRegion);
            return GetData<Parses[]>($"{url}&{GetQuery(options)}");
        }

        #endregion

        #region Reports

        public virtual Task<Reports[]> GetGuildReportsAsync(string guildName, ServerObject server)
        {
            string url = GetGuildReportsUrl(guildName, server.ServerName, server.ServerRegion);
            return GetData<Reports[]>(url);
        }
        
        public virtual Task<Reports[]> GetUserReportsAsync(string userName)
        {
            string url = GetUserReportsUrl(userName);
            return GetData<Reports[]>(url);
        }

        #endregion

        #region Report
        public virtual Task<ReportsTables> GetReportsTables(string view, string code, ReportsTablesOptions options)
        {
            string url = $"{ApiRootUrl}/report/table/{code}/{view}/?api_key={_apiKey}&{GetQuery(options)}";
            return GetData<ReportsTables>(url);
        }
        #endregion
    }
}