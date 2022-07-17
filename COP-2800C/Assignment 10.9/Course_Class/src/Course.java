public class Course {

    private String courseName;
    private String[] students = new String[100];
    private int numberOfStudents;

    //Constructors
    
    public Course(String courseName){
        this.courseName = courseName;
    }

    //getters and setters


    public String[] getStudents(){
        return this.students;
    }

    public int getNumberOfStudents(){
        return this.numberOfStudents;
    }

    public String getCourseName(){
        return this.courseName;
    }

    //Methods


    public void addStudent(String student){

        if(this.numberOfStudents >= this.students.length){
            String temp[] = new String[this.students.length * 2];
            System.arraycopy(this.students, 0, temp, 0, this.students.length);
            this.students = temp;
        }
        this.students[this.numberOfStudents++] = student;
        
    }

    
    public void dropStudent(String student){
        
        for (int i = 0; i < this.students.length; i++){

            if(student.equalsIgnoreCase(students[i])){
                this.students[i] = null;
                numberOfStudents--;
                while (i < numberOfStudents) {
                    students[i] = students[i + 1];
                    i++;
                }
                break;

            }   

        }

    }

    public void clear(){

        for (int i = 0; i < this.students.length; i++){
            this.students[i] = null;
        }

    }

    public void clearAndReplace(){
        this.students = new String[100];
        this.numberOfStudents = 0;
    }
}
