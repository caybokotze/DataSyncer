using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Jessidatasyncer.Logic
{
    public class Common
    {
        NameValueCollection settings = ConfigurationManager.AppSettings;
        
        public static void ShowMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        TimeSpan MakeTimeSpan(string setting)
        {
            string settinValue = settings[setting];
            int[] intSetting = GetHms(settinValue);
            return new TimeSpan(intSetting[0], intSetting[1], intSetting[2]);
        }

        static int[] GetHms(string setting)
        {
            string[] temp = setting.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            int[] result = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
                result[i] = Convert.ToInt32(temp[i]);
            return result;
        }
    }
}