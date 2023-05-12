using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmSiteResource : Resource
	{
		/// <summary>
		/// The MagicRealmSiteResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmSiteResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmSiteResource's MagicRealmSiteEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmSiteEnum MagicRealmSiteEnum { get; set; }
	}
}
