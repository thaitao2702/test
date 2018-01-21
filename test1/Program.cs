using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDigits();
        }

        static void Factorial (){
            try{
                Console.WriteLine("Nhap vao so can tinh giai thua:");
                ushort sonhapvao = Convert.ToUInt16(Console.ReadLine() ) ;
                int a = 1;
                int output = 1;
                while (a<= sonhapvao){
                    output = output*a;
                    a+= 1;                
                }
                Console.WriteLine("Giai thua cua {0} la: {1}", sonhapvao, output);
            }            
            catch (System.OverflowException){
                Console.WriteLine("Ban phai nhap vao 1 so nguyen duong");
            }
            catch (System.Exception){
                Console.WriteLine("Ban phai nhap vao 1 so");
            }
        }

        static void CountDigits(){
                try {
                    Console.WriteLine("Nhap vao 1 so:");
                    ushort sonhapvao = Convert.ToUInt16(Console.ReadLine());
                    string string_1 = Convert.ToString(sonhapvao);
                    int tong = 0;
                for(int i = 0 ;i<string_1.Length;i++){                    
                    tong += (int)Char.GetNumericValue(string_1[i]);
                }
                Console.WriteLine("Tong cac chu so cua {0} la {1}", sonhapvao, tong);
                }
            catch (System.OverflowException){
                Console.WriteLine("Ban phai nhap vao 1 so nguyen duong");
            }
            catch (System.Exception){
                Console.WriteLine("Ban phai nhap vao 1 so");
            }

        }

        static void Capitalise(){
            try {
                Console.WriteLine("Nhap vao chuoi ky tu:");
                string chuoi = Console.ReadLine().ToLower();
                string[] words = chuoi.Split(' ');
                string output ="";
                string dau_cach =" "; 
                for (int x = 0; x<words.Length; x++){
                    dau_cach = (x == 0)? "": " ";
                    output = output  + dau_cach + char.ToUpper(words[x][0]) + words[x].Substring(1,words[x].Length-1);
                }            
                Console.WriteLine("Chuoi da xu ly: {0}", output);
                }
            catch(System.Exception err){
                Console.WriteLine(err.Message);
            }
        }

        static void SecondLargest(){
            Console.WriteLine("Ban muon nhap vao mang co bao nhieu so: ");            
            int chieudai = Convert.ToInt32(Console.ReadLine());
            int[] mang = new int[chieudai];            
            for (int x = 0; x< chieudai; x++){
                Console.WriteLine("Nhap vao so: ");
                mang[x] = Convert.ToInt32(Console.ReadLine());
            }            
            Array.Sort(mang);   
            Console.WriteLine("So lon thu hai la {0}", mang[chieudai-2]);
        }

        static void QuadraticFunc(){
            try{
                Console.WriteLine("Ban nhap vao so a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ban nhap vao so b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ban nhap vao so c: ");
                int c = Convert.ToInt32(Console.ReadLine());
                int delta = b*b-4*a*c;
                if(a==0){
                    throw (new NotSecondOrder("ban phai nhap vao a khac 0"));
                }
                else{
                    if (delta>0){
                    double nghiem1 = (-b +Math.Sqrt(delta))/2/a;
                    double nghiem2 = (-b-Math.Sqrt(delta))/2/a;
                    Console.WriteLine("Phuong trinh co 2 nghiem: {0} , {1}", nghiem1, nghiem2);
                    }
                    else if (delta == 0){
                        int nghiem = -b/2/a;
                        Console.WriteLine("Phuong trinh co 1 nghiem kep: {0}", nghiem);
                    }
                    else if (delta<0){
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }              
            }
            catch(NotSecondOrder err){
                Console.WriteLine(err.Message);
            }
            catch(System.Exception err){
                Console.WriteLine(err.Message);
            }  
        }
    }
    public class NotSecondOrder : Exception
    {
        public NotSecondOrder(string message)
            : base(message)
        {
        }
    }
}