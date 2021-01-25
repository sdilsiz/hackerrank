
///https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?h_l=interview&playlist_slugs%5B%5D%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D%5B%5D=warmup
public class JumpingOnTheClouds
{

    // Complete the jumpingOnClouds function below.
    public static int jumpingOnClouds(int[] c)
    {

        var jumpingCount = 0;
        for (int i = 0; i < c.Length; i++)
        {

            if (i + 1 < c.Length && c[i + 1] == 1 ||
             (i + 2 < c.Length && c[i + 1] == 0 && c[i + 2] == 0))
            {
                i++;
            }

            jumpingCount++;
        }
        //The last jumping is doesn't counting 
        return jumpingCount - 1;

    }
}