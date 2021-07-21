// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "VRExpansionPlugin/Public/Grippables/AnimNode_ApplyHandDeltas.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeAnimNode_ApplyHandDeltas() {}
// Cross Module References
	VREXPANSIONPLUGIN_API UScriptStruct* Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas();
	UPackage* Z_Construct_UPackage__Script_VRExpansionPlugin();
	ENGINE_API UScriptStruct* Z_Construct_UScriptStruct_FAnimNode_Base();
	VREXPANSIONPLUGIN_API UScriptStruct* Z_Construct_UScriptStruct_FBPVRHandPoseBonePair();
// End Cross Module References

static_assert(std::is_polymorphic<FAnimNode_ApplyHandDeltas>() == std::is_polymorphic<FAnimNode_Base>(), "USTRUCT FAnimNode_ApplyHandDeltas cannot be polymorphic unless super FAnimNode_Base is polymorphic");

class UScriptStruct* FAnimNode_ApplyHandDeltas::StaticStruct()
{
	static class UScriptStruct* Singleton = NULL;
	if (!Singleton)
	{
		extern VREXPANSIONPLUGIN_API uint32 Get_Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Hash();
		Singleton = GetStaticStruct(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas, Z_Construct_UPackage__Script_VRExpansionPlugin(), TEXT("AnimNode_ApplyHandDeltas"), sizeof(FAnimNode_ApplyHandDeltas), Get_Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Hash());
	}
	return Singleton;
}
template<> VREXPANSIONPLUGIN_API UScriptStruct* StaticStruct<FAnimNode_ApplyHandDeltas>()
{
	return FAnimNode_ApplyHandDeltas::StaticStruct();
}
static FCompiledInDeferStruct Z_CompiledInDeferStruct_UScriptStruct_FAnimNode_ApplyHandDeltas(FAnimNode_ApplyHandDeltas::StaticStruct, TEXT("/Script/VRExpansionPlugin"), TEXT("AnimNode_ApplyHandDeltas"), false, nullptr, nullptr);
static struct FScriptStruct_VRExpansionPlugin_StaticRegisterNativesFAnimNode_ApplyHandDeltas
{
	FScriptStruct_VRExpansionPlugin_StaticRegisterNativesFAnimNode_ApplyHandDeltas()
	{
		UScriptStruct::DeferCppStructOps(FName(TEXT("AnimNode_ApplyHandDeltas")),new UScriptStruct::TCppStructOps<FAnimNode_ApplyHandDeltas>);
	}
} ScriptStruct_VRExpansionPlugin_StaticRegisterNativesFAnimNode_ApplyHandDeltas;
	struct Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Struct_MetaDataParams[];
#endif
		static void* NewStructOps();
		static const UE4CodeGen_Private::FStructPropertyParams NewProp_CustomPoseDeltas_Inner;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_CustomPoseDeltas_MetaData[];
#endif
		static const UE4CodeGen_Private::FArrayPropertyParams NewProp_CustomPoseDeltas;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_CustomPoseDelta_MetaData[];
#endif
		static const UE4CodeGen_Private::FStructPropertyParams NewProp_CustomPoseDelta;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const UE4CodeGen_Private::FStructParams ReturnStructParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::Struct_MetaDataParams[] = {
		{ "BlueprintInternalUseOnly", "true" },
		{ "BlueprintType", "true" },
		{ "ModuleRelativePath", "Public/Grippables/AnimNode_ApplyHandDeltas.h" },
	};
#endif
	void* Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewStructOps()
	{
		return (UScriptStruct::ICppStructOps*)new UScriptStruct::TCppStructOps<FAnimNode_ApplyHandDeltas>();
	}
	const UE4CodeGen_Private::FStructPropertyParams Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDeltas_Inner = { "CustomPoseDeltas", nullptr, (EPropertyFlags)0x0000000000000000, UE4CodeGen_Private::EPropertyGenFlags::Struct, RF_Public|RF_Transient|RF_MarkAsNative, 1, 0, Z_Construct_UScriptStruct_FBPVRHandPoseBonePair, METADATA_PARAMS(nullptr, 0) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDeltas_MetaData[] = {
		{ "Category", "HandAnimation" },
		{ "Comment", "// The stored custom bone deltas\n" },
		{ "ModuleRelativePath", "Public/Grippables/AnimNode_ApplyHandDeltas.h" },
		{ "PinShownByDefault", "" },
		{ "ToolTip", "The stored custom bone deltas" },
	};
#endif
	const UE4CodeGen_Private::FArrayPropertyParams Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDeltas = { "CustomPoseDeltas", nullptr, (EPropertyFlags)0x0010000000000005, UE4CodeGen_Private::EPropertyGenFlags::Array, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(FAnimNode_ApplyHandDeltas, CustomPoseDeltas), EArrayPropertyFlags::None, METADATA_PARAMS(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDeltas_MetaData, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDeltas_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDelta_MetaData[] = {
		{ "Category", "HandAnimation" },
		{ "ModuleRelativePath", "Public/Grippables/AnimNode_ApplyHandDeltas.h" },
		{ "PinShownByDefault", "" },
	};
#endif
	const UE4CodeGen_Private::FStructPropertyParams Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDelta = { "CustomPoseDelta", nullptr, (EPropertyFlags)0x0010000000000005, UE4CodeGen_Private::EPropertyGenFlags::Struct, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(FAnimNode_ApplyHandDeltas, CustomPoseDelta), Z_Construct_UScriptStruct_FBPVRHandPoseBonePair, METADATA_PARAMS(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDelta_MetaData, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDelta_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDeltas_Inner,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDeltas,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::NewProp_CustomPoseDelta,
	};
	const UE4CodeGen_Private::FStructParams Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::ReturnStructParams = {
		(UObject* (*)())Z_Construct_UPackage__Script_VRExpansionPlugin,
		Z_Construct_UScriptStruct_FAnimNode_Base,
		&NewStructOps,
		"AnimNode_ApplyHandDeltas",
		sizeof(FAnimNode_ApplyHandDeltas),
		alignof(FAnimNode_ApplyHandDeltas),
		Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::PropPointers,
		UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::PropPointers),
		RF_Public|RF_Transient|RF_MarkAsNative,
		EStructFlags(0x00000201),
		METADATA_PARAMS(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::Struct_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::Struct_MetaDataParams))
	};
	UScriptStruct* Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas()
	{
#if WITH_HOT_RELOAD
		extern uint32 Get_Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Hash();
		UPackage* Outer = Z_Construct_UPackage__Script_VRExpansionPlugin();
		static UScriptStruct* ReturnStruct = FindExistingStructIfHotReloadOrDynamic(Outer, TEXT("AnimNode_ApplyHandDeltas"), sizeof(FAnimNode_ApplyHandDeltas), Get_Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Hash(), false);
#else
		static UScriptStruct* ReturnStruct = nullptr;
#endif
		if (!ReturnStruct)
		{
			UE4CodeGen_Private::ConstructUScriptStruct(ReturnStruct, Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Statics::ReturnStructParams);
		}
		return ReturnStruct;
	}
	uint32 Get_Z_Construct_UScriptStruct_FAnimNode_ApplyHandDeltas_Hash() { return 1260617488U; }
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
