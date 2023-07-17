using LibraryApp.Debugging;

namespace LibraryApp
{
    public class LibraryAppConsts
    {
        public const string LocalizationSourceName = "LibraryApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "fee1acd313d441039146921644b16d5e";
    }
}
