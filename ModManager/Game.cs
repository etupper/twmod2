using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModManager
{
    public class Game
    {
        // C:\Program Files (x86)\Steam\steamapps\common\Total War Rome II\Rome2.exe
        // 64-bit: HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall
        // 32-bit: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall
        // Steam App Key: \Steam App 214950

        public string NAME = "Total War: ROME II";
        public string EXE = "Rome2.exe";
        public string STEAM_APPID = "214950";
        public string REGISTRY_KEY_64 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 214950";
        public string REGISTRY_KEY_32 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 214950";
        //public const string REGISTRY_INSTALL_VALUE = "InstallLocation";
        //public const string REGISTRY_NAME_VALUE = "DisplayName";
        //public const string REGISTRY_ICON_VALUE = "DisplayIcon";

        private string _path = "";
        private string _steamPath = "";
        private bool _running = false;

        public Game()
        {
        }

        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }
        
        public string FullPath
        {
            get
            {
                return System.IO.Path.Combine(_path, EXE);
            }
        }

        public string SteamPath
        {
            get
            {
                return _steamPath;
            }
            set
            {
                _steamPath = value;
            }
        }

        public bool Running
        {
            get
            {
                return _running;
            }
            set
            {
                _running = value;
            }
        }

        public void GetGameDirectory()
        {
            _path = (string)Microsoft.Win32.Registry.GetValue(REGISTRY_KEY_64, "InstallLocation", "");

            if (String.IsNullOrEmpty(_path))
            {
                _path = (string)Microsoft.Win32.Registry.GetValue(REGISTRY_KEY_32, "InstallLocation", "");
            }
        }

        public void GetSteamDirectory()
        {
            _steamPath = (string)Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", "");

            if (String.IsNullOrEmpty(_steamPath))
            {
                _steamPath = (string)Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", "");
            }
        }
    }
}
