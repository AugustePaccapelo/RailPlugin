// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RailPlugin : ModuleRules
{
	public RailPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.Add(ModuleDirectory);

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core", "CoreUObject", "DeveloperSettings", "Engine"
			});
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				
			});
	}
}
