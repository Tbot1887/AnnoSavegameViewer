// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class TextInfoValue {

		[BinaryContent(Name = "type", NodeType = BinaryContentTypes.Attribute)]
		public HexString Type { get; set; }

		[BinaryContent(Name = "valArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString ValArea { get; set; }

	}
}
