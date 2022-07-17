
public class Employee extends Person{

    //properties
    private String office;
    private int salary;
    MyDate dateHired;
    private String className = this.getClass().getSimpleName();


    //methods
    Employee(){
        this.dateHired = new MyDate();
    }

    //getters and setters
    public String getOffice() {
        return this.office;
    }
    public int getSalary() {
        return this.salary;
    }
    public String getDateHired() {
        return  String.valueOf(this.dateHired.getYear() +"/"+this.dateHired.getMonth() + "/" +this.dateHired.getDay());
    }
    public void setOffice(String office) {
        this.office = office;
    }
    public void setSalary(int salary) {
        this.salary = salary;
    }
    public String setDateHired(String dateHired) {
        return String.valueOf(this.dateHired);
    }

    //unique toString call
    @Override
    public String toString(){
        return ("This class name is: " + className + " and their name is: " + this.getName());
    }
}
