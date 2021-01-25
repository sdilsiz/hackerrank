

// https://www.hackerrank.com/challenges/counting-valleys?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup


public class CountingValleys
{

    public static int countingValleys(int steps, string path)
    {

        var valleyCounter = 0;
        var seaLevel = 0;
        for (var i = 0; i < steps; i++)
        {
            var previousSeaLevel = seaLevel;
            if (path[i].ToString() == "D")
            {
                seaLevel--;

            }
            else if (path[i].ToString() == "U")
            {
                seaLevel++;
            }

            if (previousSeaLevel == -1 && seaLevel == 0)
            {
                valleyCounter++;
                seaLevel = 0;
            }
        }


        return valleyCounter;



    }
}