using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;

namespace MusicBeePlugin
{
    [DataContract]
    public class Settings
    {
        private static readonly Dictionary<string, string> defaults = new Dictionary<string, string>
        {
            { nameof(AlbumFormat), "%album%" },
            { nameof(ArtistFormat), "%artist%" },
            { nameof(TrackFormat), "%track%" },
        };

        private string filePath;

        [DataMember]
        private string albumFormat;

        [DataMember]
        private string artistFormat;

        [DataMember]
        private string trackFormat;

        [DataMember]
        private bool hookGlobalHotkeys = true;

        public string AlbumFormat
        {
            get => albumFormat ?? defaults[nameof(AlbumFormat)];
            set => SetIfChanged(ref albumFormat, value);
        }

        public string ArtistFormat
        {
            get => artistFormat ?? defaults[nameof(ArtistFormat)];
            set => SetIfChanged(ref artistFormat, value);
        }

        public string TrackFormat
        {
            get => trackFormat ?? defaults[nameof(TrackFormat)];
            set => SetIfChanged(ref trackFormat, value);
        }

        public bool HookGlobalHotkeys
        {
            get => hookGlobalHotkeys;
            set => SetIfChanged(ref hookGlobalHotkeys, value);
        }

        public bool IsDirty { get; private set; }

        public static Settings GetInstance(string filePath)
        {
            Settings newSettings;

            try
            {
                newSettings = Load(filePath);
            }
            catch (Exception ex) when (ex is IOException || ex is XmlException || ex is InvalidOperationException)
            {
                newSettings = new Settings();
            }

            newSettings.filePath = filePath;
            return newSettings;
        }

        public void Delete()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            var directoryPath = Path.GetDirectoryName(filePath);
            Directory.Delete(directoryPath);

            Reset();
        }

        public void Reset()
        {
            foreach (var setting in defaults.Keys)
            {
                var propertyInfo = GetType().GetProperties().First(x => x.Name == setting);
                propertyInfo.SetValue(this, null, null);
            }
        }

        public void Save()
        {
            if (!IsDirty)
            {
                return;
            }

            if (Path.GetDirectoryName(filePath) != null)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            using (var writer = XmlWriter.Create(filePath))
            {
                var serializer = new DataContractSerializer(typeof(Settings));
                serializer.WriteObject(writer, this);
                writer.Flush();
            }
        }

        private static Settings Load(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                var serializer = new DataContractSerializer(typeof(Settings));
                return serializer.ReadObject(stream) as Settings;
            }
        }

        private void SetIfChanged<T>(ref T backingField, T value)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return;
            }

            backingField = value;
            IsDirty = true;
        }
    }
}