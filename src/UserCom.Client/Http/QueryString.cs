using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserCom.Http
{
    public interface IQueryString
    {
        bool HasItems { get; }

        string Query { get; }
    }

    public class QueryString : IQueryString
    {
        public QueryString(IReadOnlyList<KeyValuePair<string, string>> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        private static string GetQuery(IEnumerable<KeyValuePair<string, string>> items)
        {
            var queryItems = from item in items
                let queryItem = $"{HttpUtility.UrlEncode(item.Key)}={HttpUtility.UrlEncode(item.Value)}"
                select queryItem;

            return string.Join("&", queryItems);
        }

        private readonly IReadOnlyList<KeyValuePair<string, string>> _items;

        public bool HasItems => _items.Count > 0;

        public string Query => GetQuery(_items);
    }
}