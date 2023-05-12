using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmMagicTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmMagicTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmMagicTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmMagicTypeResource's MagicRealmMagicTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmMagicTypeEnum MagicRealmMagicTypeEnum { get; set; }
	}
}
