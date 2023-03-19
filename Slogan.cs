using Newtonsoft.Json;
using TMPro;
using UnityEngine;

namespace Slogans
{
    public class Slogan
    {
        [JsonProperty("text")]
        public TextSettings Text { get; set; }
        
        [JsonProperty("transform")]
        public TransformSettings Transform { get; set; }
        
        public class TextSettings
        {
            [JsonProperty("text")]
            public string Text { get; set; }
            
            [JsonProperty("fontStyle")]
            public FontStyles FontStyle { get; set; }

            [JsonProperty("fontSize")]
            public float FontSize { get; set; }
            
            [JsonProperty("color")]
            public Color Color { get; set; }
            
            [JsonProperty("useGradient")]
            public bool UseGradient { get; set; }
            
            [JsonProperty("colorMode")]
            public ColorMode ColorMode { get; set; }
            
            [JsonProperty("color0")]
            public Color Color0 { get; set; }
            
            [JsonProperty("color1")]
            public Color Color1 { get; set; }
            
            [JsonProperty("color2")]
            public Color Color2 { get; set; }
            
            [JsonProperty("color3")]
            public Color Color3 { get; set; }
            
            [JsonProperty("characterSpacing")]
            public float CharacterSpacing { get; set; }
            
            [JsonProperty("wordSpacing")]
            public float WordSpacing { get; set; }
            
            [JsonProperty("lineSpacing")]
            public float LineSpacing { get; set; }
          
        }

        public class TransformSettings
        {
            [JsonProperty("position")]
            public Vector3 Position { get; set; }
            
            [JsonProperty("rotation")]
            public Vector3 Rotation { get; set; }
        }
    }
}