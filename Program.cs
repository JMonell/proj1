namespace proj1;

class Program
{
    static void Main(string[] args){
        Console.WriteLine("Program begin:");
        int i = 0;
        int sum = 0;

        for(int j = 0; j <4; j++){
            Console.WriteLine($"i = {i}\nsum = {sum}");
            i++;
            sum += i;
            if(sum==6){
                System.Console.WriteLine($"we have now the magical sum of 3");
            }
        }
        System.Console.WriteLine("Program end");

/*
i = 0
s=0 
i=1
s=1
i=2
s=3
print
i=3
s=6

*/

    }
}
