using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Insert items with distinct priorities
    // Expected Result: Dequeue returns items in order of priority: B, C, A
    // Defect(s) Found: Original loop skipped the last item. Also was not removing dequeued item.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Multiple items with same priority
    // Expected Result: Items dequeued in FIFO order: A, B
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Call Dequeue on an empty queue
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    [TestMethod]
    // Scenario: Insert multiple, remove one, then insert more and check order
    // Expected Result: Priorities respected and order preserved for same priority
    // Defect(s) Found: None
    public void TestPriorityQueue_MixedInsertRemove()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 2);
        priorityQueue.Enqueue("Y", 3);
        Assert.AreEqual("Y", priorityQueue.Dequeue());

        priorityQueue.Enqueue("Z", 3);
        priorityQueue.Enqueue("W", 2);

        Assert.AreEqual("Z", priorityQueue.Dequeue());
        Assert.AreEqual("X", priorityQueue.Dequeue());
        Assert.AreEqual("W", priorityQueue.Dequeue());

    }

}