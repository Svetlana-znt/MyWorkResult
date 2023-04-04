string[] arr1;
int count;
string s;
string[] arr;

Console.WriteLine("Enter strings:");
count = 0;
arr1 = new string[count];
do
    {
        s = Console.ReadLine();
        if (s!="")
           {
                count++;
                arr = new string[count];
                for (int i = 0; i < count-1; i++)
                    arr[i] = arr1[i];
                arr[count - 1] = s;
                arr1 = arr;
            }
    } 
