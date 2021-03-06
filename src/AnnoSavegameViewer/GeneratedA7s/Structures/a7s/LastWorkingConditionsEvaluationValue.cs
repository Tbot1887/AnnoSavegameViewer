// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class LastWorkingConditionsEvaluationValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public LastWorkingConditionsEvaluationValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "LastValue", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastValue { get; set; }

		[BinaryContent(Name = "PositiveThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
		public HexString PositiveThresholdLevel { get; set; }

		[BinaryContent(Name = "NegativeThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
		public HexString NegativeThresholdLevel { get; set; }

	}
}
