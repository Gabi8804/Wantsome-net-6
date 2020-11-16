namespace School
{
    internal class Discipline : Comment
    {
        public string Name { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get;private set; }

        public Discipline(string name,int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }
        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
            this.Comments = comment;
        }
    }
}