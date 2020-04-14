using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;
using MilitaryElite.Enums;

namespace MilitaryElite.Classes
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private Corps corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get
            {
                return this.corps.ToString();
            }

            set
            {
                Corps corps;

                if (!Enum.TryParse<Corps>(value, out corps))
                {
                    throw new ArgumentException();
                }

                this.corps = corps;
            }
        }

        string ISpecialisedSoldier.Corps => throw new NotImplementedException();

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine($"Corps: {Corps}");

            return builder.ToString().TrimEnd();
        }
    }
}
