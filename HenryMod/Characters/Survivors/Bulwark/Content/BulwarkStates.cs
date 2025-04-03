using SpaceMarines.Survivors.Bulwark.SkillStates;
using SpaceMarines.Characters.Weapons;

namespace SpaceMarines.Survivors.Bulwark
{
    public static class BulwarkStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(BoltPistol));
            Modules.Content.AddEntityState(typeof(HeavyBoltPistol));

            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
