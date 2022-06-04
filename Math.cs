public class Math
{
    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("You cannot divide by zero today.");
        }
        
        return a / b;
    }
}
