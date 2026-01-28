namespace knightmoves;
public class JobOpenings
{   
    // Add your code here
    public string FirstName = "FirstName";
    public string JobTitle = "JobTitle";
    public string City = "City";

    public string PrintOpening(){
        //Add your code here
        return FirstName + " - " + JobTitle + " - " + City + "\r\n";
    }
}
