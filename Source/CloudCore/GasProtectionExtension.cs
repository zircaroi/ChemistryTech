using Verse;

namespace CloudCore
{
    public class GasProtectionExtension : DefModExtension
    {
        public static readonly GasProtectionExtension defaultValues = new GasProtectionExtension ();

        public float efficiency = 0f;
    }
}