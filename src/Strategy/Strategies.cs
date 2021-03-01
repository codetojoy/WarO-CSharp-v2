using System;

namespace WarO_CSharp_v2.Strategy
{
    public class Strategies
    {
        public IStrategy GetStrategy(string name)
        {
            IStrategy strategy = null;

            switch (name.Trim().ToLower())
            {
                case StrategyConstants.STRATEGY_API:
                    strategy = new ApiStrategy();
                    break;
                case StrategyConstants.STRATEGY_CONSOLE:
                    strategy = new ConsoleStrategy();
                    break;
                case StrategyConstants.STRATEGY_MAX:
                    strategy = new MaxCard();
                    break;
                case StrategyConstants.STRATEGY_MIN:
                    strategy = new MinCard();
                    break;
                case StrategyConstants.STRATEGY_NEAREST:
                    strategy = new NearestCard();
                    break;
                case StrategyConstants.STRATEGY_NEXT:
                    strategy = new NextCard();
                    break;
                case StrategyConstants.STRATEGY_PATHOLOGICAL:
                    strategy = new PathologicalPauseStrategy();
                    break;
                default:
                    throw new Exception("unknown strategy");
            }

            return strategy;
        }
    }
}
