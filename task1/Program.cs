namespace task1
{
    interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest() { }
    }

    public class StandartAccount: IAccount
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public void CalculateInterest() 
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }

    public class PayAccount : IAccount
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount standart = new StandartAccount() { Balance = 50000};
            standart.CalculateInterest();
            Console.WriteLine("Процентная ставка = " + standart.Interest);
            Console.WriteLine();

            IAccount pay = new PayAccount() { Balance = 15000 };
            pay.CalculateInterest();
            Console.WriteLine("Процентная ставка = " + pay.Interest);

        }
    }
}