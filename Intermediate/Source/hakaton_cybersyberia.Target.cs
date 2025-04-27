using UnrealBuildTool;

public class hakaton_cybersyberiaTarget : TargetRules
{
	public hakaton_cybersyberiaTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("hakaton_cybersyberia");
	}
}
