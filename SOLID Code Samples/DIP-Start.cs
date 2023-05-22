// Dependency Inversion Principle
// High-level modules should not depend on low-level modules. Both should depend on abstraction
//
// You can identify a class is depends on another class if it creates an object of another class
//
// Here the Student class has an inbuilt dependency on the StudentRepository class (not good!!)
public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

	// tight coupling
        private StudentRepository _stdRepo = new StudentRepository();
       
 public Student()
        {

        }
        public void Save()
        {
            _stdRepo.AddStudent(this);
        }

    }

public class StudentRepository 
    {
        

        public void AddStudent(Student std)
        {
            //EF code removed for clarity
        }

        public void DeleteStudent(Student std)
        {
            //EF code removed for clarity
        }

        public void EditStudent(Student std)
        {
            //EF code removed for clarity
        }

        
        public IList GetAllStudents()
        {
            //EF code removed for clarity
        }

    }