using Godot;
using MagicRealm.Resources.EnumeratedTypes;

namespace MagicRealm.CustomResources
{
	public class MagicRealmRelationshipStatusResource : Resource
	{
		/// <summary>
		/// The MagicRealmRelationshipStatusResource's Title.
		/// <summary>
		/// <value></value>
		[Export]
		public string Title { get; set; }
		/// <summary>
		/// The MagicRealmRelationshipStatusResource's DisplayName.
		/// <summary>
		/// <value></value>
		[Export]
		public string DisplayName { get; set; }
		/// <summary>
		/// The MagicRealmRelationshipStatusResource's MagicRealmRelationshipStatusEnum.
		/// <summary>
		/// <value></value>
		[Export]
		public MagicRealmRelationshipStatusEnum MagicRealmRelationshipStatusEnum { get; set; }
	}
}
