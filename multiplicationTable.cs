namespace Treehouse.CodeChallenges
{
    public static class MathHelpers
    {
        public static int[][] BuildMultiplicationTable(int maxFactor)
        {
			int [][] result = new int [maxFactor+1][];
            
            for(int i=0; i <= maxFactor; i++)
            	{
                	result[i] = new int[maxFactor+1];                    
                        for(int j=0; j <= maxFactor; j++)
                        {
                            result[i][j] = i * j;
                        }
                }
                return result;
        }
    }
}




