using System;

namespace assignment6
{
    class Bird
    {
        private IStrategy _strategy;

        public Bird() { }

        public Bird(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            string resultStr = this._strategy.flying();

            Console.WriteLine(resultStr);
        }
    }

    // The Strategy interface 
    public interface IStrategy
    {
        string flying();
    }

    // Concrete Strategies 
    class MallardDuck : IStrategy
    {
        public string flying()
        {
            string howFly = "Here is the Mallard Duck's movement behavior: *FLIES BY FLAPS WINGS*";

            return howFly;
        }
    }

    class EmperorPenguin : IStrategy
    {
        public string flying()
        {
            string howFly = "Here is the Emperor penguin movement behavior: *SLIDES BY ITS BELLY*";

            return howFly;
        }
    }
    class BaldEagle : IStrategy
    {
        public string flying()
        {
            string howFly = "Here is the Bald Eagle's movement behavior: *FLIES BY FLAPS WINGS*";

            return howFly;
        }
    }
    class Ostrich : IStrategy
    {
        public string flying()
        {
            string howFly = "Here is the Ostrich's movement behavior: *HIDES HEAD IN THE SAND AS IT CANNOT FLY*";

            return howFly;
        }
    }
    class YellowRubberDuck : IStrategy
    {
        public string flying()
        {
            string howFly = "Here is the Yellow Rubber Duck's movement behavior: FLOATS IN WATER";

            return howFly;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Bird = new Bird();
            Console.WriteLine("Number of birds in the simulation: 5");
            Bird.SetStrategy(new MallardDuck());
            Bird.DoSomeBusinessLogic();
            Bird.SetStrategy(new EmperorPenguin());
            Bird.DoSomeBusinessLogic();
            Bird.SetStrategy(new BaldEagle());
            Bird.DoSomeBusinessLogic();
            Bird.SetStrategy(new Ostrich());
            Bird.DoSomeBusinessLogic();
            Bird.SetStrategy(new YellowRubberDuck());
            Bird.DoSomeBusinessLogic();
        }
    }
}
