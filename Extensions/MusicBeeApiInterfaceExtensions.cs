using System.Text.RegularExpressions;

namespace MusicBeePlugin.Extensions
{
    public static class MusicBeeApiInterfaceExtensions
    {
        public static string GetFormattedString(this Plugin.MusicBeeApiInterface mbApiInterface, string input)
        {
            if (string.IsNullOrWhiteSpace(mbApiInterface.NowPlaying_GetFileUrl()))
            {
                return "";
            }

            var output = input;

            // Find all placeholders
            var r = new Regex(@"%(\w+)%");
            var match = r.Match(input);

            while (match.Success)
            {
                var placeholder = match.Groups[1].Value;
                output = output.Replace($"%{placeholder}%", GetValueForPlaceholder(mbApiInterface, placeholder));

                match = match.NextMatch();
            }

            return output;
        }

        private static string GetValueForPlaceholder(Plugin.MusicBeeApiInterface mbApiInterface, string placeholder)
        {
            Plugin.MetaDataType tagType;

            switch (placeholder.ToLowerInvariant())
            {
                case "album":
                    tagType = Plugin.MetaDataType.Album;
                    break;

                case "albumartist":
                    tagType = Plugin.MetaDataType.AlbumArtist;
                    break;

                case "artist":
                    tagType = Plugin.MetaDataType.Artist;
                    break;

                case "disccount":
                    tagType = Plugin.MetaDataType.DiscCount;
                    break;

                case "discno":
                    tagType = Plugin.MetaDataType.DiscNo;
                    break;

                case "genre":
                    tagType = Plugin.MetaDataType.Genre;
                    break;

                case "track":
                    tagType = Plugin.MetaDataType.TrackTitle;
                    break;

                case "trackcount":
                    tagType = Plugin.MetaDataType.TrackCount;
                    break;

                case "trackno":
                    tagType = Plugin.MetaDataType.TrackNo;
                    break;

                case "year":
                    tagType = Plugin.MetaDataType.Year;
                    break;

                default:
                    return $"<UNSUPPORTED_PLACEHOLDER_{placeholder}>";
            }

            return mbApiInterface.NowPlaying_GetFileTag(tagType);
        }
    }
}