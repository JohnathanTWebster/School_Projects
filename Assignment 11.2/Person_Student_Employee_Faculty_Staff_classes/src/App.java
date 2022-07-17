public class App {
    public static void main(String[] args) throws Exception {

        //create all objects
        Person myPerson = new Person();
        Student myStudent = new Student();
        Employee myEmployee = new Employee();
        FacultyMember myFacultyMember = new FacultyMember();
        Staff myStaff = new Staff();

        //set their names
        myPerson.setName("Manny");
        myStudent.setName("John");
        myEmployee.setName("Jose");
        myFacultyMember.setName("Mary");
        myStaff.setName("Savannah");

        //display their names
        System.out.println(myPerson.toString());
        System.out.println(myStudent.toString());
        System.out.println(myEmployee.toString());
        System.out.println(myFacultyMember.toString());
        System.out.println(myStaff.toString());
    }
}
