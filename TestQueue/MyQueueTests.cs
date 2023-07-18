namespace TestQueue
{
    public class MyQueueTests
    {

        private Queue<int> queue;
        private Queue<string> queue2;

        public MyQueueTests()
        {
            queue = new Queue<int>();
            queue2 = new Queue<string>();
        }

        [Fact]
        public void TestEnqueue()
        {
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue2.Enqueue("hh");
            Assert.Equal(2, queue.Count);
            Assert.Equal(1, queue2.Count);

        }

        [Fact]
        public void TestDequeue()
        {
            queue2.Enqueue("aaa");
            queue2.Enqueue("bbb");
            queue2.Enqueue("ccc");

            string itm = queue2.Dequeue();
            string itm2 = queue2.Dequeue();

            Assert.Equal("aaa", itm);
            Assert.Equal("bbb", itm2);
            Assert.Equal(1, queue2.Count);
        }

    }
}