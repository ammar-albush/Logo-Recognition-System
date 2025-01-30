using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoRecognitionSystem
{
    public static class Central_Static_Value
    {

        public static LogoDetector LogoDetector = new LogoDetector();


        public static Train_Model Train_Model = new Train_Model();


        public static Snip_Images snipImage = new Snip_Images();

        public static string settings_path => "./settings.json";
        
        public static SettingsClass Settings { get; set; }
        
    }
}
