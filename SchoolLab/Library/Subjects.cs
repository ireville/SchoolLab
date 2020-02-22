
namespace Library
{
    public class Subjects
    {
        public string Icon { get; set; }

        public string Name { get; set; }

        public Subjects(string icon, string name)
        {
            Icon = icon;
            Name = name;
        }

        public Subjects()
        {
        }
    }
}