using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmSpellTargetResource : Resource
	{
		/// <summary>
		/// The MagicRealmSpellTargetResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmSpellTargetResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmSpellTargetResource's MagicRealmSpellTargetEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmSpellTargetEnum MagicRealmSpellTargetEnum { get; set; }
	}
}
