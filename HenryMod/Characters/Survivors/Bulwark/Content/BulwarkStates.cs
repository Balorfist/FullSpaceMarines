using SpaceMarines.Survivors.Bulwark.SkillStates;

namespace SpaceMarines.Survivors.Bulwark
{
    public static class BulwarkStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
