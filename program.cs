using System;
    namespace  ArraySecond
    {
        
     class array
     {
         public static int prep(int[] arr,int total)
         {
             int temp;
             for(int i = 0; i< total;i++) 
             {
                for(int j = i+1;j<total;j++) 
                {
                    if(arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }

                }
               
             }
             return arr[1];

         }
        static void Main(string[] args)
        {
            int [] arr = {4,7,8,3,6};
           Console.WriteLine("smallest:" +prep(arr,5));
           
         }
     }
    }


