using System;

namespace WindowsFormsApp.Models.Resources
{
    public abstract class Resource
    {
        private string name;
        private float price = 0;
        private ResourceType type;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Trim().Length > 0)
                    name = value;
                else
                    throw new ArgumentException("Name is not found");
            }
        }

        public ResourceType Type { get { return type; } }

        public float Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public Resource(string name, ResourceType type, float price)
        {
            this.type = type;
            this.price = price;
            Name = name;
        }
    }
}
