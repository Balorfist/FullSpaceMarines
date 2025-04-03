using System;
using System.Collections.Generic;
using System.Text;
using SpaceMarines.Modules;

namespace ImperiumSpaceMarines.Characters.Weapons
{
    public static class WeaponsTokens
    {
        public static void Init(string prefix)
        {
            AddWeaponsTokens(prefix);

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Weapons.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddWeaponsTokens(string prefix)
        {
            Language.Add(prefix + "BOLT_PISTOL_NAME", "Bolt Pistol");
            Language.Add(prefix + "BOLT_PISTOL_DESCRIPTION", Tokens.agilePrefix + $"Shot your pistol for <style=cIsDamage>{100f * WeaponsStacicValues.BoltPistolDamageCoefficient}% damage</style>.");

            Language.Add(prefix + "HEAVY_BOLT_PISTOL_NAME", "Heavy Bolt Pistol");
            Language.Add(prefix + "HEAVY_BOLT_PISTOL_DESCRIPTION", Tokens.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * WeaponsStacicValues.HeavyBoltPistolDamageCoefficient}% damage</style>.");
        }
    }
}
