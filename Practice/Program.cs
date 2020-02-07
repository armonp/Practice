namespace Practice {
    class Program {
        static void Main(string[] args) {

            var majors = new Major[] {
                new Major(10, "Engineering", 1300),
                new Major(20, "Accounting", 1000),
                new Major(30, "Nursing", 1000),
                new Major(40, "Math", 1300),
                new Major(50, "Education", 1100)
            };

            for (var idx = 0; idx < majors.Length; idx++) {
                var major = majors[idx];
                major.Print();
            }

            var students = new Student[] {
                new Student(10, "Ken", "Bone", 1500, 3.6, majors[0]),
                new Student(11, "Kim", "Kessling", 1175, 3.4, majors[2]),
                new Student(12, "Tracy", "Tusky", 1350, 3.5, majors[3]),
                new Student(13, "Fred", "Flintstone", 600, 1.0, majors[1])
            };

            foreach (var student in students){
                student.Print();
            }

            var Prof = new Instructor(10, "Prof", "Dolittle", 25);
            //Prof.Print();
        }
    }
}