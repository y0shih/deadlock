

namespace offsetDump
{
    public static class ClientDll
    {
        // Parent: CBodyComponent
        public static class CBodyComponentSkeletonInstance
        {
            public const nint m_skeletonInstance = 0x80; // CSkeletonInstance
        }
        // Parent: C_BaseEntity
        public static class C_BaseModelEntity
        {
            public const nint m_CRenderComponent = 0x560; // CRenderComponent*
            public const nint m_CHitboxComponent = 0x568; // CHitboxComponent
            public const nint m_LastHitGroup = 0x590; // HitGroup_t
            public const nint m_bInitModelEffects = 0x5B8; // bool
            public const nint m_bIsStaticProp = 0x5B9; // bool
            public const nint m_nLastAddDecal = 0x5BC; // int32
            public const nint m_nDecalsAdded = 0x5C0; // int32
            public const nint m_iOldHealth = 0x5C4; // int32
            public const nint m_nRenderMode = 0x5C8; // RenderMode_t
            public const nint m_nRenderFX = 0x5C9; // RenderFx_t
            public const nint m_szAddModifier = 0x5D0; // CUtlString
            public const nint m_bAllowFadeInView = 0x5D8; // bool
            public const nint m_bHasCollision = 0x5F8; // bool
            public const nint m_vSupport = 0x5FC; // Vector
            public const nint m_clrRender = 0x608; // Color
            public const nint m_vecRenderAttributes = 0x610; // C_UtlVectorEmbeddedNetworkVar<EntityRenderAttribute_t>
            public const nint m_bRenderToCubemaps = 0x690; // bool
            public const nint m_bNoInterpolate = 0x691; // bool
            public const nint m_Collision = 0x698; // CCollisionProperty
            public const nint m_Glow = 0x748; // CGlowProperty
            public const nint m_flGlowBackfaceMult = 0x7A0; // float32
            public const nint m_fadeMinDist = 0x7A4; // float32
            public const nint m_fadeMaxDist = 0x7A8; // float32
            public const nint m_flFadeScale = 0x7AC; // float32
            public const nint m_flShadowStrength = 0x7B0; // float32
            public const nint m_nObjectCulling = 0x7B4; // uint8
            public const nint m_nAddDecal = 0x7B8; // int32
            public const nint m_vDecalPosition = 0x7BC; // Vector
            public const nint m_vDecalForwardAxis = 0x7C8; // Vector
            public const nint m_flDecalHealBloodRate = 0x7D4; // float32
            public const nint m_flDecalHealHeightRate = 0x7D8; // float32
            public const nint m_ConfigEntitiesToPropagateMaterialDecalsTo = 0x7E0; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
            public const nint m_vecViewOffset = 0x7F8; // CNetworkViewOffsetVector
            public const nint m_pClientAlphaProperty = 0x828; // CClientAlphaProperty*
            public const nint m_ClientOverrideTint = 0x830; // Color
            public const nint m_bUseClientOverrideTint = 0x834; // bool
        }
        // Parent: CPlayerPawnComponent
        public static class CPlayer_CameraServices
        {
            public const nint m_vecPunchAngle = 0x40; // QAngle
            public const nint m_vecPunchAngleVel = 0x58; // QAngle
            public const nint m_nPunchAngleJoltTickClientSide = 0x70; // GameTick_t
            public const nint m_nPunchAngleJoltTick = 0x74; // GameTick_t
            public const nint m_PlayerFog = 0x78; // C_fogplayerparams_t
            public const nint m_hColorCorrectionCtrl = 0xB8; // CHandle<C_ColorCorrection>
            public const nint m_hViewEntity = 0xBC; // CHandle<C_BaseEntity>
            public const nint m_hTonemapController = 0xC0; // CHandle<C_TonemapController2>
            public const nint m_audio = 0xC8; // audioparams_t
            public const nint m_PostProcessingVolumes = 0x140; // C_NetworkUtlVectorBase<CHandle<C_PostProcessingVolume>>
            public const nint m_flOldPlayerZ = 0x158; // float32
            public const nint m_flOldPlayerViewOffsetZ = 0x15C; // float32
            public const nint m_CurrentFog = 0x160; // fogparams_t
            public const nint m_hOldFogController = 0x1C8; // CHandle<C_FogController>
            public const nint m_bOverrideFogColor = 0x1CC; // bool[5]
            public const nint m_OverrideFogColor = 0x1D1; // Color[5]
            public const nint m_bOverrideFogStartEnd = 0x1E5; // bool[5]
            public const nint m_fOverrideFogStart = 0x1EC; // float32[5]
            public const nint m_fOverrideFogEnd = 0x200; // float32[5]
            public const nint m_hActivePostProcessingVolume = 0x214; // CHandle<C_PostProcessingVolume>
            public const nint m_angDemoViewAngles = 0x218; // QAngle
        }
        // Parent: CEntityComponent
        public static class CBodyComponent
        {
            public const nint m_pSceneNode = 0x8; // CGameSceneNode*
            public const nint __m_pChainEntity = 0x48;
        }
        // Parent: CGameSceneNode
        public static class CSkeletonInstance
        {
            public const nint m_modelState = 0x170; // CModelState
            public const nint m_bIsAnimationEnabled = 0x3F0; // bool
            public const nint m_bUseParentRenderBounds = 0x3F1; // bool
            public const nint m_bDisableSolidCollisionsForHierarchy = 0x3F2; // bool
            public const nint m_bDirtyMotionType = 0x0; // bitfield:1
            public const nint m_bIsGeneratingLatchedParentSpaceState = 0x0; // bitfield:1
            public const nint m_materialGroup = 0x3F4; // CUtlStringToken
            public const nint m_nHitboxSet = 0x3F8; // uint8
        }
        // Parent: CPlayer_MovementServices
        public static class CPlayer_MovementServices_Humanoid
        {
            public const nint m_flStepSoundTime = 0x1D8; // float32
            public const nint m_flFallVelocity = 0x1DC; // float32
            public const nint m_bInCrouch = 0x1E0; // bool
            public const nint m_nCrouchState = 0x1E4; // uint32
            public const nint m_flCrouchTransitionStartTime = 0x1E8; // GameTime_t
            public const nint m_bDucked = 0x1EC; // bool
            public const nint m_bDucking = 0x1ED; // bool
            public const nint m_bInDuckJump = 0x1EE; // bool
            public const nint m_groundNormal = 0x1F0; // Vector
            public const nint m_flSurfaceFriction = 0x1FC; // float32
            public const nint m_surfaceProps = 0x200; // CUtlStringToken
            public const nint m_nStepside = 0x210; // int32
        }
        // Parent: C_BaseEntity
        public static class C_Team
        {
            public const nint m_aPlayerControllers = 0x560; // C_NetworkUtlVectorBase<CHandle<CBasePlayerController>>
            public const nint m_aPlayers = 0x578; // C_NetworkUtlVectorBase<CHandle<C_BasePlayerPawn>>
            public const nint m_iScore = 0x590; // int32
            public const nint m_szTeamname = 0x594; // char[129]
        }
        // Parent: C_BaseEntity
        public static class CBasePlayerController
        {
            public const nint m_nFinalPredictedTick = 0x568; // int32
            public const nint m_CommandContext = 0x570; // C_CommandContext
            public const nint m_nInButtonsWhichAreToggles = 0x628; // uint64
            public const nint m_nTickBase = 0x630; // uint32
            public const nint m_hPawn = 0x634; // CHandle<C_BasePlayerPawn>
            public const nint m_bKnownTeamMismatch = 0x638; // bool
            public const nint m_hPredictedPawn = 0x63C; // CHandle<C_BasePlayerPawn>
            public const nint m_nSplitScreenSlot = 0x640; // CSplitScreenSlot
            public const nint m_hSplitOwner = 0x644; // CHandle<CBasePlayerController>
            public const nint m_hSplitScreenPlayers = 0x648; // CUtlVector<CHandle<CBasePlayerController>>
            public const nint m_bIsHLTV = 0x660; // bool
            public const nint m_iConnected = 0x664; // PlayerConnectedState
            public const nint m_iszPlayerName = 0x668; // char[128]
            public const nint m_steamID = 0x6F0; // uint64
            public const nint m_bIsLocalPlayerController = 0x6F8; // bool
            public const nint m_iDesiredFOV = 0x6FC; // uint32
        }
        // Parent: C_BaseCombatCharacter
        public static class C_BasePlayerPawn
        {
            public const nint m_pWeaponServices = 0xD18; // CPlayer_WeaponServices*
            public const nint m_pItemServices = 0xD20; // CPlayer_ItemServices*
            public const nint m_pAutoaimServices = 0xD28; // CPlayer_AutoaimServices*
            public const nint m_pObserverServices = 0xD30; // CPlayer_ObserverServices*
            public const nint m_pWaterServices = 0xD38; // CPlayer_WaterServices*
            public const nint m_pUseServices = 0xD40; // CPlayer_UseServices*
            public const nint m_pFlashlightServices = 0xD48; // CPlayer_FlashlightServices*
            public const nint m_pCameraServices = 0xD50; // CPlayer_CameraServices*
            public const nint m_pMovementServices = 0xD58; // CPlayer_MovementServices*
            public const nint m_ServerViewAngleChanges = 0xD68; // C_UtlVectorEmbeddedNetworkVar<ViewAngleServerChange_t>
            public const nint v_angle = 0xDD0; // QAngle
            public const nint v_anglePrevious = 0xDDC; // QAngle
            public const nint m_iHideHUD = 0xDE8; // uint32
            public const nint m_skybox3d = 0xDF0; // sky3dparams_t
            public const nint m_flDeathTime = 0xE80; // GameTime_t
            public const nint m_vecPredictionError = 0xE84; // Vector
            public const nint m_flPredictionErrorTime = 0xE90; // GameTime_t
            public const nint m_vecLastCameraSetupLocalOrigin = 0xE94; // Vector
            public const nint m_flLastCameraSetupTime = 0xEA0; // GameTime_t
            public const nint m_flFOVSensitivityAdjust = 0xEA4; // float32
            public const nint m_flMouseSensitivity = 0xEA8; // float32
            public const nint m_vOldOrigin = 0xEAC; // Vector
            public const nint m_flOldSimulationTime = 0xEB8; // float32
            public const nint m_nLastExecutedCommandNumber = 0xEBC; // int32
            public const nint m_nLastExecutedCommandTick = 0xEC0; // int32
            public const nint m_hController = 0xEC4; // CHandle<CBasePlayerController>
            public const nint m_hDefaultController = 0xEC8; // CHandle<CBasePlayerController>
            public const nint m_bIsSwappingToPredictableController = 0xECC; // bool
        }
        // Parent: CCitadelPlayerPawnBase
        public static class C_CitadelPlayerPawn
        {
            public const nint m_angEyeAngles = 0xF48; // QAngle
            public const nint m_angClientCamera = 0xF60; // QAngle
            public const nint m_eZipLineLaneColor = 0xF6C; // CMsgLaneColor
            public const nint m_nLevel = 0xF70; // int32
            public const nint m_nCurrencies = 0xF74; // int32[4]
            public const nint m_nSpentCurrencies = 0xF84; // int32[4]
            public const nint m_flLastSpawnTime = 0xF94; // GameTime_t
            public const nint m_flRespawnTime = 0xF98; // GameTime_t
            public const nint m_bInRegenerationZone = 0xF9C; // bool
            public const nint m_bInItemShopZone = 0xF9D; // bool
            public const nint m_timeRevealedOnMinimapByNPC = 0xFA0; // GameTime_t
            public const nint m_vecFullSellPriceItems = 0xFA8; // C_NetworkUtlVectorBase<CUtlStringToken>
            public const nint m_vecFullSellPriceAbilityUpgrades = 0xFC0; // C_NetworkUtlVectorBase<FullSellPriceAbilityUpgrades_t>
            public const nint m_bNetworkDisconnected = 0xFD8; // bool
            public const nint m_bHasIncomingThreats = 0xFD9; // bool
            public const nint m_bLearningAbility = 0xFDA; // bool
            public const nint m_nFlashStartTick = 0xFDC; // int32
            public const nint m_nFlashMaxStartTick = 0xFE0; // int32
            public const nint m_nFlashFadeStartTick = 0xFE4; // int32
            public const nint m_nFlashEndTick = 0xFE8; // int32
            public const nint m_nFlashMaxAlpha = 0xFEC; // int8
            public const nint m_nDeducedLane = 0xFF0; // int32
            public const nint m_nSuccessiveDucks = 0xFF4; // int8
            public const nint m_flLastDuckTime = 0xFF8; // GameTime_t
            public const nint m_bDismissedReportCard = 0xFFC; // bool
            public const nint m_flCurrentHealingAmount = 0x1000; // float32
            public const nint m_angLockedEyeAngles = 0x1004; // QAngle
            public const nint m_CCitadelAbilityComponent = 0x1010; // CCitadelAbilityComponent
            public const nint m_CCitadelHeroComponent = 0x11B0; // CCitadelHeroComponent
            public const nint m_flRichPresenceUpdateInterval = 0x1278; // float32
            public const nint m_bAnimGraphMovementClipped = 0x1370; // bool
            public const nint m_bAnimGraphMovementDisableGravity = 0x1371; // bool
            public const nint m_bAnimGraphMovementDirectAirControl = 0x1372; // bool
            public const nint m_bLastMoveWasAnimGraph = 0x1373; // bool
            public const nint m_flPredTimeSlowedStart = 0x1374; // GameTime_t
            public const nint m_flPredTimeSlowedEnd = 0x1378; // GameTime_t
            public const nint m_flPredSlowSpeed = 0x137C; // float32
            public const nint m_flTimeSlowedStart = 0x1380; // GameTime_t[4]
            public const nint m_flTimeSlowedEnd = 0x1390; // GameTime_t[4]
            public const nint m_flSlowSpeed = 0x13A0; // float32[4]
            public const nint m_flSprintAnimSuppressEndTime = 0x13B0; // GameTime_t
            public const nint m_iCurSlowSlot = 0x13B4; // int32
            public const nint m_vShootTestOffsetStanding = 0x13B8; // Vector
            public const nint m_vShootTestOffsetCrouching = 0x13C4; // Vector
            public const nint m_leanStartTime = 0x13D0; // GameTime_t
        }
        // Parent: None
        public static class PlayerDataGlobal_t
        {
            public const nint m_iLevel = 0x8; // int32
            public const nint m_iMaxAmmo = 0xC; // int32
            public const nint m_iHealthMax = 0x10; // int32
            public const nint m_flHealthRegen = 0x14; // float32
            public const nint m_flRespawnTime = 0x18; // GameTime_t
            public const nint m_nHeroID = 0x1C; // HeroID_t
            public const nint m_iGoldNetWorth = 0x20; // int32
            public const nint m_iAPNetWorth = 0x24; // int32
            public const nint m_iCreepGold = 0x28; // int32
            public const nint m_iCreepGoldSoloBonus = 0x2C; // int32
            public const nint m_iCreepGoldKill = 0x30; // int32
            public const nint m_iCreepGoldAirOrb = 0x34; // int32
            public const nint m_iCreepGoldGroundOrb = 0x38; // int32
            public const nint m_iCreepGoldDeny = 0x3C; // int32
            public const nint m_iCreepGoldNeutral = 0x40; // int32
            public const nint m_iFarmBaseline = 0x44; // int32
            public const nint m_iHealth = 0x48; // int32
            public const nint m_iPlayerKills = 0x4C; // int32
            public const nint m_iPlayerAssists = 0x50; // int32
            public const nint m_iDeaths = 0x54; // int32
            public const nint m_iDenies = 0x58; // int32
            public const nint m_iLastHits = 0x5C; // int32
            public const nint m_bAlive = 0x60; // bool
            public const nint m_nHeroDraftPosition = 0x64; // int32
            public const nint m_bUltimateTrained = 0x68; // bool
            public const nint m_flUltimateCooldownStart = 0x6C; // GameTime_t
            public const nint m_flUltimateCooldownEnd = 0x70; // GameTime_t
            public const nint m_bHasRejuvenator = 0x74; // bool
            public const nint m_bHasRebirth = 0x75; // bool
            public const nint m_bFlaggedAsCheater = 0x76; // bool
            public const nint m_iHeroDamage = 0x78; // int32
            public const nint m_iHeroHealing = 0x7C; // int32
            public const nint m_iSelfHealing = 0x80; // int32
            public const nint m_iObjectiveDamage = 0x84; // int32
            public const nint m_nHeroAbilityUpgradeBits = 0x88; // int32[4]
            public const nint m_vecUpgrades = 0x98; // C_NetworkUtlVectorBase<CUtlStringToken>
            public const nint m_vecBonusCounterAbilities = 0xB0; // C_NetworkUtlVectorBase<CUtlStringToken>
            public const nint m_vecBonusCounterValues = 0xC8; // C_NetworkUtlVectorBase<int32>
            public const nint m_tHeldItem = 0xE0; // CUtlStringToken
            public const nint m_vecImbuements = 0xE8; // C_UtlVectorEmbeddedNetworkVar<ItemImbuementPair_t>
            public const nint m_vecDynamicAbilityValues = 0x150; // C_UtlVectorEmbeddedNetworkVar<DynamicAbilityValues_t>
            public const nint m_vecStatViewerModifierValues = 0x1B8; // C_UtlVectorEmbeddedNetworkVar<StatViewerModifierValues_t>
        }
        // Parent: CPlayerPawnComponent
        public static class CPlayer_ObserverServices
        {
            public const nint m_iObserverMode = 0x40; // uint8
            public const nint m_hObserverTarget = 0x44; // CHandle<C_BaseEntity>
            public const nint m_iObserverLastMode = 0x48; // ObserverMode_t
            public const nint m_bForcedObserverMode = 0x4C; // bool
            public const nint m_flObserverChaseDistance = 0x50; // float32
            public const nint m_flObserverChaseDistanceCalcTime = 0x54; // GameTime_t
        }
        // Parent: None
        public static class CModelState
        {
            public const nint m_hModel = 0xD0; // CStrongHandle<InfoForResourceTypeCModel>
            public const nint m_ModelName = 0xD8; // CUtlSymbolLarge
            public const nint m_bClientClothCreationSuppressed = 0x118; // bool
            public const nint m_MeshGroupMask = 0x1D0; // uint64
            public const nint m_nBodyGroupChoices = 0x220; // C_NetworkUtlVectorBase<int32>
            public const nint m_nIdealMotionType = 0x26A; // int8
            public const nint m_nForceLOD = 0x26B; // int8
            public const nint m_nClothUpdateFlags = 0x26C; // int8
        }
        // Parent: CEntityComponent
        public static class CCitadelAbilityComponent
        {
            public const nint m_vecAbilities = 0x70; // C_NetworkUtlVectorBase<CHandle<C_CitadelBaseAbility>>
            public const nint m_vecUniversalItems = 0x88; // C_NetworkUtlVectorBase<CUtlStringToken>
            public const nint m_arPendingAsyncAbilityReservationSlots = 0xA0; // C_NetworkUtlVectorBase<int32>
            public const nint m_arPendingAsyncAbilityReservationAbilityIDs = 0xB8; // C_NetworkUtlVectorBase<int32>
            public const nint m_hSelectedAbility = 0xD0; // CHandle<C_CitadelBaseAbility>
            public const nint m_hPreviouslySelectedAbility = 0xD4; // CHandle<C_BaseEntity>
            public const nint m_bPreviousAbilityQueued = 0xD8; // bool
            public const nint m_flTimeScale = 0xDC; // float32
            public const nint m_flParticleTimeScale = 0xE0; // float32
            public const nint m_bInInterruptState = 0xE4; // bool
            public const nint m_ResourceStamina = 0xE8; // AbilityResource_t
            public const nint m_ResourceAbility = 0x108; // AbilityResource_t
            public const nint m_nExecuteAbilityMask = 0x170; // uint32
            public const nint m_bSelectedEffectsStarted = 0x178; // bool
        }
        // Parent: CPlayerPawnComponent
        public static class CPlayer_WeaponServices
        {
            public const nint m_hMyWeapons = 0x40; // C_NetworkUtlVectorBase<CHandle<C_BasePlayerWeapon>>
            public const nint m_hActiveWeapon = 0x58; // CHandle<C_BasePlayerWeapon>
            public const nint m_hLastWeapon = 0x5C; // CHandle<C_BasePlayerWeapon>
            public const nint m_iAmmo = 0x60; // uint16[32]
        }
        // Parent: None
        public static class CBaseModifier
        {
            public const nint m_nSerialNumber = 0x28; // ModifierSerialNumber_t
            public const nint m_flLastAppliedTime = 0x2C; // GameTime_t
            public const nint m_flCreationTime = 0x30; // GameTime_t
            public const nint m_flDuration = 0x34; // float32
            public const nint m_hCaster = 0x38; // CHandle<C_BaseEntity>
            public const nint m_hAbility = 0x3C; // CHandle<C_BaseEntity>
            public const nint m_hAuraProvider = 0x40; // CModifierHandleBase
            public const nint m_nAbilitySubclassID = 0x58; // CUtlStringToken
            public const nint m_iAttributes = 0x5C; // uint8
            public const nint m_iTeam = 0x5D; // uint8
            public const nint m_iStackCount = 0x5E; // int16
            public const nint m_iMaxStackCount = 0x60; // int16
            public const nint m_pVecStackDecayTimes = 0x68; // CUtlVector<GameTime_t>*
            public const nint m_eDestroyReason = 0x70; // uint8
            public const nint m_bDisabled = 0x71; // bool
            public const nint m_bSuppressSendModifier = 0x72; // bool
            public const nint m_flThinkInterval = 0x74; // float32
            public const nint m_flThinkIntervalStartTime = 0x78; // GameTime_t
            public const nint m_flTimeScale = 0x7C; // float32
            public const nint m_pVecTrackedObjects = 0x80; // CUtlVector<IModifierTrackedObject*>*
            public const nint m_hModifierListHandle = 0x88; // ModifierRuntimeHandle_t
        }
        // Parent: C_CitadelBaseAbility
        public static class CCitadel_Ability_PrimaryWeapon
        {
            public const nint m_flNextPrimaryAttack = 0xC98; // GameTime_t
            public const nint m_iClip = 0xC9C; // int32
            public const nint m_iBonusClip = 0xCA0; // int32
            public const nint m_flSpreadPenalty = 0xCA4; // float32
            public const nint m_flZoomTime = 0xCA8; // GameTime_t
            public const nint m_flZoomOutTime = 0xCAC; // GameTime_t
            public const nint m_iSpreadIndex = 0xCB0; // int8
            public const nint m_nShotRecoilIndex = 0xCB2; // int16
            public const nint m_flNextShotRecoilRecoveryTime = 0xCB4; // GameTime_t
            public const nint m_bIsZoomed = 0xCB8; // bool
            public const nint m_nBurstShotsRemaining = 0xCB9; // uint8
            public const nint m_nShotNumber = 0xCBC; // uint32
            public const nint m_bInReload = 0xCC0; // bool
            public const nint m_bSingleShotReloadFirstBullet = 0xCC1; // bool
            public const nint m_reloadQueuedStartTime = 0xCC4; // GameTime_t
            public const nint m_flReloadAvailableTime = 0xCC8; // GameTime_t
            public const nint m_bCanActiveReload = 0xCCC; // bool
            public const nint m_flLastAttackTime = 0xCD0; // GameTime_t
            public const nint m_flNextAttackDelayStartTime = 0xCD4; // GameTime_t
            public const nint m_flNextAttackDelayEndTime = 0xCD8; // GameTime_t
            public const nint m_flAttackDelayPauseTotalTime = 0xCDC; // float32
            public const nint m_flAttackDelayPauseEndTime = 0xCE0; // GameTime_t
            public const nint m_eNextAttackDelayReason = 0xCE4; // ENextAttackDelayReason_t
            public const nint m_bInputPressedWhileSelected = 0xCE8; // bool
            public const nint m_eActiveFireMode = 0xCEC; // EFireMode_t
            public const nint m_angRecoilAngles = 0xCF0; // QAngle
            public const nint m_angRecoilToAdd = 0xCFC; // QAngle
            public const nint m_angRecoilRecovery = 0xD08; // QAngle
            public const nint m_flRecoilStartTime = 0xD14; // GameTime_t
            public const nint m_flRecoilRecoverySpeed = 0xD18; // float32
            public const nint m_flAddApproachSpeed = 0xD1C; // float32
            public const nint m_bFireBackwards = 0xD20; // bool
            public const nint m_currentSpread = 0xD24; // float32
            public const nint m_currentMaxSpread = 0xD28; // float32
            public const nint m_currentFireSpread = 0xD2C; // float32
            public const nint m_flCurrentSpinRate = 0xD30; // float32
            public const nint m_fFireDuration = 0xD38; // float32
            public const nint m_bFireOnEmpty = 0xD3D; // bool
            public const nint m_bHasReleasedForSemiAuto = 0xD3E; // bool
            public const nint m_flNextDisarmSound = 0xD40; // GameTime_t
        }
        // Parent: CEntityInstance
        public static class C_BaseEntity
        {
            public const nint m_CBodyComponent = 0x38; // CBodyComponent*
            public const nint m_NetworkTransmitComponent = 0x40; // CNetworkTransmitComponent
            public const nint m_nLastThinkTick = 0x328; // GameTick_t
            public const nint m_pGameSceneNode = 0x330; // CGameSceneNode*
            public const nint m_pRenderComponent = 0x338; // CRenderComponent*
            public const nint m_pCollision = 0x340; // CCollisionProperty*
            public const nint m_pModifierProp = 0x348; // CModifierProperty*
            public const nint m_iMaxHealth = 0x350; // int32
            public const nint m_iHealth = 0x354; // int32
            public const nint m_lifeState = 0x358; // uint8
            public const nint m_bTakesDamage = 0x359; // bool
            public const nint m_nTakeDamageFlags = 0x360; // TakeDamageFlags_t
            public const nint m_nPlatformType = 0x368; // EntityPlatformTypes_t
            public const nint m_ubInterpolationFrame = 0x369; // uint8
            public const nint m_hSceneObjectController = 0x36C; // CHandle<C_BaseEntity>
            public const nint m_nNoInterpolationTick = 0x370; // int32
            public const nint m_nVisibilityNoInterpolationTick = 0x374; // int32
            public const nint m_flProxyRandomValue = 0x378; // float32
            public const nint m_iEFlags = 0x37C; // int32
            public const nint m_nWaterType = 0x380; // uint8
            public const nint m_bInterpolateEvenWithNoModel = 0x381; // bool
            public const nint m_bPredictionEligible = 0x382; // bool
            public const nint m_bApplyLayerMatchIDToModel = 0x383; // bool
            public const nint m_tokLayerMatchID = 0x384; // CUtlStringToken
            public const nint m_nSubclassID = 0x388; // CUtlStringToken
            public const nint m_nSimulationTick = 0x398; // int32
            public const nint m_iCurrentThinkContext = 0x39C; // int32
            public const nint m_aThinkFunctions = 0x3A0; // CUtlVector<thinkfunc_t>
            public const nint m_bDisabledContextThinks = 0x3B8; // bool
            public const nint m_flAnimTime = 0x3BC; // float32
            public const nint m_flSimulationTime = 0x3C0; // float32
            public const nint m_nSceneObjectOverrideFlags = 0x3C4; // uint8
            public const nint m_bHasSuccessfullyInterpolated = 0x3C5; // bool
            public const nint m_bHasAddedVarsToInterpolation = 0x3C6; // bool
            public const nint m_bRenderEvenWhenNotSuccessfullyInterpolated = 0x3C7; // bool
            public const nint m_nInterpolationLatchDirtyFlags = 0x3C8; // int32[2]
            public const nint m_ListEntry = 0x3D0; // uint16[11]
            public const nint m_flCreateTime = 0x3E8; // GameTime_t
            public const nint m_flSpeed = 0x3EC; // float32
            public const nint m_EntClientFlags = 0x3F0; // uint16
            public const nint m_bClientSideRagdoll = 0x3F2; // bool
            public const nint m_iTeamNum = 0x3F3; // uint8
            public const nint m_spawnflags = 0x3F4; // uint32
            public const nint m_nNextThinkTick = 0x3F8; // GameTick_t
            public const nint m_fFlags = 0x400; // uint32
            public const nint m_vecAbsVelocity = 0x404; // Vector
            public const nint m_vecVelocity = 0x410; // CNetworkVelocityVector
            public const nint m_hEffectEntity = 0x440; // CHandle<C_BaseEntity>
            public const nint m_hOwnerEntity = 0x444; // CHandle<C_BaseEntity>
            public const nint m_MoveCollide = 0x448; // MoveCollide_t
            public const nint m_MoveType = 0x449; // MoveType_t
            public const nint m_nActualMoveType = 0x44A; // MoveType_t
            public const nint m_flWaterLevel = 0x44C; // float32
            public const nint m_fEffects = 0x450; // uint32
            public const nint m_hGroundEntity = 0x454; // CHandle<C_BaseEntity>
            public const nint m_nGroundBodyIndex = 0x458; // int32
            public const nint m_flFriction = 0x45C; // float32
            public const nint m_flElasticity = 0x460; // float32
            public const nint m_flGravityScale = 0x464; // float32
            public const nint m_flTimeScale = 0x468; // float32
            public const nint m_bAnimatedEveryTick = 0x46C; // bool
            public const nint m_flNavIgnoreUntilTime = 0x470; // GameTime_t
            public const nint m_hThink = 0x474; // uint16
            public const nint m_fBBoxVisFlags = 0x480; // uint8
            public const nint m_bPredictable = 0x481; // bool
            public const nint m_bRenderWithViewModels = 0x482; // bool
            public const nint m_nSplitUserPlayerPredictionSlot = 0x484; // CSplitScreenSlot
            public const nint m_nFirstPredictableCommand = 0x488; // int32
            public const nint m_nLastPredictableCommand = 0x48C; // int32
            public const nint m_hOldMoveParent = 0x490; // CHandle<C_BaseEntity>
            public const nint m_Particles = 0x498; // CParticleProperty
            public const nint m_vecPredictedScriptFloats = 0x4C0; // CUtlVector<float32>
            public const nint m_vecPredictedScriptFloatIDs = 0x4D8; // CUtlVector<int32>
            public const nint m_nNextScriptVarRecordID = 0x508; // int32
            public const nint m_vecAngVelocity = 0x518; // QAngle
            public const nint m_DataChangeEventRef = 0x524; // int32
            public const nint m_dependencies = 0x528; // CUtlVector<CEntityHandle>
            public const nint m_nCreationTick = 0x540; // int32
            public const nint m_bAnimTimeChanged = 0x54D; // bool
            public const nint m_bSimulationTimeChanged = 0x54E; // bool
            public const nint m_sUniqueHammerID = 0x558; // CUtlString
        }
        // Parent: None
        public static class CEntityIdentity
        {
            public const nint m_nameStringableIndex = 0x14; // int32
            public const nint m_name = 0x18; // CUtlSymbolLarge
            public const nint m_designerName = 0x20; // CUtlSymbolLarge
            public const nint m_flags = 0x30; // uint32
            public const nint m_worldGroupId = 0x38; // WorldGroupId_t
            public const nint m_fDataObjectTypes = 0x3C; // uint32
            public const nint m_PathIndex = 0x40; // ChangeAccessorFieldPathIndex_t
            public const nint m_pPrev = 0x58; // CEntityIdentity*
            public const nint m_pNext = 0x60; // CEntityIdentity*
            public const nint m_pPrevByClass = 0x68; // CEntityIdentity*
            public const nint m_pNextByClass = 0x70; // CEntityIdentity*
        }
        // Parent: CBasePlayerController
        public static class CCitadelPlayerController
        {
            public const nint m_ePlayState = 0x768; // EPlayerPlayState
            public const nint m_iGuidedBotMatchLastHits = 0x76C; // int32
            public const nint m_iGuidedBotMatchOrbsSecured = 0x770; // int32
            public const nint m_iGuidedBotMatchOrbsDenied = 0x774; // int32
            public const nint m_iGuidedBotMatchDamageToGuardians = 0x778; // int32
            public const nint m_iGuidedBotMatchDamageToPlayers = 0x77C; // int32
            public const nint m_iGuidedBotMatchDamageTaken = 0x780; // int32
            public const nint m_iGuidedBotMatchNetWorth = 0x784; // int32
            public const nint m_iGuidedBotMatchModsPurchased = 0x788; // int32
            public const nint m_iGuidedBotMatchAbilityUpgrades = 0x78C; // int32
            public const nint m_flGuideBotMatchLastTaskNagVO = 0x790; // float32
            public const nint m_flGuideBotLastTimeTaskCompleted = 0x794; // float32
            public const nint m_eGuidedBotMatchObjective = 0x798; // EGuidedBotMatchObjective
            public const nint m_nCurrentRank = 0x79C; // int32
            public const nint m_nAssignedLane = 0x7A0; // int8
            public const nint m_nOriginalLaneAssignment = 0x7A1; // int8
            public const nint m_bIsKingPanda = 0x7A2; // bool
            public const nint m_bBotDisconnectTakeover = 0x7A3; // bool
            public const nint m_bInTeamChat = 0x7A4; // bool
            public const nint m_bInPartyChat = 0x7A5; // bool
            public const nint m_unHeroBuildID = 0x7A8; // HeroBuildID_t
            public const nint m_bLaneSwapLocked = 0x7AC; // bool
            public const nint m_vecLaneSwapRequests = 0x7B0; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
            public const nint m_vecLaneSwapRejects = 0x7C8; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
            public const nint m_vecMutedPlayers = 0x7E0; // C_NetworkUtlVectorBase<int32>
            public const nint m_hHeroPawn = 0x7F8; // CHandle<C_CitadelPlayerPawn>
            public const nint m_PlayerDataGlobal = 0x830; // PlayerDataGlobal_t
            public const nint m_nDeathReplayAvailable = 0xA50; // int8
            public const nint m_unLobbyPlayerSlot = 0xA51; // CitadelLobbyPlayerSlot_t
            public const nint m_bHasCheckedFriendName = 0xA52; // bool
            public const nint m_sFriendName = 0xA58; // CUtlString
        }
        // Parent: None
        public static class CGameSceneNode
        {
            public const nint m_nodeToWorld = 0x10; // CTransform
            public const nint m_pOwner = 0x30; // CEntityInstance*
            public const nint m_pParent = 0x38; // CGameSceneNode*
            public const nint m_pChild = 0x40; // CGameSceneNode*
            public const nint m_pNextSibling = 0x48; // CGameSceneNode*
            public const nint m_hParent = 0x78; // CGameSceneNodeHandle
            public const nint m_vecOrigin = 0x88; // CNetworkOriginCellCoordQuantizedVector
            public const nint m_angRotation = 0xC0; // QAngle
            public const nint m_flScale = 0xCC; // float32
            public const nint m_vecAbsOrigin = 0xD0; // Vector
            public const nint m_angAbsRotation = 0xDC; // QAngle
            public const nint m_flAbsScale = 0xE8; // float32
            public const nint m_nParentAttachmentOrBone = 0xEC; // int16
            public const nint m_bDebugAbsOriginChanges = 0xEE; // bool
            public const nint m_bDormant = 0xEF; // bool
            public const nint m_bForceParentToBeNetworked = 0xF0; // bool
            public const nint m_bDirtyHierarchy = 0x0; // bitfield:1
            public const nint m_bDirtyBoneMergeInfo = 0x0; // bitfield:1
            public const nint m_bNetworkedPositionChanged = 0x0; // bitfield:1
            public const nint m_bNetworkedAnglesChanged = 0x0; // bitfield:1
            public const nint m_bNetworkedScaleChanged = 0x0; // bitfield:1
            public const nint m_bWillBeCallingPostDataUpdate = 0x0; // bitfield:1
            public const nint m_bBoneMergeFlex = 0x0; // bitfield:1
            public const nint m_nLatchAbsOrigin = 0x0; // bitfield:2
            public const nint m_bDirtyBoneMergeBoneToRoot = 0x0; // bitfield:1
            public const nint m_nHierarchicalDepth = 0xF3; // uint8
            public const nint m_nHierarchyType = 0xF4; // uint8
            public const nint m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0xF5; // uint8
            public const nint m_name = 0xF8; // CUtlStringToken
            public const nint m_hierarchyAttachName = 0x138; // CUtlStringToken
            public const nint m_flZOffset = 0x13C; // float32
            public const nint m_flClientLocalScale = 0x140; // float32
            public const nint m_vRenderOrigin = 0x144; // Vector
        }
    }
}
