using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace Substance_Map_Combiner
{
    public class UserPreferences
    {
        [JsonProperty ("file_name")]
        public string ExportFileName = "Combined";
        [JsonProperty ("file_type")]
        public string ExportFileType = ".png";
        [JsonProperty ("maps")]
        public Dictionary<MapTypes, Map> Maps;

        public Map GetMap (MapTypes mapType)
        {
            return Maps[mapType];
        }

        public static string GetJSON (UserPreferences prefs)
        {
            string json = "";
            json = JsonConvert.SerializeObject (prefs, Formatting.Indented);

            return json;
        }
    }
}
