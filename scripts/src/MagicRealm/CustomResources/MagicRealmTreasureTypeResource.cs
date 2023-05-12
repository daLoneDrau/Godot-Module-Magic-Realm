using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmTreasureTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmTreasureTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmTreasureTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmTreasureTypeResource's MagicRealmTreasureTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmTreasureTypeEnum MagicRealmTreasureTypeEnum { get; set; }
	}
}
