using System;
using System.Collections.Generic;
using System.Linq;
//using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
		
		
        public static void Main(string[] args)
        {
			FileDetails fd = new FileDetails();
			//string[] firstArgument={"/s"};
			//To call FileDetails.Version if the first argument is either of -v, --v, /v, --version
            //To call FileDetails.Size if the first argument is either of -s, --s, /s, --size
			
			if(args.Length > 0)
            {
               if(args[0]=="-v"||args[0]=="--v"||args[0]=="/v"||args[0]=="--version")
			   {
			    Console.WriteLine(fd.Version(args[0]));
			   }
				else if(args[0]=="-s"||args[0]=="--s"||args[0]=="/s"||args[0]=="--size")
				{
				Console.WriteLine(fd.Size(args[0]));
				}
				else
				{
					Console.WriteLine("Please check your input.");
				}
			   
            }  
              
            else
            {
                Console.WriteLine("No command line arguments found.");
            }
        }
    }
}
