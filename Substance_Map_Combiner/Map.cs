using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace Substance_Map_Combiner
{
    public class Map
    {
        [JsonIgnore]
        public bool IsSelected { get; set; }
        [JsonProperty("suffixes")]
        public List<string> Suffixes { get; set; }
        [JsonProperty ("default_suffix")]
        public string DefaultSuffix { get; set; }
        [JsonProperty ("output_suffix")]
        public string OutputSuffix { get; set; }
        [JsonProperty ("background_color")]
        public Color BackgroundColor { get; set;}
        [JsonProperty("default_background_color")]
        public Color DefaultBackgroundColor { get; set; }

        public Map ()
        {
            IsSelected = false;
            Suffixes = new List<string> ();
        }

        public void Reset ()
        {
            Suffixes.Clear ();
            Suffixes.Add (DefaultSuffix);
            OutputSuffix = DefaultSuffix;
        }

        public Map Clone (Map map)
        {
            return new Map
            {
                IsSelected = this.IsSelected,
                Suffixes = this.Suffixes,
                DefaultSuffix = this.DefaultSuffix,
                OutputSuffix = this.OutputSuffix,
                BackgroundColor = this.BackgroundColor
            };
        }
    }
}
