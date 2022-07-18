```java
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class RegexPracticeTester {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("Enter your regex pattern:");
            String patternString = scanner.nextLine();
            if (patternString.equals("exit")) {
                break;
            }
            Pattern pattern = Pattern.compile(patternString);
            System.out.println("Enter text to search:");
            String text = scanner.nextLine();
            Matcher matcher = pattern.matcher(text);
            boolean found = false;
            while (matcher.find()) {
                System.out.println("Found the text \"" + matcher.group() + "\" starting at index " +
                        matcher.start() + " and ending at index " + matcher.end());
                found = true;
            }
            if (!found) {
                System.out.println("No match found.");
            }
        }
    }
}
```