using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmArmourConditionResource : Resource
	{
		/// <summary>
		/// The MagicRealmArmourConditionResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmArmourConditionResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmArmourConditionResource's MagicRealmArmourConditionEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmArmourConditionEnum MagicRealmArmourConditionEnum { get; set; }
	}
}
