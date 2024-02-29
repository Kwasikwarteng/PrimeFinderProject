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
            int number;
            if (int.TryParse(txtNumber1.Text, out number))
            {
                //Task.Run(() =>
                //{
                //    List<int> primeNumbers = FindPrimes(number);
                //    UpdateListBox(listBoxPrimes1, primeNumbers);
                //});
                Thread threadBtn1 = new Thread(() => ShowPrimes(number, listBoxPrimes1));
                threadBtn1.Start();
            }
            else
            {
                MessageBox.Show("Not a valid integer. Enter A Valid number");
            }
        }

        private void btnPrimes2_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber2.Text, out number))
            {
                //Task.Run(() =>
                //{
                //    List<int> primeNumbers = FindPrimes(number);
                //    UpdateListBox(listBoxPrimes2, primeNumbers);
                //});
                Thread threadBtn2 = new Thread(() => ShowPrimes(number, listBoxPrimes2));
                threadBtn2.Start();
            }
        }

        private void ShowPrimes(int number, ListBox listBox)
        {
            List<int> primes = FindPrimes(number);
            UpdateListBox(listBox, primes);
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

        //Render Data in list box
        private void UpdateListBox(ListBox listBox, List<int> primes)
        {
            listBox.Invoke((MethodInvoker)delegate
            {
                listBox.Items.Clear();
                foreach (int prime in primes)
                {
                    listBox.Items.Add(prime);
                }
            });
        }
    }
}
