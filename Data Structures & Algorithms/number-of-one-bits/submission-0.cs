public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        for(int i=0; i<32; i++)
        {
            if(((1<<i)&n)!=0) count++;
        }
        return count;
    
    }
}
