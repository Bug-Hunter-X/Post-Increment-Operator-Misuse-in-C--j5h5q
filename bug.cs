public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // This is where the bug occurs:
        Console.WriteLine(MyProperty++); // This will print the current value of MyProperty BEFORE incrementing it.
                                         //If you want to print the value after increment, you should use ++MyProperty
    }
}