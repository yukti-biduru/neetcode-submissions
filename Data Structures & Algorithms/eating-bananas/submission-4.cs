public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
{
            int l = 1, r = int.MinValue, m, calHours, res = 0;
            foreach (int i in piles)
            {
                r = Math.Max(r, i);
            }

            while (l <= r)
            {
                m = (l + r) / 2;
                calHours = 0;

                foreach (int i in piles)
                {
                    calHours += i / m + (i % m > 0 ? 1 : 0);
                }

                if (calHours <= h)
                {
                    res = m;
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            return res;
        }
}
