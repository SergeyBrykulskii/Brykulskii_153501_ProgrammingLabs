using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    enum ContributionTypes
    {
        Short,
        Medium,
        Long
    }
    public class Bank
    {

        public Contributor[] persons = new Contributor[10];
        public Contribution[] ContributionsInBank = new Contribution[3];

        private int currentContributor = 42;
        private int countOfContributions = 0;
        private int countOfContributers = 0;

        public void AddContributer(string name)
        {
            if (countOfContributers < 10)
            {
                persons[countOfContributers] = new Contributor(name);
                countOfContributers++; 
            }
        }

        public void AddContribution(int type, double amount, double persent)
        {
            if (countOfContributions < 3)
            {
                ContributionsInBank[countOfContributions] = new Contribution(type, amount, persent);
                countOfContributions++;
            }   
        }

        public void LogIn(string name)
        {
            for (int i = 0; i < countOfContributers; i++)
            {
                if (persons[i].Name.Equals(name))
                {
                    currentContributor = i;
                    Console.WriteLine("Вход выполнен успешно");
                    break;
                }
            }

            if (countOfContributions == 42)
                Console.WriteLine("Вход не выполнен");
        }

        public void LogOut()
        {
            currentContributor = 42;
        }

        public void MakeDeposit(int type, double persent, double amount)
        {
            if (currentContributor == 42)
            {
                Console.WriteLine("Выполните вход");
                return;
            }
            persons[currentContributor].Cont = new Contribution(type, persent, amount);
        }

        public void ReplenishTheDeposit(int sum)
        {
            if (currentContributor == 42)
            {
                Console.WriteLine("Выполните вход");
                return;
            }
            persons[currentContributor].Cont.Amount += sum;
        }

        public double GetTotalPayments()
        {
            double totalPayments = 0;

            for (int i = 0; i < countOfContributers; i++)
            {
                totalPayments += (persons[i].Cont.Amount * persons[i].Cont.Percent);
            }

            return totalPayments;
        }
    }
}
