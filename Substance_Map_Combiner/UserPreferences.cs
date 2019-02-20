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
        public string ExportFileName = "Combined";
        public string ExportFileType = ".png";
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
