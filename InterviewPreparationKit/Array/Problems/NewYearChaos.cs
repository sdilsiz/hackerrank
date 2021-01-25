using System.Linq;
public class NewYearChaos
{
    public static void Run()
    {


    }

    static void minimumBribes(int[] q)
    {
        int count = 0;

        //always keep track of min three vlaues observed

        int midOfThree = int.MaxValue;
        int maxOfThree = int.MaxValue;
        int minOfThree = int.MaxValue;

        //iterating from left to right
        for (int i = q.Length - 1; i >= 0; i--)
        {
            //person has no way to move more than two positions -> wrong
            if ((q[i] - i) > 3)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
            else
            {
                //means current value has passed at least 3 values -> wrong
                if (q[i] > maxOfThree)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else if (q[i] > midOfThree)
                { //means -> current value has bribed 2 ppl
                    count = count + 2;
                }
                else if (q[i] > minOfThree)
                { //means-> current value has bribed 1 person.
                    count = count + 1;
                }

                //Now adjust minThree values comparing, taking the current vlaue to account
                if (q[i] < minOfThree)
                {
                    maxOfThree = midOfThree;
                    midOfThree = minOfThree;
                    minOfThree = q[i];
                }
                else if (q[i] < midOfThree)
                {
                    maxOfThree = midOfThree;
                    midOfThree = q[i];
                }
                else if (q[i] < maxOfThree)
                {
                    maxOfThree = q[i];
                }
            }
        }
        Console.WriteLine(count);

    }

}