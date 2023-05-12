using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmWeightResource : Resource
	{
		/// <summary>
		/// The MagicRealmWeightResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmWeightResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmWeightResource's MagicRealmWeightEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmWeightEnum MagicRealmWeightEnum { get; set; }
	}
}
