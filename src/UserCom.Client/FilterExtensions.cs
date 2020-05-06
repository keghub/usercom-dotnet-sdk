using UserCom.Model.Users;

namespace UserCom
{
    public static class FilterExtensions
    {
        public static (string key, string value) ToQueryParam(this CustomAttributeFilter filter)
        {
            return (filter.Lookup switch
            {
                CustomAttributeLookup.Contains => $"{filter.Name}__contains",
                CustomAttributeLookup.ContainsCaseInsensitive => $"{filter.Name}__icontains",
                CustomAttributeLookup.EndsWith => $"{filter.Name}__endswith",
                CustomAttributeLookup.EndsWithCaseInsensitive => $"{filter.Name}__iendswith",
                CustomAttributeLookup.StartsWith => $"{filter.Name}__startswith",
                CustomAttributeLookup.StartsWithCaseInsensitive => $"{filter.Name}__istartswith",
                CustomAttributeLookup.GreaterThan => $"{filter.Name}__gt",
                CustomAttributeLookup.GreaterOrEqualThan => $"{filter.Name}__gte",
                CustomAttributeLookup.LessThan => $"{filter.Name}__lt",
                CustomAttributeLookup.LessOrEqualThan => $"{filter.Name}__lte"
            }, filter.Value.ToString());
        }

        public static (string key, string value) ToQueryParam(this UserFilter filter)
        {
            return (filter.Lookup switch
            {
                UserLookup.Contains => $"{filter.Name}__contains",
                UserLookup.GreaterThan => $"{filter.Name}__gt",
                UserLookup.GreaterOrEqualThan => $"{filter.Name}_gte",
                UserLookup.LessThan => $"{filter.Name}__lt",
                UserLookup.LessOrEqualThan => $"{filter.Name}__lte"
            }, filter.Value.ToString());
        }
    }
}