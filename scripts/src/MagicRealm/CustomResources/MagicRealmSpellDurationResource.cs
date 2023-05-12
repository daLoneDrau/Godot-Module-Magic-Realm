using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmSpellDurationResource : Resource
	{
		/// <summary>
		/// The MagicRealmSpellDurationResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmSpellDurationResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmSpellDurationResource's MagicRealmSpellDurationEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmSpellDurationEnum MagicRealmSpellDurationEnum { get; set; }
	}
}
