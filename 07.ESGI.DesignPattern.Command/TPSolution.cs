using System.Collections.Generic;

namespace _07.ESGI.DesignPattern.Command
{
    public class Calculator
    {
        public Calculator()
        {
            Result = 0;
        }
        public int Result { get; private set; }

        public void Plus(int i)
        {
            Result += i;
        }

        public void Minus(int i)
        {
            Result -= i;
        }

        public void Multiply(int i)
        {
            Result *= i;
        }

        public void Divide(int i)
        {
            Result /= i;
        }
    }

    public class SumCommand : CommandBase
    {
        private readonly int _value;
        public SumCommand(Calculator calculator, int i): base(calculator)
        {
            _value = i;
        }

        public override void  Do()
        {
            Calculator.Plus(_value);
        }

        public  override void Undo()
        {
            Calculator.Minus(_value);
        }
    }

    public class MultiplyCommand : CommandBase
    {
        private readonly int _value;
        public MultiplyCommand(Calculator calculator, int i): base(calculator)
        {
            _value = i;
        }
        
        public override void Do()
        {
            Calculator.Multiply(_value);
        }

        public override void Undo()
        {
            Calculator.Divide(_value);
        }
        
    }

    public abstract class CommandBase
    {
        protected readonly Calculator Calculator;

        protected CommandBase(Calculator calculator)
        {
            Calculator = calculator;
        }

        public abstract void Do();
        public abstract void Undo();
    }

    public class CLI
    {
        private readonly Calculator _calculator;
        private readonly Stack<CommandBase> _stack;
        public CLI()
        {
            _stack = new Stack<CommandBase>();
            _calculator = new Calculator();
        }
         public int Result()
         {
             return _calculator.Result;
         }

        public void Compute(char command, int value)
        {
            CommandBase cmd = null;
            switch (command)
            {
                case '+':
                    cmd = new SumCommand(_calculator, value);
                    break;
                case '*':
                    cmd = new MultiplyCommand(_calculator, value);
                    break;
            }

            if (cmd == null) return;
            
            _stack.Push(cmd);
            cmd.Do();
        }

        public void Undo()
        {
            if (_stack.Count > 0)
            {
                var lastCommand = _stack.Pop();
                lastCommand.Undo();
            }
        }
    }
}
