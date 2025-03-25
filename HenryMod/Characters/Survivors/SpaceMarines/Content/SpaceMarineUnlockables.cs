using SpaceMarines.Survivors.SpaceMarine.Achievements;
using RoR2;
using UnityEngine;

namespace SpaceMarines.Survivors.SpaceMarine
{
    public static class SpaceMarineUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                SpaceMarineMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(SpaceMarineMasteryAchievement.identifier),
                SpaceMarinesSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
