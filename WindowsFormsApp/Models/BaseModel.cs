namespace WindowsFormsApp.Models
{
    public abstract class BaseModel
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BaseModel(string name)
        {
            this.name = name;
        }
    }
}
