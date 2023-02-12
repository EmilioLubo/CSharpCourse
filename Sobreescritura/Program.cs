namespace Sobreescritura
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new(5);
            sale.Add(5.5m);
            sale.Add(3.5m);
            Console.WriteLine(sale.GetTotal());

            SaleWithTax taxSale = new(3, 1.25m);
            taxSale.Add(3.5m);
            taxSale.Add(4.5m);
            taxSale.Add(3.3m);
            Console.WriteLine(taxSale.GetTotal());
        }

        public class Sale
        {
            private decimal[] _amounts;
            private int _count;
            private int _total;

            public Sale(int n)
            {
                _amounts = new decimal[n];
                _count = n;
                _total = 0;
            }

            public void Add(decimal amount)
            {
                if (_total < _count)
                {
                    _amounts[_total] = amount;
                    _total++;
                }
            }

            public virtual decimal GetTotal()
            {
                decimal result = 0;
                int i = 0;

                while (i < _amounts.Length)
                {
                    result += _amounts[i];
                    i++;
                }

                return result;
            }
        }

        public class SaleWithTax : Sale
        {
            private decimal _tax;
            public SaleWithTax(int n, decimal tax) : base(n)
            {
                _tax= tax;
            }

            public override decimal GetTotal()
            {
                return base.GetTotal() * _tax;
            }
        }

    }
}