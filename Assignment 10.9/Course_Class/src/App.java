public class App {
    public static void main(String[] args) throws Exception {
        Course myCourse = new Course("Programming in Java");

        for (int i = 0; i < 3; i++) {
            myCourse.addStudent("Student " + (i + 1));
        }

        myCourse.dropStudent("Student " + (3));

        String[] students = myCourse.getStudents();

        for (int i = 0; i < students.length; i++) {
            System.out.printf("%-12s ", students[i]);
            if ((i + 1) % 5 == 0) {
                System.out.printf("\n");
            }
            if(students[(i + 1)] == null){
                break;

            }
        }

    }
}
