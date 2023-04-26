using System;
namespace MyApplication{
// Interface
interface ICar
{
    void Price();
    void FuelType();//abstract method doesnt contain any implementation
 class Wagnor:ICar{
     public void Price(){
         Console.WriteLine("base price of vehicle is 6 lakhs \n");
     }
     
     public void FuelType(){
         Console.WriteLine("diesel and petrol models r available");
     }
     
 }
 
 class Execution{
     public static void Main(string[] args){
         Wagnor obj=new Wagnor();
         obj.Price();
         obj.FuelType();
     }
 }
}
}