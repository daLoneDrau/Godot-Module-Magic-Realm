using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmHorseTypeResource : Resource
	{
		/// <summary>
		/// The MagicRealmHorseTypeResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmHorseTypeResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmHorseTypeResource's MagicRealmHorseTypeEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmHorseTypeEnum MagicRealmHorseTypeEnum { get; set; }
	}
}
