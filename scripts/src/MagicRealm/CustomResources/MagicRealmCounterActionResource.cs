using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmCounterActionResource : Resource
	{
		/// <summary>
		/// The MagicRealmCounterActionResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmCounterActionResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmCounterActionResource's MagicRealmCounterActionEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmCounterActionEnum MagicRealmCounterActionEnum { get; set; }
	}
}
