/**
 * Copyright 2020 ZeroStudio. All Rights Reserved.
 * Description:
 * Author:zhaoxiaokai520@outlook.com
 * Date:2020.4.11
 * Version: 1.0
 */


#include "ECSFrameworkGameModeBase.h"
#include "UObject/ConstructorHelpers.h"

AECSFrameworkGameModeBase::AECSFrameworkGameModeBase()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/Blueprints/ECSCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}