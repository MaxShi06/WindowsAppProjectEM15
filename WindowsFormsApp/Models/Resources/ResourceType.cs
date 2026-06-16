using System.Collections.Generic;

namespace WindowsFormsApp.Models.Resources
{
    public enum ResourceType
    {
        Coal,
        IronOre,
        Oil,
        Electricity,
        Iron,
        Copper,
        Lead,
        Fuel,
        Plastic,
        Kettle
    }

    public static class ResourceTypeExtensions
    {
        private static readonly Dictionary<ResourceType, string> Names = new Dictionary<ResourceType, string>
        {
            { ResourceType.Coal,        "Вугілля"      },
            { ResourceType.IronOre,     "Залізна руда" },
            { ResourceType.Oil,         "Нафта"        },
            { ResourceType.Electricity, "Електрика"    },
            { ResourceType.Iron,        "Залізо"       },
            { ResourceType.Copper,      "Мідь"         },
            { ResourceType.Lead,        "Свинець"      },
            { ResourceType.Fuel,        "Паливо"       },
            { ResourceType.Plastic,     "Пластик"      },
            { ResourceType.Kettle,      "Чайник"       },
        };

        public static string DisplayName(this ResourceType type)
        {
            string name;
            return Names.TryGetValue(type, out name) ? name : type.ToString();
        }
    }
}
