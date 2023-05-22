// Single Responsibility Principle
// Changes to the subscribe method impact every class that uses the student class
// Poor cohesion and tight coupling
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
        Console.WriteLine("Starting Save()");
        //use EF to save student to DB

        Console.WriteLine("End Save()");
    }

    public void Delete() 
    { 
        Console.WriteLine("Starting Delete()");

        //check if already subscribed courses then don't delete

        Console.WriteLine("End Delete()");
    }

    public IList<Course> Subscribe(Course cs) 
    { 
        Console.WriteLine("Starting Subscribe()");

        //apply business rules based on the course type 
        if(cs.Type == "online")
        {
            //validate
        }
        else if(cs.type == "live")
        {

        }

        //payment processing code

        //save course subscription to DB
          
        //send email confirmation code

        Console.WriteLine("End Subscribe()");
   }
}