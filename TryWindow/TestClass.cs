namespace TryWindow
{
    public class TestClass
    {
        public TestClass Child { get; set; }

        public string Text { get; set; } = "Just a text for test";

        public static TestClass Root { get; set; } = new TestClass()
        {
            Child = new TestClass()
            {
                Child = new TestClass()
                {
                    Text = "Last element"
                }
            }
        };
    }
}
