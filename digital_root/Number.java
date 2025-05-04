package digital_root;

public class Number {

    public static int DigitalRoot(long n)
    {
        int sum = 0;

        while (n > 0){
        
            sum += (int)(n % 10);
            n = n / 10;
        }
        
        sum = (sum <10) ? sum : DigitalRoot(sum);

        return sum;
    }
}


