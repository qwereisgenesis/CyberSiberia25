using UnrealBuildTool;

public class hakaton_cybersyberia : ModuleRules
{
	public hakaton_cybersyberia(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
