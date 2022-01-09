using Adapter;

Dollar  Dollar1 = new Dollar(1);
Euro Euro1 = new Euro(1);
PaymentDollars PaymentDollars = new PaymentDollars();
//PaymentDollars.pay(Dollar1.amount);
PaymentEuroAdapter Payment  = new PaymentEuroAdapter();
Console.WriteLine(Payment.pay(Euro1.amount));
Console.ReadLine();


