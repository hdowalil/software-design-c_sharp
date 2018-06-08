using System.Linq;

namespace SelfDocumentation.Lab01.Excercise.Solution.Trainer
{
    public enum Alert
    {

        // everything is just fine
        Green = 0,

        // do something about the problem!
        Yellow = 1,

        // use escape pods, if there are any, immediately
        Red = 2

    }

    static class AlertExtensions
    {
        public static Alert getMaximumSeverity(params Alert[] alerts)
        {
            return alerts.Max();
        }
    }
}
