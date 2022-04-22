using laba5;

//Console.WriteLine("Hello, World!");

Bank vtb = new();

vtb.AddContribution((int)ContributionTypes.Short, 300, 0.04);
vtb.AddContribution((int)ContributionTypes.Medium, 500, 0.12);
vtb.AddContribution((int)ContributionTypes.Long, 700, 0.22);

vtb.AddContributer("Sergey");
vtb.AddContributer("Anna");

vtb.LogIn("Sergey");
vtb.MakeDeposit((int)ContributionTypes.Short, 1000, 0.05);
vtb.LogOut();
vtb.LogIn("Anna");
vtb.MakeDeposit((int)ContributionTypes.Short, 1000, 0.45);

Console.WriteLine(vtb.GetTotalPayments());
