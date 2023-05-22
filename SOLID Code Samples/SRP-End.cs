public class Student
{
	public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }
    public string email { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }

    public void Save() 
    { 
        Logger.Log("Starting Save()");
      
        _studentRepo.Save(this);

        Logger.Log("End Save()");
    }

    public void Delete() 
    { 
        Logger.Log("Starting Delete()");

        //check if already subscribed courses

        _studentRepo.Delete(this);

        Logger.Log("End Delete()");
    }
}

Public class Logger
{
	Public static void Log(string message)
    {
		Console.WriteLine(message);
    }
}

public class StudentRepository()
{
	Public bool Save(Student std)
    {
        Logger.log("Starting Save()");

        //use EF to add a new student or update existing student to db

        Logger.log("Ending Saving()");
    }

    public bool Delete() 
    { 
	    Logger.log("Starting Delete()");

        //use EF to delete a student 

        Logger.Log("Ending Delete()");
    }

    public bool SaveCourse(Student std, Course cs) 
    { 
	    Logger.log("Starting SaveCourse()");

        //use EF to save a course for a student

        Logger.Log("Ending SaveCourse()");
    }
}

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }

    public void Subscribe(Student std)
    {
        Logger.Log("Starting Subscribe()");

        //apply business rules based on the course type live, online, offline, if any 
        if (this.Type == "online")
        {
            //subscribe to online course 
        }
        else if (this.Type == "live")
        {
            //subscribe to offline course 
        }

        // payment processing
        PaymentManager.ProcessPayment();

        //create CourseRepository class to save student and course into StudentCourse table  

        // send confirmation email
        EmailManager.SendEmail();

        Logger.Log("End Subscribe()");
    }
}

Public class EmailManager
{
	Public static void SendEmail(string recEmailed, string senderEmailId, string subject, string message)
    {
	    // smtp code here
    }	 
}

Public class PaymentManger
{
	Public static void ProcessPayment()
    {
		//payment processing code here
    }
}