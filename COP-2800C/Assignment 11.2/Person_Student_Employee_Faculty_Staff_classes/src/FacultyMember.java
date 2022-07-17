public class FacultyMember extends Employee{


    //properties
    private String officeHours;
    private String rank;
    private String className = this.getClass().getSimpleName();



    //methods
    FacultyMember(){}

    //getters and setters
    public String getOfficeHours() {
        return this.officeHours;
    }
    public String getRank() {
        return this.rank;
    }
    public void setOfficeHours(String officeHours) {
        this.officeHours = officeHours;
    }
    public void setRank(String rank) {
        this.rank = rank;
    }

    //unique toString call
    @Override
    public String toString(){
        return ("This class name is: " + className + " and their name is: " + this.getName());
    }
    
}
