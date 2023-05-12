using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmSoundResource : Resource
	{
		/// <summary>
		/// The MagicRealmSoundResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmSoundResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmSoundResource's MagicRealmSoundEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmSoundEnum MagicRealmSoundEnum { get; set; }
	}
}
