/*
Return a multiplication table consisting of a 2D multidimensional array. 
The table should contain all of the products of integers from 0 to maxFactor. 
For example, if maxFactor is 3 the resulting multiplication table should 
contain the following:
			0 0 0 0 
			0 1 2 3 
			0 2 4 6 
			0 3 6 9
*/
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



