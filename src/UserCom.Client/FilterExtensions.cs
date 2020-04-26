using UserCom.Model.Users;

namespace UserCom
{
    public static class FilterExtensions
    {
        public static (string key, string value) ToQueryParam(this CustomAttributeFilter filter)
        {
            var key = filter.Name;
            switch (filter.Lookup)
            {
                case CustomAttributeLookup.Contains:
                    key = $"{key}__contains";
                    break;

                case CustomAttributeLookup.ContainsCaseInsensitive:
                    key = $"{key}__icontains";
                    break;

                case CustomAttributeLookup.EndsWith:
                    key = $"{key}__endswith";
                    break;

                case CustomAttributeLookup.EndsWithCaseInsensitive:
                    key = $"{key}__iendswith";
                    break;

                case CustomAttributeLookup.StartsWith:
                    key = $"{key}__startswith";
                    break;

                case CustomAttributeLookup.StartsWithCaseInsensitive:
                    key = $"{key}__istartswith";
                    break;

                case CustomAttributeLookup.GreaterThan:
                    key = $"{key}__gt";
                    break;

                case CustomAttributeLookup.GreaterOrEqualThan:
                    key = $"{key}__gte";
                    break;

                case CustomAttributeLookup.LessThan:
                    key = $"{key}__lt";
                    break;

                case CustomAttributeLookup.LessOrEqualThan:
                    key = $"{key}__lte";
                    break;
            }

            return (key, filter.Value.ToString());
        }

        public static (string key, string value) ToQueryParam(this UserFilter filter)
        {
            var key = filter.Name;
            switch (filter.Lookup)
            {
                case UserLookup.Contains:
                    key = $"{key}__contains";
                    break;

                case UserLookup.GreaterThan:
                    key = $"{key}__gt";
                    break;

                case UserLookup.GreaterOrEqualThan:
                    key = $"{key}__gte";
                    break;

                case UserLookup.LessThan:
                    key = $"{key}__lt";
                    break;

                case UserLookup.LessOrEqualThan:
                    key = $"{key}__lte";
                    break;
            }

            return (key, filter.Value.ToString());
        }
    }
}