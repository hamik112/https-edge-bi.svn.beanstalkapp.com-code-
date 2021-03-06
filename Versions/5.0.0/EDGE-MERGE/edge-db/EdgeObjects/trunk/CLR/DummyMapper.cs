﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Edge.Data.Objects
{
	public class DummyMapper
	{
		public Dictionary<Type, Dictionary<string, string>> Mapping;
		private Dictionary<string, string> EdgeObject;
		private Dictionary<string, string> TextCreative;
		private Dictionary<string, string> ImageCreative;
		private Dictionary<string, string> PlacementTarget;
		private Dictionary<string, string> KeywordTarget;
		private Dictionary<string, string> Segment;
		private Dictionary<string, string> Campaign;
		private Dictionary<string, string> Ad;
		private Dictionary<string, string> LandingPage;
		private Dictionary<string, string> AgeTarget;
		private Dictionary<string, string> GenderTarget;
		private Dictionary<string, string> Account;
		private Dictionary<string, string> Channel;
		private Dictionary<string, string> ChannelSpecificObject;
		private Dictionary<string, string> Target;
		private Dictionary<string, string> TargetMatch;
		private Dictionary<string, string> ConnectionDefinition;
		private Dictionary<string, string> SingleCreative;
		private Dictionary<string, string> Creative;
		private Dictionary<string, string> CompositeCreative;



		public DummyMapper()
		{
			Mapping = new Dictionary<Type, Dictionary<string, string>>();

			#region Target
			Target = new Dictionary<string, string>()
			{
					{"Name","string_Field1"},
			};
			Mapping.Add(typeof(Edge.Data.Objects.Target), Target);
			#endregion

			#region Creative
			Creative = new Dictionary<string, string>()
			{
					{"Name","string_Field1"},
			};
			Mapping.Add(typeof(Edge.Data.Objects.Creative), Creative);
			#endregion
			

			SingleCreative = new Dictionary<string, string>();
			Mapping.Add(typeof(Edge.Data.Objects.SingleCreative), SingleCreative);

			CompositeCreative = new Dictionary<string, string>();
			Mapping.Add(typeof(Edge.Data.Objects.CompositeCreative), CompositeCreative);

			#region ConnectionDefinition
			ConnectionDefinition = new Dictionary<string, string>()
				{
					{"ID","ID"},
					{"ConnectionName","Name"},
					{"AccountID","AccountID"},
					{"ChannelID","ChannelID"},
					{"BaseValueType","BaseValueType"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.ConnectionDefinition), ConnectionDefinition);
			#endregion

			#region TargetMatch
			TargetMatch = new Dictionary<string, string>()
				{
					{"Name","string_Field1"},
					{"DestinationUrl","string_Field2"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.TargetMatch), TargetMatch);
			#endregion

			#region ChannelSpecificObject
			ChannelSpecificObject = new Dictionary<string, string>()
				{
					{"OriginalID","OriginalID"},
					{"Status","Status"},
					{"Name","string_Field1"},
					{"ChannelID","ChannelID"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.ChannelSpecificObject), ChannelSpecificObject);
			#endregion

			#region Channel
			Channel = new Dictionary<string, string>()
				{
					{"ID","ID"},
					{"Name","Name"},
					{"ChannelType","ChannelType"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.Channel), Channel);
			#endregion

			#region Account
			Account = new Dictionary<string, string>()
				{
					{"ID","ID"},
					{"Name","Name"},
					{"ParentAccountID","ParentAccountID"},
					{"AccountID","AccountID"},
					{"Status","Status"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.Account), Account);
			#endregion

			#region EdgeObject
			EdgeObject = new Dictionary<string, string>()
				{
					{"GK","GK"},
					{"Name","Name"},
					{"AccountID","AccountID"},
				};
			Mapping.Add(typeof(Edge.Data.Objects.EdgeObject), EdgeObject);
			#endregion

			#region AgeTarget
			AgeTarget = new Dictionary<string, string>()
				{
					{"FromAge","int_Field1"},
					{"ToAge","int_Field2"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.AgeTarget), AgeTarget);
			#endregion

			#region GenderTarget
			this.GenderTarget = new Dictionary<string, string>()
				{
					{"Gender","int_Field1"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.GenderTarget), GenderTarget);
			#endregion

			#region KeywordTarget
			KeywordTarget = new Dictionary<string, string>()
				{
					{"MatchType","int_Field1"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.KeywordTarget), KeywordTarget);
			#endregion

			#region PlacementTarget
			PlacementTarget = new Dictionary<string, string>()
				{
					{"PlacementType","int_Field1"},
					{"Value","string_Field2"},
				};
			Mapping.Add(typeof(Edge.Data.Objects.PlacementTarget), PlacementTarget);
			#endregion

			#region TextCreative
			TextCreative = new Dictionary<string, string>()
				{
					{"TextType","int_Field1"},
					{"Text","string_Field2"},
					{"Text2","string_Field3"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.TextCreative), TextCreative);
			#endregion

			#region ImageCreative
			ImageCreative = new Dictionary<string, string>()
				{
					{"ImageUrl","string_Field2"},
					{"ImageSize","string_Field3"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.ImageCreative), ImageCreative);
			#endregion

			#region Campaign
			Campaign = new Dictionary<string, string>()
				{
					{"Budget","Decimal_Field1"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.Campaign), Campaign);
			#endregion

			#region Ad
			Ad = new Dictionary<string, string>()
				{
					{"DestinationUrl","DestinationUrl"},
					{"CreativeGK","CreativeGK"},
					{"Name","Name"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.Ad), Ad);
			#endregion

			#region Segment
			Segment = new Dictionary<string, string>()
				{
					{"ConnectionDefinitionID","int_Field1"},
					{"Value","string_Field2"}
				};
			Mapping.Add(typeof(Edge.Data.Objects.Segment), Segment);
			#endregion

			#region LandingPage
			LandingPage = new Dictionary<string, string>()
				{
					{"LandingPageType","int_Field1"},
				};
			Mapping.Add(typeof(Edge.Data.Objects.LandingPage), LandingPage);
			#endregion


		}

		public string GetSqlTargetMapFieldName(Type type, string DotNetName)
		{
			string map;

			Dictionary<string, string> mappDic = new Dictionary<string, string>();
			mappDic = GetFieldsMapping(type);
			if (mappDic.Count == 0)
				throw new Exception(string.Format("Could not find mapping for Type/Object {0}", type.Name));
			else if (mappDic.TryGetValue(DotNetName, out map))
			{
				return map;
			}
			else
			{
				throw new Exception(string.Format("Could not find mapping for Type/Object {0} and name {1}", type.Name, DotNetName));
			}

		}

		internal Dictionary<string, string> GetFieldsMapping(Type type)
		{
			Dictionary<string, string> fields = new Dictionary<string, string>();
			Dictionary<string, string> mappDic = new Dictionary<string, string>();

			if (Mapping.TryGetValue(type, out mappDic))
			{
				Type parentType = type.BaseType;
				fields = mappDic;
				while (parentType != null && (parentType.IsSubclassOf(typeof(EdgeObject)) || parentType == typeof(EdgeObject)))
				{
					Dictionary<string, string> parentMapping = new Dictionary<string, string>();
					if (Mapping.TryGetValue(parentType, out parentMapping))
					{
						foreach (var item in parentMapping)
						{
							if (!fields.ContainsKey(item.Key))
								fields.Add(item.Key, item.Value);
						}
						//fields = fields.Concat(parentMapping).ToDictionary(k => k.Key, v => v.Value);
						parentType = parentType.BaseType;
					}
					else
						throw new Exception(string.Format("Could not find mapping for Parent Type/Object {0}", parentType.Name));
				}
			}
			else
				throw new Exception(string.Format("Could not find mapping for Type/Object {0}", type.Name));

			return fields;
		}
	}
}
