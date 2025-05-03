using UnrealBuildTool;

public class hakaton_cybersyberiaClientTarget : TargetRules
{
	public hakaton_cybersyberiaClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("hakaton_cybersyberia");
	}
}
