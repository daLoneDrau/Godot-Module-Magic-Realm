using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmWarningResource : Resource
	{
		/// <summary>
		/// The MagicRealmWarningResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmWarningResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmWarningResource's MagicRealmWarningEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmWarningEnum MagicRealmWarningEnum { get; set; }
	}
}
