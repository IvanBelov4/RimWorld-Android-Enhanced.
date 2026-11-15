
using UnityEngine;
using Verse;

namespace RimWorldAndroidEnhanced
{
    public class RimWorldAndroidEnhancedMod : Mod
    {
        public static AndroidEnhancedSettings Settings;

        public RimWorldAndroidEnhancedMod(ModContentPack content)
            : base(content)
        {
            Settings = GetSettings<AndroidEnhancedSettings>();

            Log.Message(
                "[RimWorld Android Enhanced] Initialized."
            );
        }

        public override string SettingsCategory()
        {
            return "RimWorld Android Enhanced";
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing = new Listing_Standard();
            listing.Begin(inRect);

            listing.CheckboxLabeled(
                "Enable enhanced interface",
                ref Settings.EnableEnhancedInterface
            );

            listing.CheckboxLabeled(
                "Show command button",
                ref Settings.ShowCommandButton
            );

            listing.Label(
                "Enemy reaction radius: "
                + Settings.EnemyReactionRadius.ToString("F0")
            );

            Settings.EnemyReactionRadius = listing.Slider(
                Settings.EnemyReactionRadius,
                5f,
                60f
            );

            listing.End();

            Settings.Write();
        }
    }
}
