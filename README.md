# Unity ScriptTemplates XTags

[![openupm](https://img.shields.io/npm/v/me.guyl.xtags?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/me.guyl.xtags/)

------------------------------------------------------------------

Extra tags for Unity ScriptTemplates

------------------------------------------------------------------

## Installation

### With [openupm-cli](https://openupm.com/) (preferred)

```
openupm add me.guyl.xtags
```

### With Git

Add the following line to you `Packages/manifest.json` in Unity under the `dependencies` section:

```json
"me.guyl.xtags": "https://github.com/bguyl/UnityScriptTemplates-xtags.git#1.0.0"
```

## Available tags

1. `#DATE#` will be replaced by `System.DateTime.Now.ToString()`
2. `#PRODUCTNAME#` will be replaced by the **product name** in *Player Settings*
3. `#COMPANYNAME#` will be replaced by the **company name** in *Player Settings*

## Examples

You can edit script templates in the following folder :

**On Windows**: `C:\Program File\Unity\Hub\Editor\<Version>\Editor\Data\Resources\ScriptTemplates`

For example, you can edit `81-C# Script-NewBehaviourScript.cs.txt` like this:

```csharp
/* Written by John Doe on #DATE# */
namespace #COMPANYNAME#.#PRODUCTNAME#
{
    using UnityEngine;

    /// <summary> </summary>
    public class #SCRIPTNAME# : MonoBehavior
    {
        #region Lifecyle
        private void Start()
        {
            #NOTRIM
        }

        private void Update()
        {
            #NOTRIM
        }
        #endregion
    }
}
```
