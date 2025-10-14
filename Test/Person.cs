namespace Test
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public override int GetHashCode()
        {
            return Name.Length + Age;
        }
    }
}
