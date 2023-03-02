using System;

namespace Homework1 {
    class Program {
    static void Main(string[] args) {
        Console.Write("Input number: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Input Password: ");
        string y = Console.ReadLine();
        
        string y1 = "CIA";
        string y2 = "FBI";
        string y3 = "NSA";

        int num_6 = x % 10;
        int num_5 = (x /10) %10;
        int num_4 = (x /100) %10;
        int num_3 = (x /1000) %10;
        int num_2 = (x /10000) %10;
        int num_1 = (x /100000) %10;

         if ( y1 == "CIA" ) {
                Console.WriteLine("TRUE");
        } else
            {
                Console.WriteLine("FALSE");
            }
            if (num_6 % 3 == 0){
                Console.WriteLine("TRUE");      
             } else
                {
                 Console.WriteLine("FALSE");   
                }
                if (num_5 != 1 && num_5 != 3 && num_5 != 5){
                    Console.WriteLine("TRUE");
                } else
                        {
                            Console.WriteLine("FALSE");
                        }
                        if (num_3 > 5 && num_3 != 8) {
                            Console.WriteLine("TRUE");
                        } else
                            {
                                Console.WriteLine("FALSE");
                            }
                       
                            if (y2 == "FBI"){
                                Console.WriteLine("TRUE");
                            } else
                                {
                                    Console.WriteLine("FALSE");
                                }
                                if (num_1 > 3 && num_1 < 8 ){
                                    Console.WriteLine("TRUE");
                                } else
                                    {
                                        Console.WriteLine("FALSE");
                                    }
                                    if (num_4 % 2 == 0 && num_4 != 6){
                                        Console.WriteLine("TRUE");
                                    } else
                                        {
                                            Console.WriteLine("FALSE");
                                        }
                                        if (num_2 % 2 != 0){
                                            Console.WriteLine("TRUE");
                                        } else 
                                            {
                                                Console.WriteLine("FALSE");
                                            }
                                         
                                            if (y3 == "NSA"){
                                                Console.WriteLine("TRUE");
                                            } else
                                                {
                                                 Console.WriteLine("FALSE");
                                                }
                                                if ((num_6 == 1) || (num_6 == 2)|| (num_6 == 3) || (num_6 == 5)|| (num_6 == 6) || (num_6 == 10)|| (num_6 == 15) || (num_6 == 30)){
                                                    Console.WriteLine("TRUE");
                                                } else
                                                    {
                                                    Console.WriteLine("FALSE");
                                                    }
                                                    if (num_3 % 3 == 0 && num_3 % 2 != 0){
                                                        Console.WriteLine("TRUE");
                                                    } else
                                                        {
                                                          Console.WriteLine("FALSE");  
                                                        }
                                                        if(num_6 == 7 && num_5 == 7 && num_4 == 7 && num_3 == 7 && num_2 == 7 && num_1 == 7){
                                                            Console.WriteLine("TRUE");
                                                        } else
                                                            {
                                                              Console.WriteLine("FALSE");   
                                                            }
                                                            if  (y1 != "CIA" && y2 != "FBI" && y3 != "NSA") {
                                                                Console.WriteLine("FALSE");
                                                            }
          }
        }             
        }
       
     