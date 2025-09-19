using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    public static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = 0.19f;
        public const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;
        private static float nectar = 100f;

        public static string StatusReport 
        { 
            get 
            {
                string report = $"Vault report: \n {honey} units of honey \n {nectar} units of nectar\n";
                if (LOW_LEVEL_WARNING > nectar)
                {
                    report += "LOW ON NECTAR - ADD A NECTART COLLECTOR";
                }
                if (LOW_LEVEL_WARNING > honey)
                {
                    report += "LOW ON HONEY - ADD A HONEY MANUFACTURER";
                }
                return report;
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            float nectartToConvert = amount;
            if (nectartToConvert > nectar)
            {
                nectartToConvert = nectar;
            }
            nectar -= nectartToConvert;
            honey += nectartToConvert * NECTAR_CONVERSION_RATIO;
        }
        public static bool ConsumeHoney(float amount)
        {
            if( amount > honey)
            {
                return false;
            }
            honey -= amount;
            return true;
        }
        public static void CollectNectar(float amount)
        {
            if(amount > 0)
            {
                nectar += amount;
            }
        }

    }
}
