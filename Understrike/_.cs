using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Understrike {
    public static class _ {
      public static Dictionary<string, object> Pluck (object obj, string value) {
        Dictionary<string, object> dic = new Dictionary<string,object>();
        dic.Add(value, obj.GetType ().GetProperty (value).GetValue (obj, null));
        return dic;
      }

      public static Dictionary<string, object> Pick (object obj, Array Picklist) {
        Dictionary<string, object> dic = new Dictionary<string, object> ();
        foreach (string key in Picklist) {
          dic.Add(key, obj.GetType ().GetProperty (key).GetValue (obj, null));
        }
        return dic;
      }

      public static Dictionary<string, object> toDictionary (object obj) {
        Dictionary<string, object> dic = new Dictionary<string, object>();
        foreach (PropertyInfo key in obj.GetType ().GetProperties ()) {
          dic.Add (key.Name, obj.GetType ().GetProperty (key.Name).GetValue (obj, null));
        }
        return dic;
      }

  }
}
