using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmEncounterResource : Resource
	{
		/// <summary>
		/// The MagicRealmEncounterResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmEncounterResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmEncounterResource's MagicRealmEncounterEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmEncounterEnum MagicRealmEncounterEnum { get; set; }
	}
}
