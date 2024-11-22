

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
            public const nint m_CRenderComponent = 0x568; // CRenderComponent*
            public const nint m_CHitboxComponent = 0x570; // CHitboxComponent
            public const nint m_LastHitGroup = 0x598; // HitGroup_t
            public const nint m_bInitModelEffects = 0x5C0; // bool
            public const nint m_bIsStaticProp = 0x5C1; // bool
            public const nint m_nLastAddDecal = 0x5C4; // int32
            public const nint m_nDecalsAdded = 0x5C8; // int32
            public const nint m_iOldHealth = 0x5CC; // int32
            public const nint m_nRenderMode = 0x5D0; // RenderMode_t
            public const nint m_nRenderFX = 0x5D1; // RenderFx_t
            public const nint m_szAddModifier = 0x5D8; // CUtlString
            public const nint m_bAllowFadeInView = 0x5E0; // bool
            public const nint m_bHasCollision = 0x600; // bool
            public const nint m_vSupport = 0x604; // Vector
            public const nint m_clrRender = 0x610; // Color
            public const nint m_vecRenderAttributes = 0x618; // C_UtlVectorEmbeddedNetworkVar<EntityRenderAttribute_t>
            public const nint m_bRenderToCubemaps = 0x698; // bool
            public const nint m_bNoInterpolate = 0x699; // bool
            public const nint m_Collision = 0x6A0; // CCollisionProperty
            public const nint m_Glow = 0x750; // CGlowProperty
            public const nint m_flGlowBackfaceMult = 0x7A8; // float32
            public const nint m_fadeMinDist = 0x7AC; // float32
            public const nint m_fadeMaxDist = 0x7B0; // float32
            public const nint m_flFadeScale = 0x7B4; // float32
            public const nint m_flShadowStrength = 0x7B8; // float32
            public const nint m_nObjectCulling = 0x7BC; // uint8
            public const nint m_nAddDecal = 0x7C0; // int32
            public const nint m_vDecalPosition = 0x7C4; // Vector
            public const nint m_vDecalForwardAxis = 0x7D0; // Vector
            public const nint m_flDecalHealBloodRate = 0x7DC; // float32
            public const nint m_flDecalHealHeightRate = 0x7E0; // float32
            public const nint m_ConfigEntitiesToPropagateMaterialDecalsTo = 0x7E8; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
            public const nint m_vecViewOffset = 0x800; // CNetworkViewOffsetVector
            public const nint m_pClientAlphaProperty = 0x830; // CClientAlphaProperty*
            public const nint m_ClientOverrideTint = 0x838; // Color
            public const nint m_bUseClientOverrideTint = 0x83C; // bool
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
            public const nint m_aPlayerControllers = 0x568; // C_NetworkUtlVectorBase<CHandle<CBasePlayerController>>
            public const nint m_aPlayers = 0x580; // C_NetworkUtlVectorBase<CHandle<C_BasePlayerPawn>>
            public const nint m_iScore = 0x598; // int32
            public const nint m_szTeamname = 0x59C; // char[129]
        }
        // Parent: C_BaseEntity
        public static class CBasePlayerController
        {
            public const nint m_nFinalPredictedTick = 0x570; // int32
            public const nint m_CommandContext = 0x578; // C_CommandContext
            public const nint m_nInButtonsWhichAreToggles = 0x610; // uint64
            public const nint m_nTickBase = 0x618; // uint32
            public const nint m_hPawn = 0x61C; // CHandle<C_BasePlayerPawn>
            public const nint m_bKnownTeamMismatch = 0x620; // bool
            public const nint m_hPredictedPawn = 0x624; // CHandle<C_BasePlayerPawn>
            public const nint m_nSplitScreenSlot = 0x628; // CSplitScreenSlot
            public const nint m_hSplitOwner = 0x62C; // CHandle<CBasePlayerController>
            public const nint m_hSplitScreenPlayers = 0x630; // CUtlVector<CHandle<CBasePlayerController>>
            public const nint m_bIsHLTV = 0x648; // bool
            public const nint m_iConnected = 0x64C; // PlayerConnectedState
            public const nint m_iszPlayerName = 0x650; // char[128]
            public const nint m_steamID = 0x6D8; // uint64
            public const nint m_bIsLocalPlayerController = 0x6E0; // bool
            public const nint m_iDesiredFOV = 0x6E4; // uint32
        }
        // Parent: C_BaseCombatCharacter
        public static class C_BasePlayerPawn
        {
            public const nint m_pWeaponServices = 0xD20; // CPlayer_WeaponServices*
            public const nint m_pItemServices = 0xD28; // CPlayer_ItemServices*
            public const nint m_pAutoaimServices = 0xD30; // CPlayer_AutoaimServices*
            public const nint m_pObserverServices = 0xD38; // CPlayer_ObserverServices*
            public const nint m_pWaterServices = 0xD40; // CPlayer_WaterServices*
            public const nint m_pUseServices = 0xD48; // CPlayer_UseServices*
            public const nint m_pFlashlightServices = 0xD50; // CPlayer_FlashlightServices*
            public const nint m_pCameraServices = 0xD58; // CPlayer_CameraServices*
            public const nint m_pMovementServices = 0xD60; // CPlayer_MovementServices*
            public const nint m_ServerViewAngleChanges = 0xD70; // C_UtlVectorEmbeddedNetworkVar<ViewAngleServerChange_t>
            public const nint v_angle = 0xDD8; // QAngle
            public const nint v_anglePrevious = 0xDE4; // QAngle
            public const nint m_iHideHUD = 0xDF0; // uint32
            public const nint m_skybox3d = 0xDF8; // sky3dparams_t
            public const nint m_flDeathTime = 0xE88; // GameTime_t
            public const nint m_vecPredictionError = 0xE8C; // Vector
            public const nint m_flPredictionErrorTime = 0xE98; // GameTime_t
            public const nint m_vecLastCameraSetupLocalOrigin = 0xE9C; // Vector
            public const nint m_flLastCameraSetupTime = 0xEA8; // GameTime_t
            public const nint m_flFOVSensitivityAdjust = 0xEAC; // float32
            public const nint m_flMouseSensitivity = 0xEB0; // float32
            public const nint m_vOldOrigin = 0xEB4; // Vector
            public const nint m_flOldSimulationTime = 0xEC0; // float32
            public const nint m_nLastExecutedCommandNumber = 0xEC4; // int32
            public const nint m_nLastExecutedCommandTick = 0xEC8; // int32
            public const nint m_hController = 0xECC; // CHandle<CBasePlayerController>
            public const nint m_hDefaultController = 0xED0; // CHandle<CBasePlayerController>
            public const nint m_bIsSwappingToPredictableController = 0xED4; // bool
        }
        // Parent: CCitadelPlayerPawnBase
        public static class C_CitadelPlayerPawn
        {
            public const nint m_angEyeAngles = 0xF50; // QAngle
            public const nint m_angClientCamera = 0xF68; // QAngle
            public const nint m_eZipLineLaneColor = 0xF74; // CMsgLaneColor
            public const nint m_nLevel = 0xF78; // int32
            public const nint m_nCurrencies = 0xF7C; // int32[4]
            public const nint m_nSpentCurrencies = 0xF8C; // int32[4]
            public const nint m_flLastSpawnTime = 0xF9C; // GameTime_t
            public const nint m_flRespawnTime = 0xFA0; // GameTime_t
            public const nint m_bInRegenerationZone = 0xFA4; // bool
            public const nint m_bInItemShopZone = 0xFA5; // bool
            public const nint m_timeRevealedOnMinimapByNPC = 0xFA8; // GameTime_t
            public const nint m_vecFullSellPriceItems = 0xFB0; // C_NetworkUtlVectorBase<CUtlStringToken>
            public const nint m_vecFullSellPriceAbilityUpgrades = 0xFC8; // C_NetworkUtlVectorBase<FullSellPriceAbilityUpgrades_t>
            public const nint m_bNetworkDisconnected = 0xFE0; // bool
            public const nint m_bHasIncomingThreats = 0xFE1; // bool
            public const nint m_bLearningAbility = 0xFE2; // bool
            public const nint m_nFlashStartTick = 0xFE4; // int32
            public const nint m_nFlashMaxStartTick = 0xFE8; // int32
            public const nint m_nFlashFadeStartTick = 0xFEC; // int32
            public const nint m_nFlashEndTick = 0xFF0; // int32
            public const nint m_nFlashMaxAlpha = 0xFF4; // int8
            public const nint m_nDeducedLane = 0xFF8; // int32
            public const nint m_nSuccessiveDucks = 0xFFC; // int8
            public const nint m_flLastDuckTime = 0x1000; // GameTime_t
            public const nint m_bDismissedReportCard = 0x1004; // bool
            public const nint m_flCurrentHealingAmount = 0x1008; // float32
            public const nint m_angLockedEyeAngles = 0x100C; // QAngle
            public const nint m_CCitadelAbilityComponent = 0x1018; // CCitadelAbilityComponent
            public const nint m_CCitadelHeroComponent = 0x11B8; // CCitadelHeroComponent
            public const nint m_flRichPresenceUpdateInterval = 0x1280; // float32
            public const nint m_bAnimGraphMovementClipped = 0x1378; // bool
            public const nint m_bAnimGraphMovementDisableGravity = 0x1379; // bool
            public const nint m_bAnimGraphMovementDirectAirControl = 0x137A; // bool
            public const nint m_bLastMoveWasAnimGraph = 0x137B; // bool
            public const nint m_flPredTimeSlowedStart = 0x137C; // GameTime_t
            public const nint m_flPredTimeSlowedEnd = 0x1380; // GameTime_t
            public const nint m_flPredSlowSpeed = 0x1384; // float32
            public const nint m_flTimeSlowedStart = 0x1388; // GameTime_t[4]
            public const nint m_flTimeSlowedEnd = 0x1398; // GameTime_t[4]
            public const nint m_flSlowSpeed = 0x13A8; // float32[4]
            public const nint m_flSprintAnimSuppressEndTime = 0x13B8; // GameTime_t
            public const nint m_iCurSlowSlot = 0x13BC; // int32
            public const nint m_vShootTestOffsetStanding = 0x13C0; // Vector
            public const nint m_vShootTestOffsetCrouching = 0x13CC; // Vector
            public const nint m_leanStartTime = 0x13D8; // GameTime_t
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
            public const nint m_flNextPrimaryAttack = 0xCA0; // GameTime_t
            public const nint m_iClip = 0xCA4; // int32
            public const nint m_iBonusClip = 0xCA8; // int32
            public const nint m_flSpreadPenalty = 0xCAC; // float32
            public const nint m_flZoomTime = 0xCB0; // GameTime_t
            public const nint m_flZoomOutTime = 0xCB4; // GameTime_t
            public const nint m_iSpreadIndex = 0xCB8; // int8
            public const nint m_nShotRecoilIndex = 0xCBA; // int16
            public const nint m_flNextShotRecoilRecoveryTime = 0xCBC; // GameTime_t
            public const nint m_bIsZoomed = 0xCC0; // bool
            public const nint m_nBurstShotsRemaining = 0xCC1; // uint8
            public const nint m_nShotNumber = 0xCC4; // uint32
            public const nint m_bInReload = 0xCC8; // bool
            public const nint m_bSingleShotReloadFirstBullet = 0xCC9; // bool
            public const nint m_reloadQueuedStartTime = 0xCCC; // GameTime_t
            public const nint m_flReloadAvailableTime = 0xCD0; // GameTime_t
            public const nint m_bCanActiveReload = 0xCD4; // bool
            public const nint m_flLastAttackTime = 0xCD8; // GameTime_t
            public const nint m_flNextAttackDelayStartTime = 0xCDC; // GameTime_t
            public const nint m_flNextAttackDelayEndTime = 0xCE0; // GameTime_t
            public const nint m_flAttackDelayPauseTotalTime = 0xCE4; // float32
            public const nint m_flAttackDelayPauseEndTime = 0xCE8; // GameTime_t
            public const nint m_eNextAttackDelayReason = 0xCEC; // ENextAttackDelayReason_t
            public const nint m_bInputPressedWhileSelected = 0xCF0; // bool
            public const nint m_eActiveFireMode = 0xCF4; // EFireMode_t
            public const nint m_angRecoilAngles = 0xCF8; // QAngle
            public const nint m_angRecoilToAdd = 0xD04; // QAngle
            public const nint m_angRecoilRecovery = 0xD10; // QAngle
            public const nint m_flRecoilStartTime = 0xD1C; // GameTime_t
            public const nint m_flRecoilRecoverySpeed = 0xD20; // float32
            public const nint m_flAddApproachSpeed = 0xD24; // float32
            public const nint m_bFireBackwards = 0xD28; // bool
            public const nint m_currentSpread = 0xD2C; // float32
            public const nint m_currentMaxSpread = 0xD30; // float32
            public const nint m_currentFireSpread = 0xD34; // float32
            public const nint m_flCurrentSpinRate = 0xD38; // float32
            public const nint m_fFireDuration = 0xD40; // float32
            public const nint m_bFireOnEmpty = 0xD45; // bool
            public const nint m_bHasReleasedForSemiAuto = 0xD46; // bool
            public const nint m_flNextDisarmSound = 0xD48; // GameTime_t
        }
        // Parent: CEntityInstance
        public static class C_BaseEntity
        {
            public const nint m_CBodyComponent = 0x40; // CBodyComponent*
            public const nint m_NetworkTransmitComponent = 0x48; // CNetworkTransmitComponent
            public const nint m_nLastThinkTick = 0x330; // GameTick_t
            public const nint m_pGameSceneNode = 0x338; // CGameSceneNode*
            public const nint m_pRenderComponent = 0x340; // CRenderComponent*
            public const nint m_pCollision = 0x348; // CCollisionProperty*
            public const nint m_pModifierProp = 0x350; // CModifierProperty*
            public const nint m_iMaxHealth = 0x358; // int32
            public const nint m_iHealth = 0x35C; // int32
            public const nint m_lifeState = 0x360; // uint8
            public const nint m_bTakesDamage = 0x361; // bool
            public const nint m_nTakeDamageFlags = 0x368; // TakeDamageFlags_t
            public const nint m_nPlatformType = 0x370; // EntityPlatformTypes_t
            public const nint m_ubInterpolationFrame = 0x371; // uint8
            public const nint m_hSceneObjectController = 0x374; // CHandle<C_BaseEntity>
            public const nint m_nNoInterpolationTick = 0x378; // int32
            public const nint m_nVisibilityNoInterpolationTick = 0x37C; // int32
            public const nint m_flProxyRandomValue = 0x380; // float32
            public const nint m_iEFlags = 0x384; // int32
            public const nint m_nWaterType = 0x388; // uint8
            public const nint m_bInterpolateEvenWithNoModel = 0x389; // bool
            public const nint m_bPredictionEligible = 0x38A; // bool
            public const nint m_bApplyLayerMatchIDToModel = 0x38B; // bool
            public const nint m_tokLayerMatchID = 0x38C; // CUtlStringToken
            public const nint m_nSubclassID = 0x390; // CUtlStringToken
            public const nint m_nSimulationTick = 0x3A0; // int32
            public const nint m_iCurrentThinkContext = 0x3A4; // int32
            public const nint m_aThinkFunctions = 0x3A8; // CUtlVector<thinkfunc_t>
            public const nint m_bDisabledContextThinks = 0x3C0; // bool
            public const nint m_flAnimTime = 0x3C4; // float32
            public const nint m_flSimulationTime = 0x3C8; // float32
            public const nint m_nSceneObjectOverrideFlags = 0x3CC; // uint8
            public const nint m_bHasSuccessfullyInterpolated = 0x3CD; // bool
            public const nint m_bHasAddedVarsToInterpolation = 0x3CE; // bool
            public const nint m_bRenderEvenWhenNotSuccessfullyInterpolated = 0x3CF; // bool
            public const nint m_nInterpolationLatchDirtyFlags = 0x3D0; // int32[2]
            public const nint m_ListEntry = 0x3D8; // uint16[11]
            public const nint m_flCreateTime = 0x3F0; // GameTime_t
            public const nint m_flSpeed = 0x3F4; // float32
            public const nint m_EntClientFlags = 0x3F8; // uint16
            public const nint m_bClientSideRagdoll = 0x3FA; // bool
            public const nint m_iTeamNum = 0x3FB; // uint8
            public const nint m_spawnflags = 0x3FC; // uint32
            public const nint m_nNextThinkTick = 0x400; // GameTick_t
            public const nint m_fFlags = 0x408; // uint32
            public const nint m_vecAbsVelocity = 0x40C; // Vector
            public const nint m_vecVelocity = 0x418; // CNetworkVelocityVector
            public const nint m_hEffectEntity = 0x448; // CHandle<C_BaseEntity>
            public const nint m_hOwnerEntity = 0x44C; // CHandle<C_BaseEntity>
            public const nint m_MoveCollide = 0x450; // MoveCollide_t
            public const nint m_MoveType = 0x451; // MoveType_t
            public const nint m_nActualMoveType = 0x452; // MoveType_t
            public const nint m_flWaterLevel = 0x454; // float32
            public const nint m_fEffects = 0x458; // uint32
            public const nint m_hGroundEntity = 0x45C; // CHandle<C_BaseEntity>
            public const nint m_nGroundBodyIndex = 0x460; // int32
            public const nint m_flFriction = 0x464; // float32
            public const nint m_flElasticity = 0x468; // float32
            public const nint m_flGravityScale = 0x46C; // float32
            public const nint m_flTimeScale = 0x470; // float32
            public const nint m_bAnimatedEveryTick = 0x474; // bool
            public const nint m_flNavIgnoreUntilTime = 0x478; // GameTime_t
            public const nint m_hThink = 0x47C; // uint16
            public const nint m_fBBoxVisFlags = 0x488; // uint8
            public const nint m_bPredictable = 0x489; // bool
            public const nint m_bRenderWithViewModels = 0x48A; // bool
            public const nint m_nSplitUserPlayerPredictionSlot = 0x48C; // CSplitScreenSlot
            public const nint m_nFirstPredictableCommand = 0x490; // int32
            public const nint m_nLastPredictableCommand = 0x494; // int32
            public const nint m_hOldMoveParent = 0x498; // CHandle<C_BaseEntity>
            public const nint m_Particles = 0x4A0; // CParticleProperty
            public const nint m_vecPredictedScriptFloats = 0x4C8; // CUtlVector<float32>
            public const nint m_vecPredictedScriptFloatIDs = 0x4E0; // CUtlVector<int32>
            public const nint m_nNextScriptVarRecordID = 0x510; // int32
            public const nint m_vecAngVelocity = 0x520; // QAngle
            public const nint m_DataChangeEventRef = 0x52C; // int32
            public const nint m_dependencies = 0x530; // CUtlVector<CEntityHandle>
            public const nint m_nCreationTick = 0x548; // int32
            public const nint m_bAnimTimeChanged = 0x555; // bool
            public const nint m_bSimulationTimeChanged = 0x556; // bool
            public const nint m_sUniqueHammerID = 0x560; // CUtlString
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
            public const nint m_ePlayState = 0x700; // EPlayerPlayState
            public const nint m_iGuidedBotMatchLastHits = 0x704; // int32
            public const nint m_iGuidedBotMatchOrbsSecured = 0x708; // int32
            public const nint m_iGuidedBotMatchOrbsDenied = 0x70C; // int32
            public const nint m_iGuidedBotMatchDamageToGuardians = 0x710; // int32
            public const nint m_iGuidedBotMatchDamageToPlayers = 0x714; // int32
            public const nint m_iGuidedBotMatchDamageTaken = 0x718; // int32
            public const nint m_iGuidedBotMatchNetWorth = 0x71C; // int32
            public const nint m_iGuidedBotMatchModsPurchased = 0x720; // int32
            public const nint m_iGuidedBotMatchAbilityUpgrades = 0x724; // int32
            public const nint m_flGuideBotMatchLastTaskNagVO = 0x728; // float32
            public const nint m_flGuideBotLastTimeTaskCompleted = 0x72C; // float32
            public const nint m_eGuidedBotMatchObjective = 0x730; // EGuidedBotMatchObjective
            public const nint m_nCurrentRank = 0x734; // int32
            public const nint m_nAssignedLane = 0x738; // int8
            public const nint m_nOriginalLaneAssignment = 0x739; // int8
            public const nint m_bIsKingPanda = 0x73A; // bool
            public const nint m_bBotDisconnectTakeover = 0x73B; // bool
            public const nint m_bInTeamChat = 0x73C; // bool
            public const nint m_bInPartyChat = 0x73D; // bool
            public const nint m_unHeroBuildID = 0x740; // HeroBuildID_t
            public const nint m_bLaneSwapLocked = 0x744; // bool
            public const nint m_vecLaneSwapRequests = 0x748; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
            public const nint m_vecLaneSwapRejects = 0x760; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
            public const nint m_hHeroPawn = 0x778; // CHandle<C_CitadelPlayerPawn>
            public const nint m_PlayerDataGlobal = 0x7B0; // PlayerDataGlobal_t
            public const nint m_nDeathReplayAvailable = 0x9D0; // int8
            public const nint m_unLobbyPlayerSlot = 0x9D1; // CitadelLobbyPlayerSlot_t
            public const nint m_bHasCheckedFriendName = 0x9D2; // bool
            public const nint m_sFriendName = 0x9D8; // CUtlString
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
