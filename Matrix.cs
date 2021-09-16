 public class Matrix
    {
        public int N, M;
        public int[,] matrix;
        
        public Matrix(int N, int M)
        {
            if ((N < 0) && (M < 0)) {
                throw new Exception();
            }
            
            this.N = N;
            this.M = M;
            matrix = new int[N, M];
        }
        
        public int get_item(int x, int y)
        {
            return matrix[x, y];
        }
        
        public static void multiply(int a)
        {
            for (int i = 0; i < this.M; i++)
            {
                for (int j = 0; j < this.N; j++)
                    matrix[i, j] *= a;            
            }
        }
 
        public void Divide(int D)
        {
            for (int i = 0; i < this.N; i++)
                for (int j = 0; j < this.M; j++) {
                    matrix[i, j] /= D;            
                }
        }

        public int[] get_row_sums()
        {
            result = new int[this.N];
 
            for (int i = 0; i < this.N; i++)
            {
                result[i] = 0;
                for (int j = 0; j < this.M; j++)
                {
                    result[i] += matrix[i][j];
                }
            }
            return result;
        }
    }
