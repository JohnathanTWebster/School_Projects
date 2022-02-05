import java.util.*;

public class App {

    public static char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".toCharArray(); //Convert the alphabet to an arr
    public static char[] VOWELS = "aeiou".toCharArray(); //Convert vowels to an arr
    static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) throws Exception {

        System.out.print("Enter a letter: "); //Prompt the user to enter a value
        char letter = scanner.next().charAt(0);
        
        alphabetSearch(letter, ALPHABET);  //Insert the entered value into the function      
    }
    
    public static void alphabetSearch(char x, char arr[]){ 
        
        char originalCopy = x; //Store to original value
        char copy = x; //Copy of the original value
        copy = Character.toLowerCase(copy); //Convert the value to lowercase


        for (int index = 0; index < arr.length; index++){ //Itterate through every value in the provided arr

            if (copy == arr[index]){ //If the value is at the provided index location enter the loop 
                switch(copy){
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    System.out.print(originalCopy + " is a vowel.");
                    return;
                    default:
                    System.out.println(originalCopy + " is a consonant.");
                    return;
                }
            }
            else{
                continue; //If the entered value is not at the present index, continue.
            }
        }
        System.out.println(originalCopy + " is not valid.");
    }
}


