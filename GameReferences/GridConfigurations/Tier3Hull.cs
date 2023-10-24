namespace Abyss.GameReferences.GridConfigurations;
public static class Tier3Hull
{
    public static GridConfiguration Tier3HullInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "Tier3Hull");
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,ENGINE,GENERAL,RELIC,TRINKET,MATERIAL,POT,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "",
     ///            "itemSubtype": "",
     ///            "isHidden": true,
     ///            "damageImmune": true
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,ROD,GENERAL,RELIC,TRINKET,MATERIAL,POT,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,ROD,GENERAL,RELIC,TRINKET,MATERIAL,POT,NET,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "EQUIPMENT,ALL",
     ///            "itemSubtype": "DREDGE,ALL",
     ///            "isHidden": true,
     ///            "damageImmune": true
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,GENERAL,RELIC,TRINKET,MATERIAL,LIGHT,POT,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = Tier3HullInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.FISH | ItemSubtype.GENERAL | ItemSubtype.RELIC | ItemSubtype.TRINKET | ItemSubtype.MATERIAL | ItemSubtype.POT;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = true;
    public static bool canAddItemsInQuestMode = false;
    public static bool hasUnderlay = true;
    public static int columns = 8;
    public static int rows = 11;
}
