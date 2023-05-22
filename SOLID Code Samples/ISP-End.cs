// Interface Segregation
// The example also violated the SRP

public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);

    bool SubscribeCourse(Course cs);
    bool UnSubscribeCourse(Course cs);
    IList<Student> GetAllStudents();
    IList<Student> GetAllStudents(Course cs);
}

public interface ICourseRepository
{
    void AddCourse(Course cs);
    void EditCourse(Course cs);
    void DeleteCourse(Course cs);

    IList<Course> GetAllCourse();
    IList<Course> GetAllCourses(Student std);
}