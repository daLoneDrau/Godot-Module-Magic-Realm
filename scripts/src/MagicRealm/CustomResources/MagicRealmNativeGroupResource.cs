using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmNativeGroupResource : Resource
	{
		/// <summary>
		/// The MagicRealmNativeGroupResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmNativeGroupResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmNativeGroupResource's MagicRealmNativeGroupEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmNativeGroupEnum MagicRealmNativeGroupEnum { get; set; }
	}
}
