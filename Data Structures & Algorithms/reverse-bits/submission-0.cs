public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;
        for(int i=0; i<32; i++)
        {
            if(((1<<i)&n) != 0)
            {
                res = res | (uint)(1<<(31-i));
            }
        }
        return res;
    }
}
