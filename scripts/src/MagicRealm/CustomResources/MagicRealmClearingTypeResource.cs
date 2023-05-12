using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmClearingTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmClearingTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmClearingTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmClearingTypeResource's MagicRealmClearingTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmClearingTypeEnum MagicRealmClearingTypeEnum { get; set; }
	}
}
