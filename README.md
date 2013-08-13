UnderstrikeCS
=============

Inspired by underscorejs and lowdash, this is a C# version

Pluck
-----
- Take an instance of any class, and pull out one property as a dictionary with one item as a key and value

Params:
- obj [class instance]
- pluck item [string]

Installation & Include
- Reference the Understike.dll in your project / copy file into your project

```CSharp
using Understike;
```

Example:

Part 1 - A class
```CSharp
public class Human {
	public string Name {
	  get {
	    return "Duncan";
	  }
	}

	public int Age {
	  get {
	    return 32;
	  }
	}

	public string Nick {
	  get {
	    return "The Wookie";
	  }
	}
}
```

```CSharp
Human duncan = new Human();
Dictionary<string, object> newDic2 = _.Pluck (duncan, "Name");

=> {
	{Name: "Duncan"}
}

```

Pick
----
- Take an instance of any class, and pull out properties as a dictionary with all the items in the pick list

Params:
- obj [class instance]
- picklist [string array]

Installation & Include
- Reference the Understike.dll in your project / copy file into your project

```CSharp
using Understike;
```

Example:

Part 1 - A class
```CSharp
public class Human {
  public string Name {
    get {
      return "Duncan";
    }
  }

  public int Age {
    get {
      return 32;
    }
  }

  public string Nick {
    get {
      return "The Wookie";
    }
  }
}
```

```CSharp
Human duncan = new Human();
string[] pluck = {"Name", "Age"};
Dictionary<string, object> newDic = _.Pick (duncan, pluck);

=> {
  {
    Name: "Duncan",
    Age: 32
  }
}

```

toDictionary
------------
- Take an instance of any class, and turn it into a Dictionary<string, object>

Params:
- obj [class instance]

Installation & Include
- Reference the Understike.dll in your project / copy file into your project

```CSharp
using Understike;
```

Example:

Part 1 - A class
```CSharp
public class Human {
  public string Name {
    get {
      return "Duncan";
    }
  }

  public int Age {
    get {
      return 32;
    }
  }

  public string Nick {
    get {
      return "The Wookie";
    }
  }
}
```

```CSharp
Human duncan = new Human();
Dictionary<string, object> newDic = _.toDictionary (duncan);

=> {
  {
    Name: "Duncan",
    Age: 32,
    Nick: "The Wookie"
  }
}

```
