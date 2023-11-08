using SML;

namespace Rosetta
{
    [Mod.SalemMod]
    public class Main
    {
        public static void Start()
        {
            Rosetta.Utils.Logger.Log(ModInfo.PLUGIN_NAME + " has loaded!");
        }
    }


    public static class ModInfo
    {
        public const string PLUGIN_GUID = "Rosetta";

        public const string PLUGIN_NAME = "Rosetta";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}