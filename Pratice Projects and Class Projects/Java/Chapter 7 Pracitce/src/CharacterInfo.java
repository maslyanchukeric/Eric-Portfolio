public class CharacterInfo
{
    public static void main(String[] args)
    {
        char aChar = 'A'; // You can change this to experiment with different characters

        System.out.println("The character is " + aChar);
        System.out.println("is defined: " + Character.isDefined(aChar));
        System.out.println("is digit: " + Character.isDigit(aChar));
        System.out.println("is letter: " + Character.isLetter(aChar));
        System.out.println("is letter or digit: " + Character.isLetterOrDigit(aChar));
        System.out.println("is lower case: " + Character.isLowerCase(aChar));
        System.out.println("is upper case: " + Character.isUpperCase(aChar));
        System.out.println("to upper case: " + Character.toUpperCase(aChar));
        System.out.println("to lower case: " + Character.toLowerCase(aChar));
        System.out.println("is space character: " + Character.isSpaceChar(aChar));
        System.out.println("is whitespace: " + Character.isWhitespace(aChar));
    }
}