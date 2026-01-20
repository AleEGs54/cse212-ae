using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items  "Do homework"(3), "Make bed"(1), "Cook"(5) and dequeue all of them.
    // Expected Result: "Cook", "Do homework", "Make bed"
    // Defect(s) Found: The loop condition within Dequeue fn was lacking a last iteration because of the use of "less than (<)" instead of "less or equal than (<=)". Also, it didn't remove the item at "highPriorityIndex" index. 
    public void TestPriorityQueue_UniquePriority()
    {

        var item1 = new PriorityItem("Do homework", 3);
        var item2 = new PriorityItem("Make bed", 1);
        var item3 = new PriorityItem("Cook", 5);

        PriorityItem[] expectedResult = [item3, item1, item2];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority );
        priorityQueue.Enqueue(item2.Value, item2.Priority );
        priorityQueue.Enqueue(item3.Value, item3.Priority );

        
        for (int i = 0; i < expectedResult.Length; i++)
        {
            var nextItem = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, nextItem);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with 7 items, some of them having the same priority and dequeue until the queue is empty.
    // Expected Result: "Cook", "Do homework", "Wash dishes, "Take a shower", "Call Mom", "Make bed", "Water the plants"
    // Defect(s) Found: The condition within the if inside the Dequeue fn was checking if 2 priorities were greater than or equal to the other, but that was causing that, if both had the same priority then the last option would always be taken instead of the first one in the queue as per the requirements. It should be "greater than" only.
    public void TestPriorityQueue_DuplicatedPriority()
    {
        var item1 = new PriorityItem("Do homework", 3);
        var item2 = new PriorityItem("Make bed", 1);
        var item3 = new PriorityItem("Cook", 5);
        var item4 = new PriorityItem("Wash dishes", 3);
        var item5 = new PriorityItem("Call Mom", 2);
        var item6 = new PriorityItem("Water the plants", 1);
        var item7 = new PriorityItem("Take a shower", 3);

        PriorityItem[] expectedResult = [item3, item1, item4, item7, item5, item2, item6];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority );
        priorityQueue.Enqueue(item2.Value, item2.Priority );
        priorityQueue.Enqueue(item3.Value, item3.Priority );
        priorityQueue.Enqueue(item4.Value, item4.Priority );
        priorityQueue.Enqueue(item5.Value, item5.Priority );
        priorityQueue.Enqueue(item6.Value, item6.Priority );
        priorityQueue.Enqueue(item7.Value, item7.Priority );

        
        for (int i = 0; i < expectedResult.Length; i++)
        {
            var nextItem = priorityQueue.Dequeue();

            Assert.AreEqual(expectedResult[i].Value, nextItem);
        }
    }

    [TestMethod]

    // Scenario: Create an empty queue and try to dequeue a value
    // Expected Result: An error that says "The queue is empty."
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

         Assert.ThrowsException<InvalidOperationException>(() => {
        priorityQueue.Dequeue();
        });
    }
}