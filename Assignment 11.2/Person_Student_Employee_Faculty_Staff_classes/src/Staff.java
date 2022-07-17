public class Staff extends Employee {

    //properties
    private String title;
    private String className = this.getClass().getSimpleName();
    
    //methods
    Staff(){}

    //getters and setters
    public String getTitle() {
        return this.title;
    }
    public void setTitle(String title) {
        this.title = title;
    }

    //unique toString call
    @Override
    public String toString(){
        return ("This class name is: " + className + " and their name is: " + this.getName());
    }
}
