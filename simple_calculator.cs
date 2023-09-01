using System;
namespace simple_calculator{
    class Calculator {
        static void Main(string [] args) {
            double num1 = 0d, num2 = 0d;
            Console.WriteLine("Enter the first number here:");
            num1 = Convert.ToDouble(Console.ReadLine());
            char ques;
            Console.WriteLine("Would you like to calculate a certain percentage of that number? Press [Y] to indicate a yes or [N] to indicate a no.");
            ques = Convert.ToChar(Console.ReadLine());
            if (ques == 'Y'){
                Console.WriteLine("Enter the percentage to determine the result:");
                double percentage = Convert.ToDouble(Console.ReadLine());
                double certain_percentage_calc = ((percentage/100)*num1);
                Console.WriteLine(certain_percentage_calc);
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (ques == 'N') {
                char question;
                Console.WriteLine("Would you like to use the square root? Press [Y] to indicate a yes or [N] to indicate a no.");
                question = Convert.ToChar(Console.ReadLine());
                if (question == 'Y'){
                    double sqrt_res = Math.Sqrt(num1);
                    Console.WriteLine("Result:Sqrt:"+sqrt_res);
                }
                else if (question == 'N'){
                    Console.WriteLine("Enter the second number here:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    char operator_cal;
                    Console.WriteLine("Enter here the operation with which you want to make a calculation:");
                    operator_cal = Convert.ToChar(Console.ReadLine());
                    if (operator_cal == '+') {
                        double add = num1+num2;
                        Console.WriteLine("Result:Add:"+add);
                    }
                    else if (operator_cal == '-') {
                        int first_num_ques_answer;
                        Console.WriteLine("Which number to use first, the first (1) or the second (2)?:");
                        first_num_ques_answer = Convert.ToByte(Console.ReadLine());
                        if (first_num_ques_answer == 1) {
                            double sub = num1 - num2;
                            Console.WriteLine("Result:Sub:"+sub);
                        }
                        else if (first_num_ques_answer == 2) {
                            double sub = num2 - num1;
                            Console.WriteLine("Result:Sub:"+sub);
                        }
                        else {
                            Console.WriteLine(false );
                        }
                    }
                    else if (operator_cal == '*') {
                        double mul = num1*num2;
                        Console.WriteLine("Result:Mul:"+mul);
                    }
                    else if (operator_cal == '/') {
                        int first_num_ques_answer;
                        Console.WriteLine("Which number to use first, the first (1) or the second (2)?:");
                        first_num_ques_answer = Convert.ToByte(Console.ReadLine());
                        if (first_num_ques_answer == 1) {
                            double div = num1/num2;
                            Console.WriteLine("Result:Div:"+div);
                        }
                        else if (first_num_ques_answer == 2) {
                        double div = num2/num1;
                        Console.WriteLine("Result:Div:"+div);
                        }
                        else {
                            Console.WriteLine(false);
                        }
                    }
                    else if (operator_cal == '^'){
                        int first_num_ques_answer;
                        Console.WriteLine("Which number to use first, the first (1) or the second (2)?:");
                        first_num_ques_answer = Convert.ToByte(Console.ReadLine());
                        if (first_num_ques_answer == 1) {
                            double result = Math.Pow(num1,num2);
                            Console.WriteLine("Result:Pow:"+result);
                        }
                        else if (first_num_ques_answer == 2) {
                            double result = Math.Pow(num2,num1);
                            Console.WriteLine("Result:Pow:"+result);
                        }
                        else {
                            Console.WriteLine(false);
                        }
                    }
                    else if (operator_cal == '%') {
                        int first_num_ques_answer;
                        Console.WriteLine("Which number to use first, the first (1) or the second (2)?:");
                        first_num_ques_answer = Convert.ToByte(Console.ReadLine());
                        if (first_num_ques_answer == 1){
                            double result = num1%num2;
                            Console.WriteLine("Result:Mod:"+result);
                        }
                        else if (first_num_ques_answer == 2){
                            double result = num2%num1;
                            Console.WriteLine("Result:Mod:"+result);
                        }
                        else {
                            Console.WriteLine(false);
                        }
                    }
                    else {
                        Console.WriteLine(false);
                    }
                    Console.ReadKey();
                }
                else {
                    Console.WriteLine(false);
                }
                Console.ReadKey();
            }
            else {
                Console.WriteLine(false);
            }
        }
    }
}
