// Interface Segregation Principle
// Clients should not be forced to depend on methods they do not use.
// The interface below is incredibly bloated and will drive increase coupling
//
public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);

    void AddCourse(Course cs);
    void EditCourse(Course cs);
    void DeleteCourse(Course cs);

    bool SubscribeCourse(Course cs);
    bool UnSubscribeCourse(Course cs);
    IList<Student> GetAllStudents();
    IList<Student> GetAllStudents(Course cs);

    IList<Course> GetAllCourse();
    IList<Course> GetAllCourses(Student std);
}

public class StudentRepository : IStudentRepository
{
    public void AddCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void AddStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public void DeleteCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void DeleteStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public void EditCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void EditStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public IList<Course> GetAllCourse()
    {
        //implementation code removed for better clarity
    }

    public IList<Course> GetAllCourses(Student std)
    {
        //implementation code removed for better clarity
    }

    public IList<Student> GetAllStudents()
    {
        //implementation code removed for better clarity
    }

    public IList<Student> GetAllStudents(Course cs)
    {
        //implementation code removed for better clarity
    }

    public bool SubscribeCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public bool UnSubscribeCourse(Course cs)
    {
        //implementation code removed for better clarity
    }
}
