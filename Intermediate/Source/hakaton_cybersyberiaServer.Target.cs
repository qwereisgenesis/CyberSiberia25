using UnrealBuildTool;

public class hakaton_cybersyberiaServerTarget : TargetRules
{
	public hakaton_cybersyberiaServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("hakaton_cybersyberia");
	}
}
