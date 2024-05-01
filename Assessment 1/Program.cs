using System;

public class elec
{
    static void Main(string[] args)  // Entry point of the program
    {
        int customerid;
        string customername;
        int units; //Variables: customerid and units
        double charge;
        double surcharge = 0;
        double gross; //gross amount
        double net;  //net amount
     
        //INPUT DATA
        Console.WriteLine("INPUT ELECTRICITY BILL DATA");
        Console.WriteLine("Please Enter Customer ID");
        customerid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Enter Customer Name :");
        customername = Console.ReadLine();
        Console.WriteLine("Enter Units Consumed : ");
        units = Convert.ToInt32(Console.ReadLine());  

        // charge price points
        if (units < 200) // Up to 199 @$0.30
            charge = 0.30;
        else if (units >= 200 && units < 400) //200 and above but less than 400 @$0.32
            charge = 0.32;
        else if (units >= 400 && units < 600) //400 and above but less than 600 @$0.36
            charge = 0.36; 
        else                                  //600 and above @$0.42
            charge = 0.42; 

        //bill calculation
        gross = units * charge;  
        if (gross > 400) 
            surcharge = gross * 15 / 100.0;  //15% surchage if gross is over NZ$400

        net = gross + surcharge;  //net calculation

        //minimum charge NZ$15
        if (net < 15)
            net = 15; 

        //output
        Console.WriteLine("GENERATED BILL");
        Console.WriteLine("Customer IDNO                       :{0}", customerid);
        Console.WriteLine("Customer Name                       :{0}", customername);
        Console.WriteLine("Units Consumed                       :{0}", units);
        Console.WriteLine("Amount Charged @NZ$. {0}  per unit   :{1}", charge, gross);
        Console.WriteLine("Surchage Amount                     :{0}", surcharge);
        Console.WriteLine("Net Amount Paid By the Customer     :NZ${0}", net);
    }
}