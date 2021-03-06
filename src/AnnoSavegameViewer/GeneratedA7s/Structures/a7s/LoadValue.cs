// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class LoadValue {

		[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductGUID { get; set; }

		[BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductAmount { get; set; }

	}
}
