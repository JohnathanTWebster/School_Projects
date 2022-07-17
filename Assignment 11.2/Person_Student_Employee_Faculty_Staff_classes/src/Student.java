public class Student extends Person {
    private String classStatus;
    private String className = this.getClass().getSimpleName();

    public String getClassStatus() {
        return this.classStatus;
    }
    public void setClassStatus(String classStatus) {
        this.classStatus = classStatus;
    }
    @Override
    public String toString(){
        return ("This class name is: " + className + " and their name is: " + this.getName());
    }
}
