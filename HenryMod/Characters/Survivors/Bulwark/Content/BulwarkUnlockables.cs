using SpaceMarines.Survivors.Bulwark.Achievements;
using RoR2;
using UnityEngine;

namespace SpaceMarines.Survivors.Bulwark
{
    public static class BulwarkUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                BulwarkMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(BulwarkMasteryAchievement.identifier),
                BulwarkSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
