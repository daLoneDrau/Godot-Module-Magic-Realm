using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmWeatherResource : Resource
	{
		/// <summary>
		/// The MagicRealmWeatherResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmWeatherResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmWeatherResource's MagicRealmWeatherEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmWeatherEnum MagicRealmWeatherEnum { get; set; }
	}
}
