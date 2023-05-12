using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmDenizenTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmDenizenTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmDenizenTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmDenizenTypeResource's MagicRealmDenizenTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmDenizenTypeEnum MagicRealmDenizenTypeEnum { get; set; }
	}
}
