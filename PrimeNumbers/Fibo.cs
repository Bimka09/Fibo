namespace PrimeNumbers
{
    public class Fibo
    {
        private int[,] _baseMatrix {get;set;}
        private int[,] _resultMatrix { get; set; }

        public void Multiply(bool checker)
        {
            int a11;
            int a12;
            int a21;
            int a22;
            if (checker)
            {
                a11 = _resultMatrix[0, 0] * _baseMatrix[0, 0] + _resultMatrix[0, 1] * _baseMatrix[1, 0];
                a12 = _resultMatrix[0, 0] * _baseMatrix[0, 1] + _resultMatrix[0, 1] * _baseMatrix[1, 1];
                a21 = _resultMatrix[1, 0] * _baseMatrix[0, 0] + _resultMatrix[1, 1] * _baseMatrix[1, 0];
                a22 = _resultMatrix[1, 0] * _baseMatrix[0, 1] + _resultMatrix[1, 1] * _baseMatrix[1, 1];
                _resultMatrix = new int[,] { { a11, a12 }, { a21, a22 } };
            }
            else
            {
                a11 = _baseMatrix[0, 0] * _baseMatrix[0, 0] + _baseMatrix[0, 1] * _baseMatrix[1, 0];
                a12 = _baseMatrix[0, 0] * _baseMatrix[0, 1] + _baseMatrix[0, 1] * _baseMatrix[1, 1];
                a21 = _baseMatrix[1, 0] * _baseMatrix[0, 0] + _baseMatrix[1, 1] * _baseMatrix[1, 0];
                a22 = _baseMatrix[1, 0] * _baseMatrix[0, 1] + _baseMatrix[1, 1] * _baseMatrix[1, 1];
                _baseMatrix = new int[,] { { a11, a12 }, { a21, a22 } };
            }
        }
        public long PowerLogN(int position)
        {
            _baseMatrix = new int[,] { { 1, 1 }, { 1, 0 } };
            _resultMatrix = new int[,] { { 1, 0 }, { 0, 1 } };

            for (; position > 1; position /= 2)
            {
                if (position % 2 == 1)
                {
                    Multiply(true);
                }
                Multiply(false);
            }
            Multiply(true);
            return _resultMatrix[1,1];
        }
    }
}
