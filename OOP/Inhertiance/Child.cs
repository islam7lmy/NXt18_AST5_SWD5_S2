namespace OOP.Inhertiance
{
    class Child : Parent
    {
        //public int A { get; set; }
        public int B { get; set; }

        //clr will auto generate default constructor if no user defined constructor exists
        //that will call the default constructor of parent class
        //public Child() : base()
        //{
        //}



        public Child(int _a, int _b) : base(_a)
        {
            //A = _a;
            B = _b;
        }

        //public void MyFunc01()
        //{
        //    Console.WriteLine("Hi I am Child");
        //}

        //public void MyFun02()
        //{
        //    Console.WriteLine($"A = {A} , B = {B}");
        //}
    }
}
