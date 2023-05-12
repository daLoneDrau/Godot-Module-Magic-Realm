using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmTileTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmTileTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmTileTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmTileTypeResource's MagicRealmTileTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmTileTypeEnum MagicRealmTileTypeEnum { get; set; }
	}
}
