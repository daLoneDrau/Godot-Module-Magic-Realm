using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmRoadwayTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmRoadwayTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmRoadwayTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmRoadwayTypeResource's MagicRealmRoadwayTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmRoadwayTypeEnum MagicRealmRoadwayTypeEnum { get; set; }
	}
}
