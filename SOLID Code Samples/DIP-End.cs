// Dependency Inversion Principle
//
public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }


        private IStudentRepository _stdRepo;

        public Student(IStudentRepository stdRepo)
        {
            _stdRepo = stdRepo;
        }
        public void Save()
        {
            _stdRepo.AddStudent(this);
        }

    }

public interface IStudentRepository
    {
        void AddStudent(Student std);
        void EditStudent(Student std);
        void DeleteStudent(Student std);

        
        IList GetAllStudents();
        

    }

public class StudentRepository : IStudentRepository
    {
        

        public void AddStudent(Student std)
        {
            //code removed for clarity
        }

        public void DeleteStudent(Student std)
        {
            //code removed for clarity
        }

        public void EditStudent(Student std)
        {
            //code removed for clarity
        }

        
        public IList GetAllStudents()
        {
            //code removed for clarity
        }

    }