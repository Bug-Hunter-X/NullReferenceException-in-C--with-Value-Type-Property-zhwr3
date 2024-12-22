public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // This line will cause a NullReferenceException if MyProperty is null.
        int value = MyProperty.GetHashCode();
    }
}