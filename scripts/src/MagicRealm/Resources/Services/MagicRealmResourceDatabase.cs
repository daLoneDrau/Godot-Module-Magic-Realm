using Base.Bus;
using Base.Exceptions;
using Base.Pooled;
using Base.Resources.Bus;
using Base.Resources.Services;
using Base.Resources.Variables;
using Godot;
using System;
using System.Collections.Generic;
using MagicRealm.CustomResources;

namespace MagicRealm.Resources.Services
{
    public class MagicRealmResourceDatabase : Node
    {
        /// <summary>
        /// Reference to the singleton instance.
        /// </summary>
        /// <value></value>
        public static MagicRealmResourceDatabase Instance { get; private set; }
        private const string RESOURCE_BASE = "res://resources";
        #region VARIABLE INDEXER DICTIONARIES
        /// <summary>
        /// The dictionary of player attributes.
        /// </summary>
        /// <typeparam name="string">the name of the player attribute</typeparam>
        /// <typeparam name="AttributeDescriptor">the player attribute instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, AttributeDescriptor> attributeDescriptorConstants = new Dictionary<string, AttributeDescriptor>();
        /// <summary>
        /// The dictionary of GenderResources
        /// </summary>
        /// <typeparam name="string">the name of the GenderResource</typeparam>
        /// <typeparam name="GenderResource">the GenderResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, GenderResource> genderresourceDictionary = new Dictionary<string, GenderResource>();
        /// <summary>
        /// The dictionary of MagicRealmArmourConditionResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmArmourConditionResource</typeparam>
        /// <typeparam name="MagicRealmArmourConditionResource">the MagicRealmArmourConditionResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmArmourConditionResource> magicrealmarmourconditionresourceDictionary = new Dictionary<string, MagicRealmArmourConditionResource>();
        /// <summary>
        /// The dictionary of MagicRealmArmourTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmArmourTypeResource</typeparam>
        /// <typeparam name="MagicRealmArmourTypeResource">the MagicRealmArmourTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmArmourTypeResource> magicrealmarmourtyperesourceDictionary = new Dictionary<string, MagicRealmArmourTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmClearingTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmClearingTypeResource</typeparam>
        /// <typeparam name="MagicRealmClearingTypeResource">the MagicRealmClearingTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmClearingTypeResource> magicrealmclearingtyperesourceDictionary = new Dictionary<string, MagicRealmClearingTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmCounterActionResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmCounterActionResource</typeparam>
        /// <typeparam name="MagicRealmCounterActionResource">the MagicRealmCounterActionResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmCounterActionResource> magicrealmcounteractionresourceDictionary = new Dictionary<string, MagicRealmCounterActionResource>();
        /// <summary>
        /// The dictionary of MagicRealmDenizenTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmDenizenTypeResource</typeparam>
        /// <typeparam name="MagicRealmDenizenTypeResource">the MagicRealmDenizenTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmDenizenTypeResource> magicrealmdenizentyperesourceDictionary = new Dictionary<string, MagicRealmDenizenTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmEncounterResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmEncounterResource</typeparam>
        /// <typeparam name="MagicRealmEncounterResource">the MagicRealmEncounterResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmEncounterResource> magicrealmencounterresourceDictionary = new Dictionary<string, MagicRealmEncounterResource>();
        /// <summary>
        /// The dictionary of MagicRealmHorseTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmHorseTypeResource</typeparam>
        /// <typeparam name="MagicRealmHorseTypeResource">the MagicRealmHorseTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmHorseTypeResource> magicrealmhorsetyperesourceDictionary = new Dictionary<string, MagicRealmHorseTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmMagicColourResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmMagicColourResource</typeparam>
        /// <typeparam name="MagicRealmMagicColourResource">the MagicRealmMagicColourResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmMagicColourResource> magicrealmmagiccolourresourceDictionary = new Dictionary<string, MagicRealmMagicColourResource>();
        /// <summary>
        /// The dictionary of MagicRealmMagicTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmMagicTypeResource</typeparam>
        /// <typeparam name="MagicRealmMagicTypeResource">the MagicRealmMagicTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmMagicTypeResource> magicrealmmagictyperesourceDictionary = new Dictionary<string, MagicRealmMagicTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmNativeGroupResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmNativeGroupResource</typeparam>
        /// <typeparam name="MagicRealmNativeGroupResource">the MagicRealmNativeGroupResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmNativeGroupResource> magicrealmnativegroupresourceDictionary = new Dictionary<string, MagicRealmNativeGroupResource>();
        /// <summary>
        /// The dictionary of MagicRealmRelationshipStatusResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmRelationshipStatusResource</typeparam>
        /// <typeparam name="MagicRealmRelationshipStatusResource">the MagicRealmRelationshipStatusResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmRelationshipStatusResource> magicrealmrelationshipstatusresourceDictionary = new Dictionary<string, MagicRealmRelationshipStatusResource>();
        /// <summary>
        /// The dictionary of MagicRealmRoadwayTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmRoadwayTypeResource</typeparam>
        /// <typeparam name="MagicRealmRoadwayTypeResource">the MagicRealmRoadwayTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmRoadwayTypeResource> magicrealmroadwaytyperesourceDictionary = new Dictionary<string, MagicRealmRoadwayTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmSiteResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmSiteResource</typeparam>
        /// <typeparam name="MagicRealmSiteResource">the MagicRealmSiteResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmSiteResource> magicrealmsiteresourceDictionary = new Dictionary<string, MagicRealmSiteResource>();
        /// <summary>
        /// The dictionary of MagicRealmSoundResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmSoundResource</typeparam>
        /// <typeparam name="MagicRealmSoundResource">the MagicRealmSoundResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmSoundResource> magicrealmsoundresourceDictionary = new Dictionary<string, MagicRealmSoundResource>();
        /// <summary>
        /// The dictionary of MagicRealmSpellDurationResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmSpellDurationResource</typeparam>
        /// <typeparam name="MagicRealmSpellDurationResource">the MagicRealmSpellDurationResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmSpellDurationResource> magicrealmspelldurationresourceDictionary = new Dictionary<string, MagicRealmSpellDurationResource>();
        /// <summary>
        /// The dictionary of MagicRealmSpellTargetResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmSpellTargetResource</typeparam>
        /// <typeparam name="MagicRealmSpellTargetResource">the MagicRealmSpellTargetResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmSpellTargetResource> magicrealmspelltargetresourceDictionary = new Dictionary<string, MagicRealmSpellTargetResource>();
        /// <summary>
        /// The dictionary of MagicRealmTileTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmTileTypeResource</typeparam>
        /// <typeparam name="MagicRealmTileTypeResource">the MagicRealmTileTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmTileTypeResource> magicrealmtiletyperesourceDictionary = new Dictionary<string, MagicRealmTileTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmTreasureTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmTreasureTypeResource</typeparam>
        /// <typeparam name="MagicRealmTreasureTypeResource">the MagicRealmTreasureTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmTreasureTypeResource> magicrealmtreasuretyperesourceDictionary = new Dictionary<string, MagicRealmTreasureTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmVisitorMissionTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmVisitorMissionTypeResource</typeparam>
        /// <typeparam name="MagicRealmVisitorMissionTypeResource">the MagicRealmVisitorMissionTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmVisitorMissionTypeResource> magicrealmvisitormissiontyperesourceDictionary = new Dictionary<string, MagicRealmVisitorMissionTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmWarningResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmWarningResource</typeparam>
        /// <typeparam name="MagicRealmWarningResource">the MagicRealmWarningResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmWarningResource> magicrealmwarningresourceDictionary = new Dictionary<string, MagicRealmWarningResource>();
        /// <summary>
        /// The dictionary of MagicRealmWeaponTypeResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmWeaponTypeResource</typeparam>
        /// <typeparam name="MagicRealmWeaponTypeResource">the MagicRealmWeaponTypeResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmWeaponTypeResource> magicrealmweapontyperesourceDictionary = new Dictionary<string, MagicRealmWeaponTypeResource>();
        /// <summary>
        /// The dictionary of MagicRealmWeatherResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmWeatherResource</typeparam>
        /// <typeparam name="MagicRealmWeatherResource">the MagicRealmWeatherResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmWeatherResource> magicrealmweatherresourceDictionary = new Dictionary<string, MagicRealmWeatherResource>();
        /// <summary>
        /// The dictionary of MagicRealmWeightResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmWeightResource</typeparam>
        /// <typeparam name="MagicRealmWeightResource">the MagicRealmWeightResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmWeightResource> magicrealmweightresourceDictionary = new Dictionary<string, MagicRealmWeightResource>();
        /// <summary>
        /// The dictionary of MagicRealmTreasureResources
        /// </summary>
        /// <typeparam name="string">the name of the MagicRealmTreasureResource</typeparam>
        /// <typeparam name="MagicRealmTreasureResource">the MagicRealmTreasureResource instance</typeparam>
        /// <returns></returns>
        private Dictionary<string, MagicRealmTreasureResource> magicrealmtreasureresourceDictionary = new Dictionary<string, MagicRealmTreasureResource>();
        #endregion
        #region VARIABLE INDEXERS
        /// <summary>
        /// The VariableIndexer for AttributeDescriptors
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, AttributeDescriptor> AttributeDescriptors { get; private set; }
        /// <summary>
        /// The VariableIndexer for GenderResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, GenderResource> Genders { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmArmourConditionResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmArmourConditionResource> MagicRealmArmourConditions { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmArmourTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmArmourTypeResource> MagicRealmArmourTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmClearingTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmClearingTypeResource> MagicRealmClearingTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmCounterActionResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmCounterActionResource> MagicRealmCounterActions { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmDenizenTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmDenizenTypeResource> MagicRealmDenizenTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmEncounterResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmEncounterResource> MagicRealmEncounters { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmHorseTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmHorseTypeResource> MagicRealmHorseTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmMagicColourResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmMagicColourResource> MagicRealmMagicColours { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmMagicTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmMagicTypeResource> MagicRealmMagicTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmNativeGroupResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmNativeGroupResource> MagicRealmNativeGroups { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmRelationshipStatusResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmRelationshipStatusResource> MagicRealmRelationshipStatuss { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmRoadwayTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmRoadwayTypeResource> MagicRealmRoadwayTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmSiteResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmSiteResource> MagicRealmSites { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmSoundResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmSoundResource> MagicRealmSounds { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmSpellDurationResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmSpellDurationResource> MagicRealmSpellDurations { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmSpellTargetResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmSpellTargetResource> MagicRealmSpellTargets { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmTileTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmTileTypeResource> MagicRealmTileTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmTreasureTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmTreasureTypeResource> MagicRealmTreasureTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmVisitorMissionTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmVisitorMissionTypeResource> MagicRealmVisitorMissionTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmWarningResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmWarningResource> MagicRealmWarnings { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmWeaponTypeResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmWeaponTypeResource> MagicRealmWeaponTypes { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmWeatherResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmWeatherResource> MagicRealmWeathers { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmWeightResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmWeightResource> MagicRealmWeights { get; private set; }
        /// <summary>
        /// The VariableIndexer for MagicRealmTreasureResources
        /// </summary>
        /// <value></value>
        public VariableIndexer<string, MagicRealmTreasureResource> MagicRealmTreasures { get; private set; }
        #endregion
        #region TABLES
        /// <summary>
        /// The GenderTableResource.
        /// </summary>
        /// <value></value>
        public GenderTableResource GenderTable { get; private set; }
        #endregion
        /// <summary>
        /// Recursively loads a directory, storing all identifiable resources in variable indexers.
        /// </summary>
        /// <param name="path"></param>
        private void LoadDirectory(params string[] path)
        {
            PooledStringBuilder sb = StringBuilderPool.Instance.GetStringBuilder();
            sb.Append(RESOURCE_BASE);
            for (int i = 0, li = path.Length; i < li; i++) {
                sb.Append("/");
                sb.Append(path[i]);
            }
            Directory dir = new Directory();
            if (dir.Open(sb.ToString()) == Godot.Error.Ok)
            {
                dir.ListDirBegin(skipNavigational: true);
                string fileName = dir.GetNext();
                while (!fileName.Equals("", StringComparison.OrdinalIgnoreCase))
                {
                    string[] arr = ArrayUtilities.Instance.CopyArray(path);
                    arr = ArrayUtilities.Instance.ExtendArray(fileName, arr);
                    if (dir.CurrentIsDir())
                    {
                        // GD.Print("Found directory:", fileName);
                        if (!fileName.Equals(".git", StringComparison.OrdinalIgnoreCase))
                        {
                            LoadDirectory(arr);
                        }
                    }
                    else
                    {
                        // GD.Print("Found file:", fileName);

                        string key = fileName.Substr(0, fileName.Length - 5);
                        
                        sb.Length = 0;
                        sb.Append(RESOURCE_BASE);
                        for (int i = 0, li = arr.Length; i < li; i++) {
                            sb.Append("/");
                            sb.Append(arr[i]);
                        }
                        // GD.Print("load:", sb.ToString());
                        Resource res = GD.Load(sb.ToString());
                        if (res is AttributeDescriptor)
                        {
                            key = ((AttributeDescriptor)res).Abbreviation;
                            if (attributeDescriptorConstants.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            attributeDescriptorConstants.Add(key, (AttributeDescriptor)res);
                        }
                        else if (res is GenderResource)
                        {
                            key = ((GenderResource)res).Title;
                            if (genderresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            genderresourceDictionary.Add(key, (GenderResource)res);
                        }
                        else if (res is GenderResource)
                        {
                            key = ((GenderResource)res).Title;
                            if (genderresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            genderresourceDictionary.Add(key, (GenderResource)res);
                        }
                        else if (res is MagicRealmArmourConditionResource)
                        {
                            key = ((MagicRealmArmourConditionResource)res).Title;
                            if (magicrealmarmourconditionresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmarmourconditionresourceDictionary.Add(key, (MagicRealmArmourConditionResource)res);
                        }
                        else if (res is MagicRealmArmourTypeResource)
                        {
                            key = ((MagicRealmArmourTypeResource)res).Title;
                            if (magicrealmarmourtyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmarmourtyperesourceDictionary.Add(key, (MagicRealmArmourTypeResource)res);
                        }
                        else if (res is MagicRealmClearingTypeResource)
                        {
                            key = ((MagicRealmClearingTypeResource)res).Title;
                            if (magicrealmclearingtyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmclearingtyperesourceDictionary.Add(key, (MagicRealmClearingTypeResource)res);
                        }
                        else if (res is MagicRealmCounterActionResource)
                        {
                            key = ((MagicRealmCounterActionResource)res).Title;
                            if (magicrealmcounteractionresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmcounteractionresourceDictionary.Add(key, (MagicRealmCounterActionResource)res);
                        }
                        else if (res is MagicRealmDenizenTypeResource)
                        {
                            key = ((MagicRealmDenizenTypeResource)res).Title;
                            if (magicrealmdenizentyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmdenizentyperesourceDictionary.Add(key, (MagicRealmDenizenTypeResource)res);
                        }
                        else if (res is MagicRealmEncounterResource)
                        {
                            key = ((MagicRealmEncounterResource)res).Title;
                            if (magicrealmencounterresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmencounterresourceDictionary.Add(key, (MagicRealmEncounterResource)res);
                        }
                        else if (res is MagicRealmHorseTypeResource)
                        {
                            key = ((MagicRealmHorseTypeResource)res).Title;
                            if (magicrealmhorsetyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmhorsetyperesourceDictionary.Add(key, (MagicRealmHorseTypeResource)res);
                        }
                        else if (res is MagicRealmMagicColourResource)
                        {
                            key = ((MagicRealmMagicColourResource)res).Title;
                            if (magicrealmmagiccolourresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmmagiccolourresourceDictionary.Add(key, (MagicRealmMagicColourResource)res);
                        }
                        else if (res is MagicRealmMagicTypeResource)
                        {
                            key = ((MagicRealmMagicTypeResource)res).Title;
                            if (magicrealmmagictyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmmagictyperesourceDictionary.Add(key, (MagicRealmMagicTypeResource)res);
                        }
                        else if (res is MagicRealmNativeGroupResource)
                        {
                            key = ((MagicRealmNativeGroupResource)res).Title;
                            if (magicrealmnativegroupresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmnativegroupresourceDictionary.Add(key, (MagicRealmNativeGroupResource)res);
                        }
                        else if (res is MagicRealmRelationshipStatusResource)
                        {
                            key = ((MagicRealmRelationshipStatusResource)res).Title;
                            if (magicrealmrelationshipstatusresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmrelationshipstatusresourceDictionary.Add(key, (MagicRealmRelationshipStatusResource)res);
                        }
                        else if (res is MagicRealmRoadwayTypeResource)
                        {
                            key = ((MagicRealmRoadwayTypeResource)res).Title;
                            if (magicrealmroadwaytyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmroadwaytyperesourceDictionary.Add(key, (MagicRealmRoadwayTypeResource)res);
                        }
                        else if (res is MagicRealmSiteResource)
                        {
                            key = ((MagicRealmSiteResource)res).Title;
                            if (magicrealmsiteresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmsiteresourceDictionary.Add(key, (MagicRealmSiteResource)res);
                        }
                        else if (res is MagicRealmSoundResource)
                        {
                            key = ((MagicRealmSoundResource)res).Title;
                            if (magicrealmsoundresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmsoundresourceDictionary.Add(key, (MagicRealmSoundResource)res);
                        }
                        else if (res is MagicRealmSpellDurationResource)
                        {
                            key = ((MagicRealmSpellDurationResource)res).Title;
                            if (magicrealmspelldurationresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmspelldurationresourceDictionary.Add(key, (MagicRealmSpellDurationResource)res);
                        }
                        else if (res is MagicRealmSpellTargetResource)
                        {
                            key = ((MagicRealmSpellTargetResource)res).Title;
                            if (magicrealmspelltargetresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmspelltargetresourceDictionary.Add(key, (MagicRealmSpellTargetResource)res);
                        }
                        else if (res is MagicRealmTileTypeResource)
                        {
                            key = ((MagicRealmTileTypeResource)res).Title;
                            if (magicrealmtiletyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmtiletyperesourceDictionary.Add(key, (MagicRealmTileTypeResource)res);
                        }
                        else if (res is MagicRealmTreasureTypeResource)
                        {
                            key = ((MagicRealmTreasureTypeResource)res).Title;
                            if (magicrealmtreasuretyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmtreasuretyperesourceDictionary.Add(key, (MagicRealmTreasureTypeResource)res);
                        }
                        else if (res is MagicRealmVisitorMissionTypeResource)
                        {
                            key = ((MagicRealmVisitorMissionTypeResource)res).Title;
                            if (magicrealmvisitormissiontyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmvisitormissiontyperesourceDictionary.Add(key, (MagicRealmVisitorMissionTypeResource)res);
                        }
                        else if (res is MagicRealmWarningResource)
                        {
                            key = ((MagicRealmWarningResource)res).Title;
                            if (magicrealmwarningresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmwarningresourceDictionary.Add(key, (MagicRealmWarningResource)res);
                        }
                        else if (res is MagicRealmWeaponTypeResource)
                        {
                            key = ((MagicRealmWeaponTypeResource)res).Title;
                            if (magicrealmweapontyperesourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmweapontyperesourceDictionary.Add(key, (MagicRealmWeaponTypeResource)res);
                        }
                        else if (res is MagicRealmWeatherResource)
                        {
                            key = ((MagicRealmWeatherResource)res).Title;
                            if (magicrealmweatherresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmweatherresourceDictionary.Add(key, (MagicRealmWeatherResource)res);
                        }
                        else if (res is MagicRealmWeightResource)
                        {
                            key = ((MagicRealmWeightResource)res).Title;
                            if (magicrealmweightresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmweightresourceDictionary.Add(key, (MagicRealmWeightResource)res);
                        }
                        else if (res is MagicRealmTreasureResource)
                        {
                            key = ((MagicRealmTreasureResource)res).Title;
                            if (magicrealmtreasureresourceDictionary.ContainsKey(key))
                            {
                                throw new RPGException(ErrorMessage.INTERNAL_ERROR, "Duplicate Constant defined: " + key);
                            }
                            magicrealmtreasureresourceDictionary.Add(key, (MagicRealmTreasureResource)res);
                        }
                        else if (res is GenderTableResource)
                        {
                            GenderTable = (GenderTableResource)res;
                        }
                        else if (res is BoolVariable
                                || res is IntVariable
                                || res is FloatVariable
                                || res is StringVariable
                                || res is StringArrayVariable)
                        {
                            GameVariablesDatabase.Instance.AddResource(key, res, true);
                        }
                        else
                        {
                            throw new RPGException(ErrorMessage.INTERNAL_ERROR, "unexpected resource file " + res.GetType());
                        }
                    }
                    fileName = dir.GetNext();
                }
            }
            sb.ReturnToPool();

            AttributeDescriptors = new VariableIndexer<string, AttributeDescriptor>(attributeDescriptorConstants);
            Genders = new VariableIndexer<string, GenderResource>(genderresourceDictionary);
            MagicRealmArmourConditions = new VariableIndexer<string, MagicRealmArmourConditionResource>(magicrealmarmourconditionresourceDictionary);
            MagicRealmArmourTypes = new VariableIndexer<string, MagicRealmArmourTypeResource>(magicrealmarmourtyperesourceDictionary);
            MagicRealmClearingTypes = new VariableIndexer<string, MagicRealmClearingTypeResource>(magicrealmclearingtyperesourceDictionary);
            MagicRealmCounterActions = new VariableIndexer<string, MagicRealmCounterActionResource>(magicrealmcounteractionresourceDictionary);
            MagicRealmDenizenTypes = new VariableIndexer<string, MagicRealmDenizenTypeResource>(magicrealmdenizentyperesourceDictionary);
            MagicRealmEncounters = new VariableIndexer<string, MagicRealmEncounterResource>(magicrealmencounterresourceDictionary);
            MagicRealmHorseTypes = new VariableIndexer<string, MagicRealmHorseTypeResource>(magicrealmhorsetyperesourceDictionary);
            MagicRealmMagicColours = new VariableIndexer<string, MagicRealmMagicColourResource>(magicrealmmagiccolourresourceDictionary);
            MagicRealmMagicTypes = new VariableIndexer<string, MagicRealmMagicTypeResource>(magicrealmmagictyperesourceDictionary);
            MagicRealmNativeGroups = new VariableIndexer<string, MagicRealmNativeGroupResource>(magicrealmnativegroupresourceDictionary);
            MagicRealmRelationshipStatuss = new VariableIndexer<string, MagicRealmRelationshipStatusResource>(magicrealmrelationshipstatusresourceDictionary);
            MagicRealmRoadwayTypes = new VariableIndexer<string, MagicRealmRoadwayTypeResource>(magicrealmroadwaytyperesourceDictionary);
            MagicRealmSites = new VariableIndexer<string, MagicRealmSiteResource>(magicrealmsiteresourceDictionary);
            MagicRealmSounds = new VariableIndexer<string, MagicRealmSoundResource>(magicrealmsoundresourceDictionary);
            MagicRealmSpellDurations = new VariableIndexer<string, MagicRealmSpellDurationResource>(magicrealmspelldurationresourceDictionary);
            MagicRealmSpellTargets = new VariableIndexer<string, MagicRealmSpellTargetResource>(magicrealmspelltargetresourceDictionary);
            MagicRealmTileTypes = new VariableIndexer<string, MagicRealmTileTypeResource>(magicrealmtiletyperesourceDictionary);
            MagicRealmTreasureTypes = new VariableIndexer<string, MagicRealmTreasureTypeResource>(magicrealmtreasuretyperesourceDictionary);
            MagicRealmVisitorMissionTypes = new VariableIndexer<string, MagicRealmVisitorMissionTypeResource>(magicrealmvisitormissiontyperesourceDictionary);
            MagicRealmWarnings = new VariableIndexer<string, MagicRealmWarningResource>(magicrealmwarningresourceDictionary);
            MagicRealmWeaponTypes = new VariableIndexer<string, MagicRealmWeaponTypeResource>(magicrealmweapontyperesourceDictionary);
            MagicRealmWeathers = new VariableIndexer<string, MagicRealmWeatherResource>(magicrealmweatherresourceDictionary);
            MagicRealmWeights = new VariableIndexer<string, MagicRealmWeightResource>(magicrealmweightresourceDictionary);
            MagicRealmTreasures = new VariableIndexer<string, MagicRealmTreasureResource>(magicrealmtreasureresourceDictionary);
        }
        /// <summary>
        /// Called when the node enters the scene tree for the first time.
        /// </summary>
        public override void _Ready()
        {
            base._Ready();
            Instance = this;
            LoadDirectory("MagicRealm");
        }
    }
}
