using System;

namespace Test
{
    class amountOfBoatToRent
    {
        static void Main(string[] args)
        {
            calculate_price r = new calculate_price();
            r.Input_number();
        //  r.Acceptdetails();
        //  r.Display();
        //  Console.ReadLine(); 
        }
    }

    class calculate_price{
        public void Input_number(){
            int number;
			Console.Write("Input : ");
			number = Convert.ToInt32(Console.ReadLine());
            int[] result = calculate_mod(number);
            int count = 0;

            Console.Write("Output : ");
            string t=  "", m = "",l = "", merge = "";
            int count_p = 0;
            foreach (int x in result)
            {
                if(count == 0  && x != 0){
                    t += String.Concat("Tiny =", x);
                    count_p  += x*5;
                }else if(count == 1  && x != 0){
                    m += String.Concat(", Meduim =", x);
                    count_p  += x*8;
                }if(count == 2  && x != 0){
                    l += String.Concat(", Large =", x);
                    count_p  += x*12;
                }
                
                count++;
            }

            merge += t + m + l;
            merge += String.Concat(", Price =", count_p);

            Console.WriteLine(merge);
         
        }
        public int[] calculate_mod(int number)
            
            {   
                // Console.Write(number);
                int[] result = new int[3];
                int[] result_temp = new int[3];

                if(number >= 15){
                    int price = number % 15;
                    result[2] += number / 15;
                    if(price != 0){

                        result_temp = calculate_mod(price);
                        
                        if(result_temp.Length != 0){
                            int count = 0;
                            foreach (int element in result_temp)                           
                                {    
                               
                                    result[count] += element;
                                    count++;
                                }
                            }
                    }

                }else if(number >= 10){
              
                    int price = number % 10;

                    result[1] += number / 10;

                    if(price != 0){
                        result_temp = calculate_mod(price);
                        if(result_temp.Length != 0){
                            int count = 0;
                            foreach (int element in result_temp)
                                {    
                                    result[count] += element;
                                    count++;
                                }
                            }
                    }
                
                }else{
                    
                    result[0] += 1;
                } 

                return result;


            }
        }
    }

