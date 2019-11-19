using UnrealBuildTool;

public class TheRageRaceTarget : TargetRules
{
	public TheRageRaceTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheRageRace");
	}
}
