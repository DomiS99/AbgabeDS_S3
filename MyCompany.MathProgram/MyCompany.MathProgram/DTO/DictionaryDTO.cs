namespace MyCompany.MathProgram.DTO
{

    
        namespace QuickType
    {

        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public class DictionaryDTO
        {
            [JsonProperty("word")]
            public string Word { get; set; }

            [JsonProperty("phonetic")]
            public string Phonetic { get; set; }

            [JsonProperty("phonetics")]
            public Phonetic[] Phonetics { get; set; }

            [JsonProperty("meanings")]
            public Meaning[] Meanings { get; set; }

            [JsonProperty("license")]
            public License License { get; set; }

            [JsonProperty("sourceUrls")]
            public Uri[] SourceUrls { get; set; }
        }

        public partial class License
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }
        }

        public partial class Meaning
        {
            [JsonProperty("partOfSpeech")]
            public string PartOfSpeech { get; set; }

            [JsonProperty("definitions")]
            public Definition[] Definitions { get; set; }

            [JsonProperty("synonyms")]
            public string[] Synonyms { get; set; }

            [JsonProperty("antonyms")]
            public object[] Antonyms { get; set; }
        }

        public partial class Definition
        {
            [JsonProperty("definition")]
            public string DefinitionDefinition { get; set; }

            [JsonProperty("synonyms")]
            public string[] Synonyms { get; set; }

            [JsonProperty("antonyms")]
            public object[] Antonyms { get; set; }

            [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
            public string Example { get; set; }
        }

        public partial class Phonetic
        {
            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("audio")]
            public Uri Audio { get; set; }

            [JsonProperty("sourceUrl")]
            public Uri SourceUrl { get; set; }

            [JsonProperty("license")]
            public License License { get; set; }
        }

        public partial class Welcome
        {
            public static Welcome[] FromJson(string json) => JsonConvert.DeserializeObject<Welcome[]>(json, QuickType.Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this Welcome[] self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }
    }
}




