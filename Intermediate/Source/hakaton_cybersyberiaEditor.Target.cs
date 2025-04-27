using UnrealBuildTool;

public class hakaton_cybersyberiaEditorTarget : TargetRules
{
	public hakaton_cybersyberiaEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("hakaton_cybersyberia");
	}
}
