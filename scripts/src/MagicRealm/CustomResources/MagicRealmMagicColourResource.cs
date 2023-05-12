using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmMagicColourResource : Resource
	{
		/// <summary>
		/// The MagicRealmMagicColourResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmMagicColourResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmMagicColourResource's MagicRealmMagicColourEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmMagicColourEnum MagicRealmMagicColourEnum { get; set; }
	}
}
