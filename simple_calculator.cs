using System;
namespace simple_calculator{
    class Calculator {
        static void Main(string [] args) {
            int num1 = 0, num2 = 0;
            Console.WriteLine("Enter the first number here:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number here:");
            num2 = Convert.ToInt32(Console.ReadLine());
            char operator_cal = 'd';
            Console.WriteLine("Enter here the operation with which you want to make a calculation:");
            string operator_cal_input = Console.ReadLine();
            operator_cal = Convert.ToChar(operator_cal_input);
            if (operator_cal == '+') {
                int add = num1+num2;
                Console.WriteLine("Result:Add:"+add);
            }
            else if (operator_cal == '-') {
                int first_num_ques_answer = 0;
                Console.WriteLine("Which number to use first, the first (1) or the second (2)?:");
                first_num_ques_answer = Convert.ToByte(Console.ReadLine());
                if (first_num_ques_answer == 1) {
                    int sub = num1 - num2;
                    Console.WriteLine("Result:Sub:"+sub);
                }
                else if (first_num_ques_answer == 2) {
                    int sub = num2 - num1;
                    Console.WriteLine("Result:Sub:"+sub);
                }
                else {
                    Console.WriteLine("err");
                }
            }
            else if (operator_cal == '*') {
                int mul = num1*num2;
                Console.WriteLine("Result:Mul:"+mul);
            }
            else if (operator_cal == '/') {
                int first_num_ques_answer = 0;
                first_num_ques_answer = Convert.ToInt16(Console.ReadLine());
                double num1d = Convert.ToDouble(num1);
                double num2d = Convert.ToDouble(num2);
                if (first_num_ques_answer == 1) {
                    double div = num1d/num2d;
                    Console.WriteLine("Result:Div:"+div);
                }
                else if (first_num_ques_answer == 2) {
                    double div = num2d/num1d;
                    Console.WriteLine("Result:Div:"+div);
                }
                else {
                    Console.WriteLine("err");
                }
            }
            else {
                Console.WriteLine("err...");
            }
            Console.ReadKey();
        }
    }
}
