using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmWeaponTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmWeaponTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmWeaponTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmWeaponTypeResource's MagicRealmWeaponTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmWeaponTypeEnum MagicRealmWeaponTypeEnum { get; set; }
	}
}
