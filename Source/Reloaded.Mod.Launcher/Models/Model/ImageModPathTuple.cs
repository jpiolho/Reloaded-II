﻿using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Loader.IO;
using Reloaded.Mod.Loader.IO.Config;

namespace Reloaded.Mod.Launcher.Models.Model
{
    public class ImageModPathTuple
    {
        private static readonly ConfigReader<ModConfig> ConfigReader = new ConfigReader<ModConfig>();

        /// <summary>
        /// The URI of the image used to represent the mod by in the GUI.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// The application configuration.
        /// </summary>
        public IModConfig ModConfig { get; set; }

        /// <summary>
        /// The full path to the application configuration file.
        /// </summary>
        public string ModConfigPath { get; set; }

        public ImageModPathTuple(string image, IModConfig modConfig, string modConfigPath)
        {
            Image = image;
            ModConfig = modConfig;
            ModConfigPath = modConfigPath;
        }

        public void Save()
        {
            ConfigReader.WriteConfiguration(ModConfigPath, (ModConfig)ModConfig);
        }

        public override string ToString()
        {
            return ModConfig.ModName;
        }

        /* Autogenerated by R# */
        protected bool Equals(ImageModPathTuple other)
        {
            return Equals(ModConfig, other.ModConfig) && 
                   string.Equals(ModConfigPath, other.ModConfigPath);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ImageModPathTuple)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (ModConfig != null ? ModConfig.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ModConfigPath != null ? ModConfigPath.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
