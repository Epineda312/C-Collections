namespace Treehouse.CodeChallenges
{
    public static class MathHelpers
    {
        public static int[][] BuildMultiplicationTableJaggedArray(int maxFactor)
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

     public static class MathHelpers
    {
        public static int[,] BuildMultiplicationTable(int maxFactor)
        {
			int[,] result = new int [maxFactor+1 , maxFactor+1];
            
            for(int colIndex = 0; colIndex <= maxFactor; colIndex++)
            {
                for(int rowIndex = 0; rowIndex <= maxFactor; rowIndex++)
                {
                    result[rowIndex , colIndex] = rowIndex * colIndex;
                }
            }
            return result;
        }
    }
}




