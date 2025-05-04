package digital_root;

public class Main {

    public static void testDigitalRoot() {
        System.out.println("Testing Digital Root...");

        // Test cases
        assert Number.DigitalRoot(16) == 7 : "Test case 1 failed";
        assert Number.DigitalRoot(942) == 6 : "Test case 2 failed";
        assert Number.DigitalRoot(132189) == 6 : "Test case 3 failed";
        assert Number.DigitalRoot(493193) == 2 : "Test case 4 failed";

        System.out.println("All test cases passed!");
    }

    public static void main(String[] args) {
        testDigitalRoot();
    }
}
