namespace PrimeFinderProject
{
    public partial class PrimeFinder : Form
    {
        public PrimeFinder()
        {
            InitializeComponent();
        }



        private void btnPrimes1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimes2_Click(object sender, EventArgs e)
        {

        }

        //Render List of Primes
        private List<int> FindPrimes(int maxNumber)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= maxNumber; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        //Check For Primes
        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            //Prime Boundary for algorithm
            int primeBoundary = (int)Math.Floor(Math.Sqrt(number));

            //Iterate to get primes
            for (int i = 3; i <= primeBoundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
