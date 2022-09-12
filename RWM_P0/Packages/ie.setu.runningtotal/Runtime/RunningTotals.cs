public class RunningTotal
{
    public static int[] runningTotals(int[] xs)
    {
        int currentTotal = 0;

        int[] result = new int[xs.Length];
        //result[0] = 0;
        for (int i = 0; i < xs.Length; i++)
        {

            currentTotal += xs[i];
            result[i] = currentTotal;
        }
        return result;
    }
}
