public class MyClass
{
    public int MyProperty { get; set; } = 0;

    public void MyMethod()
    {
        // Explicit initialization prevents the exception.
        int value = MyProperty.GetHashCode();
    }
}