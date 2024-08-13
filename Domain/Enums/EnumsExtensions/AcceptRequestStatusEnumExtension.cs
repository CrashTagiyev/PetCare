using System.ComponentModel;
using System.Reflection;

namespace Domain.Enums.EnumsExtensions
{
	public static class AcceptRequestStatusEnumExtension
	{
		public static string GetDescription(this Acceptstatus value)
		{
			FieldInfo? field = value.GetType().GetField(value.ToString());

			DescriptionAttribute? attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))!;

			return attribute == null ? value.ToString() : attribute.Description;
		}



	}
}
