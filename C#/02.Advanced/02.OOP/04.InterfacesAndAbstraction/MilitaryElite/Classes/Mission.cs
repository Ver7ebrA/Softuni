﻿using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;
using MilitaryElite.Enums;

namespace MilitaryElite.Classes
{
    public class Mission : IMission
    {
        private MissionState state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get
            {
                return this.state.ToString();
            }

            private set
            {
                MissionState state;

                if (!Enum.TryParse<MissionState>(value, out state))
                {
                    throw new ArgumentException();
                }

                this.state = state;
            }
        }

        public void CompleteMission()
        {
            this.state = MissionState.Finished;
        }

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
