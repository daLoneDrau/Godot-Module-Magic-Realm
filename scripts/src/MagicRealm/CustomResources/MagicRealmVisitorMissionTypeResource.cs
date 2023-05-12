using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmVisitorMissionTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmVisitorMissionTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmVisitorMissionTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmVisitorMissionTypeResource's MagicRealmVisitorMissionTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmVisitorMissionTypeEnum MagicRealmVisitorMissionTypeEnum { get; set; }
	}
}
