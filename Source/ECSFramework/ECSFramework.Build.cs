// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System;
using System.IO;
using System.Collections.Generic;

public class ECSFramework : ModuleRules
{
    public ECSFramework(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
        new string[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "HeadMountedDisplay",
            "ecs",
        });

        PrivateDependencyModuleNames.AddRange(
        new string[]
        {
            "Slate",
            "SlateCore",
            "GameplayAbilities",
            "AIModule",
            "GameplayTasks",
            "Landscape",
        }
        );

        //if ((Target.Platform == UnrealTargetPlatform.Win64) ||
        //    (Target.Platform == UnrealTargetPlatform.Win32))
        //{
        //    List<string> RuntimeModuleNames = new List<string>();
        //    //string BinaryLibraryFolder = Path.Combine("$(ProjectDir)", "Plugins/ecs/Dll", Target.Platform.ToString());
        //    string BinaryLibraryFolder = Path.Combine(ModuleDirectory, "../../Dll", Target.Platform.ToString());
        //    RuntimeModuleNames.Add("UE4Editor-ecs.dll");
            
        //    foreach (string RuntimeModuleName in RuntimeModuleNames)
        //    {
        //        string ModulePath = Path.Combine(BinaryLibraryFolder, RuntimeModuleName);
        //        if (!File.Exists(ModulePath))
        //        {
        //            string Err = string.Format("dll module '{0}' not found.", ModulePath);
        //            System.Console.WriteLine(Err);
        //            throw new BuildException(Err);
        //        }

        //        PublicDelayLoadDLLs.Add(RuntimeModuleName);
        //        RuntimeDependencies.Add(ModulePath);
        //    }
        //}
    }
}
