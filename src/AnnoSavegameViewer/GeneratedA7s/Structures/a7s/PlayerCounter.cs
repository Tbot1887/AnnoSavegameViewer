// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class PlayerCounter {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public PlayerCounterValue Value { get; set; }

	}
}