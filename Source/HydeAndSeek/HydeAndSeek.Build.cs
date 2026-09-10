// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HydeAndSeek : ModuleRules
{
	public HydeAndSeek(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"HydeAndSeek",
			"HydeAndSeek/Variant_Platforming",
			"HydeAndSeek/Variant_Platforming/Animation",
			"HydeAndSeek/Variant_Combat",
			"HydeAndSeek/Variant_Combat/AI",
			"HydeAndSeek/Variant_Combat/Animation",
			"HydeAndSeek/Variant_Combat/Gameplay",
			"HydeAndSeek/Variant_Combat/Interfaces",
			"HydeAndSeek/Variant_Combat/UI",
			"HydeAndSeek/Variant_SideScrolling",
			"HydeAndSeek/Variant_SideScrolling/AI",
			"HydeAndSeek/Variant_SideScrolling/Gameplay",
			"HydeAndSeek/Variant_SideScrolling/Interfaces",
			"HydeAndSeek/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
