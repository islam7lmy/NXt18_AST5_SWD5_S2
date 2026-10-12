namespace OOP.Inhertiance
{
    class Child02 : Parent
    {
        //public int A { get; set; }
        public int Z { get; set; }

        public Child02(int _a, int _z) : base(_a)
        {
            //A = _a;
            Z = _z;
        }

        //public void MyFunc01()
        //{
        //    Console.WriteLine("Hi I am Child02");
        //}

        //public void MyFun02()
        //{
        //    Console.WriteLine($"A = {A} , Z = {Z}");
        //}
    }
}
