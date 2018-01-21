using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {        
        try{
            Console.WriteLine("Moi ban nhap vao duong dan file can xu ly: ");
            string duongdan = Console.ReadLine();
            string regex = @"\s+[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+.[A-Za-z]{2,4}$";        
            using (StreamWriter writer = new StreamWriter("output.txt")){
                using (StreamReader reader = new StreamReader(duongdan))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {   
                        Match email = Regex.Match(line, regex);                
                        if(email.Index>0){                                             
                            string lineoutput = "user: " + line.Substring(0,email.Index-1) + " - email: " + email.Value;
                            Console.WriteLine(lineoutput);
                            writer.WriteLine(lineoutput);
                        }                
                    }
                    Console.WriteLine("File output.txt duoc luu cung thu muc voi file goc");
                }
            }       
        }
        catch(System.IO.FileNotFoundException e){
            Console.WriteLine(e.Message);
        }
        catch(SystemException e){
            Console.WriteLine(e.Message);
        }
    }
}