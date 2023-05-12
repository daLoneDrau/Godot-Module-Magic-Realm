using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmTreasureResource : Resource
	{
		/// <summary>
		/// The MagicRealmTreasureResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's Description.
		/// <summary>
		/// <value></value>
		[Export]
		public string[] Description { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's Fame.
		/// <summary>
		/// <value></value>
		[Export]
		public int Fame { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's FameGroup.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmNativeGroupResource FameGroup { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's FamePrice.
		/// <summary>
		/// <value></value>
		[Export]
		public int FamePrice { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's IsTreasureWithinTreasure.
		/// <summary>
		/// <value></value>
		[Export]
		public bool IsTreasureWithinTreasure { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's MagicColour.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmMagicColourResource MagicColour { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's MagicType.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmMagicTypeResource MagicType { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's Notoriety.
		/// <summary>
		/// <value></value>
		[Export]
		public int Notoriety { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's Price.
		/// <summary>
		/// <value></value>
		[Export]
		public int Price { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's Type.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmTreasureTypeResource Type { get; set; }
		/// <summary>
		/// The MagicRealmTreasureResource's Weight.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmWeightResource Weight { get; set; }
	}
}
