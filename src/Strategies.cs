using System;

namespace WarO_CSharp_v2
{
    public class Strategies
    {
        public IStrategy GetStrategy(string name)
        {
            IStrategy strategy = null;

            switch (name.Trim().ToLower())
            {
                case Constants.STRATEGY_CONSOLE:
                    strategy = new ConsoleStrategy();
                    break;
                case Constants.STRATEGY_MAX:
                    strategy = new MaxCard();
                    break;
                case Constants.STRATEGY_MIN:
                    strategy = new MinCard();
                    break;
                case Constants.STRATEGY_NEAREST:
                    strategy = new NearestCard();
                    break;
                case Constants.STRATEGY_NEXT:
                    strategy = new NextCard();
                    break;
                default:
                    throw new Exception("unknown strategy");
            }

            return strategy;
        }
    }
}
