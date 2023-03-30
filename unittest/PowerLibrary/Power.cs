namespace PowerLibrary;
public class Power
{
    public static double PowerFunc(double numberOne, double numberTwo, double numberThree){
        double first_result = Math.Pow(numberOne, numberTwo);
        double final_result = Math.Pow(first_result, numberThree);
        return final_result;
    }
    public static double PowerFunc(double numberOne, double numberTwo)
    {
        double final_result = Math.Pow(numberOne, numberTwo); 
        return final_result;
    }
}
