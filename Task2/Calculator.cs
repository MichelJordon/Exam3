public class Calculator
{
     private double num1;
     private double num2;

public Calculator(int num1 ,int num2)
{
    this.num1 = num1;
    this.num2 = num2;

}
     public double Add()
     {
        return num1 + num2;
     }
     public double Substract()
     {
         if( num1 >= num2 )
            return num1 - num2;
         return num2 - num1;
     }
     public double Multiply()
     {
        return num1 * num2;
     }
     public double Divide()
     {
        return num2 / num1;
     }

}