namespace BlazerProject
{
    public class Pizza
    {
        public Topping PizzaTopping { get; set; }
        public Crust PizzaCrust { get; set; }
        public Tip PizzaTip { get; set; }

        public Pizza()
        {
            PizzaTopping = new Topping();
            PizzaCrust = new Crust();
            PizzaTip = new Tip();
        }

        public double GetTopPrice()
        {
            double topPrice = PizzaTopping.TopPrice();

            return topPrice;
        }

        public double GetCrustPrice()
        {
            double crustPrice = PizzaCrust.CrustPrice();

            return crustPrice;
        }

        public double GetTipPrice()
        {
            double tip = PizzaTip.TipPercent() * (PizzaTopping.TopPrice() + PizzaCrust.CrustPrice() + 2);

            return tip;
        }

        public double GetFullPrice()
        {
            double total = PizzaTopping.TopPrice() + PizzaCrust.CrustPrice() + 2 + GetTipPrice();

            return total;
        }
    }
    public class Tip
    {
        public bool Twelve { get; set; }
        public bool Fifteen { get; set; }
        public bool Eighteen { get; set; }
        public double TipPercent()
        {
            double tip = 0;

            if (Twelve)
            {
                tip = 0.12;
            }
            if (Fifteen)
            {
                tip = 0.15;
            }
            if (Eighteen)
            {
                tip = 0.18;
            }
            return tip;
        }
    }

    public class Crust
    {
        public bool ThinCrust { get; set; }
        public bool PanCrust { get; set; }
        public bool HandTossed { get; set; }
        public double CrustPrice()
        {
            double crustTotal = 0;

            if (ThinCrust)
            {
                crustTotal += 5.99;
            }
            if (PanCrust)
            {
                crustTotal += 7.99;
            }
            if (HandTossed)
            {
                crustTotal += 6.99;
            }
            return crustTotal;
        }
    }

    public class Topping
    {
        public bool Pepperoni { get; set; }
        public bool ExtraCheese { get; set; }
        public bool Ham { get; set; }
        public bool Chicken { get; set; }
        public double TopPrice()
        {
            double runningTotal = 0;

            if (Pepperoni)
            {
                runningTotal += 1.50;
            }
            if (ExtraCheese)
            {
                runningTotal += 2;
            }
            if (Ham)
            {
                runningTotal += 1.79;
            }
            if (Chicken)
            {
                runningTotal += 3;
            }
            return runningTotal;
        }
    }
}
