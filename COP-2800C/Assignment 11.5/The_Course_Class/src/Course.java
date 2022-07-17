import java.util.*;

public class Course {

    private String courseName;
    private ArrayList<String> students;
    private int numberOfStudents;

    //Constructors
    
    public Course(String courseName){
        this.courseName = courseName;
    }

    //getters and setters


    public String[] getStudents(){
        String[] temp = new String[students.size()];
		return students.toArray(temp);
    }

    public int getNumberOfStudents(){
        return this.numberOfStudents;
    }

    public String getCourseName(){
        return this.courseName;
    }

    //Methods


    public void addStudent(String student) {
		this.students.add(student);
        this.students.toArray();
	}

    
    public void dropStudent(String student) {
		students.remove(student);
	}

    public void clear(){

        this.students.removeAll(this.students);

    }

    public void clearAndReplace(){
        this.students = new ArrayList<String>(students);
        this.numberOfStudents = 0;
    }
}
