using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Understrike {
  public static class _ {
    public static Dictionary<string, object> Pluck (object obj, string value) {
      Dictionary<string, object> dic = new Dictionary<string, object> ();
      dic.Add (value, obj.GetType ().GetProperty (value).GetValue (obj, null));
      return dic;
    }

    public static Dictionary<string, object> Pick (object obj, Array picklist) {
      Dictionary<string, object> dic = new Dictionary<string, object> ();
      foreach (string key in picklist) {
        dic.Add (key, obj.GetType ().GetProperty (key).GetValue (obj, null));
      }
      return dic;
    }

    public static Dictionary<string, object> toDictionary (object obj) {
      Dictionary<string, object> dic = new Dictionary<string, object> ();
      foreach (PropertyInfo key in obj.GetType ().GetProperties ()) {
        dic.Add (key.Name, obj.GetType ().GetProperty (key.Name).GetValue (obj, null));
      }
      return dic;
    }

    public static Type GetGenericCollectionItemType (Type type) {
      return type.GetInterfaces ()
          .Where (face => face.IsGenericType &&
                         face.GetGenericTypeDefinition () == typeof (ICollection<>))
          .Select (face => face.GetGenericTypeDefinition ())
          .FirstOrDefault ();
    }

    //public static Type GetListType (Type type) {
    //  if (type.IsGenericType) {
    //    Console.Write ("IsGenericType");
    //    //if (type.IsGenericTypeDefinition) {
    //    if (type.GetGenericTypeDefinition () == typeof (List<>)) {
    //      return type.GetGenericArguments ()[0];
    //    }
    //    //}
    //    //return type.GetGenericArguments ()[0]; //typeof (type).GetMethod ("StringifyList").ToString (); 
    //  } else {
    //    return type.GetType ();
    //  }
    //}

    //public static string typeTest (object obj) {
    //  if (obj.GetType().IsGenericType && obj.GetType ().GetGenericTypeDefinition () == typeof(IList<>)) {
    //    return obj.GetType ().GetGenericTypeDefinition().ToString ();
    //  }
    //  //return obj.GetType ().ToString ();
    //}
  }
}
