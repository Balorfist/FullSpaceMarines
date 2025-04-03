using RoR2;
using SpaceMarines.Modules.Achievements;

namespace SpaceMarines.Survivors.Bulwark.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class BulwarkMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = BulwarkSurvivor.BulwarkPrefix + "masteryAchievement";
        public const string unlockableIdentifier = BulwarkSurvivor.BulwarkPrefix + "masteryUnlockable";

        public override string RequiredCharacterBody => BulwarkSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}