using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class Recipe
    {
        public int id;
        public string name;
        public List<ResourceAmount> requiredResourcesList = new List<ResourceAmount>();
        public List<ResourceAmount> receivedResourcesList = new List<ResourceAmount>();
        public int duration;
    }
}