
using UnityEngine;
using Verse;

namespace RimWorldAndroidEnhanced
{
    public class AndroidEnhancedSettings : ModSettings
    {
        public bool EnableEnhancedInterface = true;
        public bool ShowCommandButton = true;
        public float EnemyReactionRadius = 20f;

        public override void ExposeData()
        {
            Scribe_Values.Look(
                ref EnableEnhancedInterface,
                "enableEnhancedInterface",
                true
            );

            Scribe_Values.Look(
                ref ShowCommandButton,
                "showCommandButton",
                true
            );

            Scribe_Values.Look(
                ref EnemyReactionRadius,
                "enemyReactionRadius",
                20f
            );

            base.ExposeData();
        }
    }
}
