using GMS.Debugging;

namespace GMS
{
    public class GMSConsts
    {
        public const string LocalizationSourceName = "GMS";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7b0904dd85644469a9b212da23f2ef26";
    }
}
