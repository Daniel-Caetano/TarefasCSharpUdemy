namespace ExercicioGenericsSetDictionary.Entities
{
    internal class Students
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Students()
        {
        }

        public Students(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
