
public class Person {

    //properties
    private String name;
    private String address;
    private String phoneNumber;
    private String emailAddress;
    private String className = this.getClass().getSimpleName();


    //methods
    Person(){}

    //getters and setters
    public String getName() {
        return this.name;
    }
    public String getAddress() {
        return this.address;
    }
    public String getPhoneNumber() {
        return this.phoneNumber;
    }
    public String getEmailAddress() {
        return this.emailAddress;
    }

    public void setName(String name) {
        this.name = name;
    }
    public void setAddress(String address) {
        this.address = address;
    }
    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }
    public void setEmailAddress(String emailAddress) {
        this.emailAddress = emailAddress;
    }

    //unique toString call
    @Override
    public String toString(){
        return ("This class name is: " + className + " and their name is: " + this.getName());
    }
}
