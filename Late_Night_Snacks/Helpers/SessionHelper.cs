using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Late_Night_Snacks.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
     public static class SessionHelper
        {
            public static void SetObjectAsJson(this ISession session, string key, object value)
            {
                session.SetString(key, JsonConvert.SerializeObject(value));
            }

            public static T GetObjectFromJson<T>(this ISession session, string key)
            {
                var value = session.GetString(key);
                return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
            }
        }
}

