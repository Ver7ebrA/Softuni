using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        public string Start(ICollection<IPlayer> players)
        {

            List<IPlayer> terrorists = players.Where(p => p.GetType().Name == nameof(Terrorist)).ToList();
            List<IPlayer> counterTerrorists = players.Where(p => p.GetType().Name == nameof(CounterTerrorist)).ToList();


            while (terrorists.Any() && counterTerrorists.Any())
            {
                foreach (IPlayer terrorist in terrorists.ToList())
                {
                    foreach (IPlayer counterTerrorist in counterTerrorists.ToList())
                    {
                        counterTerrorist.TakeDamage(terrorist.Gun.Fire());

                        if (!counterTerrorist.IsAlive)
                        {
                            counterTerrorists.Remove(counterTerrorist);
                            if (counterTerrorists.Count == 0)
                            {
                                break;
                            }
                        }                     
                    }

                    if (counterTerrorists.Count == 0)
                    {
                        break;
                    }
                }

                if (counterTerrorists.Count == 0)
                {
                    break;
                }

                foreach (IPlayer counterTerrorist in counterTerrorists.ToList())
                {
                    foreach (IPlayer terrorist in terrorists.ToList())
                    {
                        terrorist.TakeDamage(counterTerrorist.Gun.Fire());

                        if (!terrorist.IsAlive)
                        {
                            terrorists.Remove(terrorist);
                            if (terrorists.Count == 0)
                            {
                                break;
                            }
                        }
                    }

                    if (terrorists.Count == 0)
                    {
                        break;
                    }
                }
            }

            if (terrorists.Count == 0)
            {
                return "Counter Terrorist wins!";
            }

            return "Terrorist wins!";
        }
    }
}
