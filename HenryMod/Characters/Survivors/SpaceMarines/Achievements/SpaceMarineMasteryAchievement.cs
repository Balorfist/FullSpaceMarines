using RoR2;
using SpaceMarines.Modules.Achievements;

namespace SpaceMarines.Survivors.SpaceMarine.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class SpaceMarineMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = SpaceMarinesSurvivor.FULLSPACEMARINES_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = SpaceMarinesSurvivor.FULLSPACEMARINES_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => SpaceMarinesSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}