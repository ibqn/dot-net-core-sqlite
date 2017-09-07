using System;


namespace CommandPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Value<DecimalVal> V1 = new Value<DecimalVal>(1.3M);
            Value<DecimalVal> V2 = new Value<DecimalVal>(3.8M);

            AddOperation<DecimalVal> AddOp = new AddOperation<DecimalVal>(V1, V2);
            Console.WriteLine($"compute {AddOp} = {AddOp.Compute()}");

            SubtractOperation<DecimalVal> SubOp = new SubtractOperation<DecimalVal>(V1, V2);
            Console.WriteLine($"compute {SubOp} = {SubOp.Compute()}");

            //Bracket<DecimalVal> AddBra = new Bracket<DecimalVal>(AddOp);
            //Bracket<DecimalVal> SubBra = new Bracket<DecimalVal>(SubOp);
            //MultiplyOperation<DecimalVal> MulOp = new MultiplyOperation<DecimalVal>(AddBra, SubBra);
            MultiplyOperation<DecimalVal> MulOp = new MultiplyOperation<DecimalVal>(AddOp, SubOp);
            Console.WriteLine($"compute {MulOp} = {MulOp.Compute()}");

            User<DoubleVal> user = new User<DoubleVal>();
            //user.SetValue(3.14);
            user.Apply(Operation.ADD, 0.14);
            user.Apply(Operation.ADD, 1.06);
            user.Apply(Operation.MULTIPLY, 3.14);
        }
    }
}
