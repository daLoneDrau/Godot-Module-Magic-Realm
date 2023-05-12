using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmArmourTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmArmourTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmArmourTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmArmourTypeResource's MagicRealmArmourTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmArmourTypeEnum MagicRealmArmourTypeEnum { get; set; }
	}
}
