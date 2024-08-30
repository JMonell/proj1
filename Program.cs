namespace proj1;

class Program
{
    static void Main(string[] args){
        Console.WriteLine("Program begin:");
        
        MyLoop(4);
        MyLoop(10);

        System.Console.WriteLine("Program end");

    }

    static void MyLoop(int nrIterations){
        int i = 0;
        int sum = 0;

        for(int j = 0; j <nrIterations; j++){
            Console.WriteLine($"i = {i}\nsum = {sum}\n");
            i++;
            sum += i;
            if(sum==6){
                System.Console.WriteLine($"we have now the magical sum of 3");
            }
        }
    }
}
