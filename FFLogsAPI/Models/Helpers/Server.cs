using System;

namespace FFLogsAPI.Models.Helpers
{
    public class ServerObject
    {
        public string ServerName { get; set;}
        public string ServerRegion { get; set;}
    }
    public static class Server
    {
        public static class Europe
        {
            public static class Chaos
            {
                public static ServerObject Cerberus = new ServerObject() { ServerName = "Cerberus", ServerRegion = "eu"};
                public static ServerObject Louisoix = new ServerObject() { ServerName = "Louisoix", ServerRegion = "eu" };
                public static ServerObject Moogle = new ServerObject() { ServerName= "Moogle", ServerRegion = "eu" };
                public static ServerObject Omega = new ServerObject() { ServerName = "Omega", ServerRegion = "eu" };
                public static ServerObject Ragnarok = new ServerObject(){ ServerName = "Ragnarok", ServerRegion ="eu" };
                public static ServerObject Spriggan = new ServerObject() { ServerName= "Spriggan", ServerRegion= "eu" };
            }
            
            public static class Light
            {
                public static ServerObject Lich = new ServerObject() { ServerName = "Lich", ServerRegion = "eu"};
                public static ServerObject Odin = new ServerObject() { ServerName = "Odin", ServerRegion = "eu" };
                public static ServerObject Phoenix = new ServerObject() { ServerName= "Phoenix", ServerRegion = "eu" };
                public static ServerObject Shiva = new ServerObject() { ServerName = "Shiva", ServerRegion = "eu" };
                public static ServerObject Twintania = new ServerObject(){ ServerName = "Twintania", ServerRegion ="eu" };
                public static ServerObject Zodiark = new ServerObject() { ServerName= "Zodiark", ServerRegion= "eu" };
            }
        }
    }
    
    public static class NorthAmerica
    {
        public static class Aether
        {
            public static ServerObject Adamantoise = new ServerObject() { ServerName = "Adamantoise", ServerRegion = "na"};
            public static ServerObject Cactuar = new ServerObject() { ServerName = "Cactuar", ServerRegion = "na" };
            public static ServerObject Faerie = new ServerObject() { ServerName = "Faerie", ServerRegion = "na" };
            public static ServerObject Gilgamesh = new ServerObject() { ServerName= "Gilgamesh", ServerRegion = "na" };
            public static ServerObject Jenova = new ServerObject() { ServerName = "Jenova", ServerRegion = "na" };
            public static ServerObject Midgardsormr = new ServerObject(){ ServerName = "Midgardsormr", ServerRegion ="na" };
            public static ServerObject Sargatanas = new ServerObject() { ServerName= "Sargatanas", ServerRegion= "na" };
            public static ServerObject Siren = new ServerObject() { ServerName= "Siren", ServerRegion= "na" };
        }
        
        public static class Primal
        {
            public static ServerObject Behemoth = new ServerObject() { ServerName = "Behemoth", ServerRegion = "na"};
            public static ServerObject Excalibur = new ServerObject() { ServerName = "Excalibur", ServerRegion = "na" };
            public static ServerObject Exodus = new ServerObject() { ServerName= "Exodus", ServerRegion = "na" };
            public static ServerObject Famfrit = new ServerObject() { ServerName = "Famfrit", ServerRegion = "na" };
            public static ServerObject Hyperion = new ServerObject(){ ServerName = "Hyperion", ServerRegion ="na" };
            public static ServerObject Lamia = new ServerObject() { ServerName= "Lamia", ServerRegion= "na" };
            public static ServerObject Leviathan = new ServerObject() { ServerName= "Leviathan", ServerRegion= "na" };
            public static ServerObject Ultros = new ServerObject() { ServerName= "Ultros", ServerRegion= "na" };
        }
        
        public static class Crystal
        {
            public static ServerObject Balmung = new ServerObject() { ServerName = "Balmung", ServerRegion = "na"};
            public static ServerObject Brynhildr = new ServerObject() { ServerName = "Brynhildr", ServerRegion = "na" };
            public static ServerObject Coeurl = new ServerObject() { ServerName= "Coeurl", ServerRegion = "na" };
            public static ServerObject Diabolos = new ServerObject() { ServerName = "Diabolos", ServerRegion = "na" };
            public static ServerObject Goblin = new ServerObject(){ ServerName = "Goblin", ServerRegion ="na" };
            public static ServerObject Malboro = new ServerObject() { ServerName= "Malboro", ServerRegion= "na" };
            public static ServerObject Mateus = new ServerObject() { ServerName= "Mateus", ServerRegion= "na" };
            public static ServerObject Zalera = new ServerObject() { ServerName= "Zalera", ServerRegion= "na" };
        }
    }

    public static class Japan
    {
        public static class Crystal
        {
            public static ServerObject Aegis = new ServerObject() { ServerName = "Aegis", ServerRegion = "jp"};
            public static ServerObject Atomos = new ServerObject() { ServerName = "Atomos", ServerRegion = "jp"};
            public static ServerObject Carbuncle = new ServerObject() { ServerName = "Carbuncle", ServerRegion = "jp"};
            public static ServerObject Garuda = new ServerObject() { ServerName = "Garuda", ServerRegion = "jp"};
            public static ServerObject Gungnir = new ServerObject() { ServerName = "Gungnir", ServerRegion = "jp"};
            public static ServerObject Kujata = new ServerObject() { ServerName = "Kujata", ServerRegion = "jp"};
            public static ServerObject Ramuh = new ServerObject() { ServerName = "Ramuh", ServerRegion = "jp"};
            public static ServerObject Tonberry = new ServerObject() { ServerName = "Tonberry", ServerRegion = "jp"};
            public static ServerObject Typhon = new ServerObject() { ServerName = "Typhon", ServerRegion = "jp"};
            public static ServerObject Unicorn = new ServerObject() { ServerName = "Unicorn7", ServerRegion = "jp"};
        }
        
        public static class Gaia
        {
            public static ServerObject Alexander = new ServerObject() { ServerName = "Alexander", ServerRegion = "jp"};
            public static ServerObject Bahamut = new ServerObject() { ServerName = "Bahamut", ServerRegion = "jp"};
            public static ServerObject Durandal = new ServerObject() { ServerName = "Durandal", ServerRegion = "jp"};
            public static ServerObject Fenrir = new ServerObject() { ServerName = "Fenrir", ServerRegion = "jp"};
            public static ServerObject Ifrit = new ServerObject() { ServerName = "Ifrit", ServerRegion = "jp"};
            public static ServerObject Ridill = new ServerObject() { ServerName = "Ridill", ServerRegion = "jp"};
            public static ServerObject Tiamat = new ServerObject() { ServerName = "Tiamat", ServerRegion = "jp"};
            public static ServerObject Ultima = new ServerObject() { ServerName = "Ultima", ServerRegion = "jp"};
            public static ServerObject Valefor = new ServerObject() { ServerName = "Valefor", ServerRegion = "jp"};
            public static ServerObject Yojimbo = new ServerObject() { ServerName = "Yojimbo", ServerRegion = "jp"};
            public static ServerObject Zeromus = new ServerObject() { ServerName = "Zeromus", ServerRegion = "jp"};
        }
        
        public static class Mana
        {
            public static ServerObject Anima = new ServerObject() { ServerName = "Anima", ServerRegion = "jp"};
            public static ServerObject Asura = new ServerObject() { ServerName = "Asura", ServerRegion = "jp"};
            public static ServerObject Belias = new ServerObject() { ServerName = "Belias", ServerRegion = "jp"};
            public static ServerObject Chocobo = new ServerObject() { ServerName = "Chocobo", ServerRegion = "jp"};
            public static ServerObject Hades = new ServerObject() { ServerName = "Hades", ServerRegion = "jp"};
            public static ServerObject Ixion = new ServerObject() { ServerName = "Ixion", ServerRegion = "jp"};
            public static ServerObject Mandragora = new ServerObject() { ServerName = "Mandragora", ServerRegion = "jp"};
            public static ServerObject Masamune = new ServerObject() { ServerName = "Masamune", ServerRegion = "jp"};
            public static ServerObject Pandaemonium = new ServerObject() { ServerName = "Pandaemonium", ServerRegion = "jp"};
            public static ServerObject Shinryu = new ServerObject() { ServerName = "Shinryu", ServerRegion = "jp"};
            public static ServerObject Titan = new ServerObject() { ServerName = "Titan", ServerRegion = "jp"};
        }
    }
}