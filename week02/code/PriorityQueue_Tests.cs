using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // *NOTE - This one is meant to fail to show that the error will happen. If you go through the debugger you'll see it returns all of the values that it needs to before throwing the error*
    // Scenario: Create a queue with the following values and priorities: John (6), Joe (8), Adam (7), Grant (5)
    // Expected Result: Return, in order, the values of Joe, Adam, John, Grant. Try to dequeue one more time and get an error
    // Defect(s) Found: The equals sign needed to be removed from the evaulation so that it would return
    // The first priority value that was inputted. Removed the -1 in the for loop to display the correct
    // Value when iterating multiple times
    public void TestPriorityQueue_1()
    {

        var priorityQueue1 = new PriorityQueue();

        priorityQueue1.Enqueue("John", 6);
        priorityQueue1.Enqueue("Joe", 8);
        priorityQueue1.Enqueue("Adam", 7);
        priorityQueue1.Enqueue("Grant", 5);
        var result1 = priorityQueue1.Dequeue();
        Trace.Assert(result1 == "Joe");
        var result2 = priorityQueue1.Dequeue();
        Trace.Assert(result2 == "Adam");
        var result3 = priorityQueue1.Dequeue();
        Trace.Assert(result3 == "John");
        var result4 = priorityQueue1.Dequeue();
        Trace.Assert(result4 == "Grant");
        var result5 = priorityQueue1.Dequeue();
    }

    [TestMethod]
    // Scenario: Create a queue with the following inputs: Third (8), First (12), Second (10), Fourth (6), Fifth (4) 
    // Expected Result: Return in order the following items: First, Second, Third, Fourth, Fifth
    // Defect(s) Found: No defect found. All defects were solved in the first test above.
    public void TestPriorityQueue_2()
    {
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Third", 8);
        priorityQueue2.Enqueue("First", 12);
        priorityQueue2.Enqueue("Second", 10);
        priorityQueue2.Enqueue("Fourth", 6);
        priorityQueue2.Enqueue("Fifth", 4);
        var result1 = priorityQueue2.Dequeue();
        Trace.Assert(result1 == "First");
        var result2 = priorityQueue2.Dequeue();
        Trace.Assert(result2 == "Second");
        var result3 = priorityQueue2.Dequeue();
        Trace.Assert(result3 == "Third");
        var result4 = priorityQueue2.Dequeue();
        Trace.Assert(result4 == "Fourth");
        var result5 = priorityQueue2.Dequeue();
        Trace.Assert(result5 == "Fifth");
    }


    [TestMethod]
    // Scenario: Create a queue with the following inputs: Third (3), First (5), Second (4), Fourth (2), Fifth (1) 
    // Expected Result: Return in order the following items: First, Second, Third, Fourth, Fifth
    // Defect(s) Found: No defect found. All defects were solved in the first test above.
    public void TestPriorityQueue_3()
    {
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Third", 3);
        priorityQueue2.Enqueue("First", 5);
        priorityQueue2.Enqueue("Second", 4);
        priorityQueue2.Enqueue("Fourth", 2);
        priorityQueue2.Enqueue("Fifth", 1);
        var result1 = priorityQueue2.Dequeue();
        Trace.Assert(result1 == "First");
        var result2 = priorityQueue2.Dequeue();
        Trace.Assert(result2 == "Second");
        var result3 = priorityQueue2.Dequeue();
        Trace.Assert(result3 == "Third");
        var result4 = priorityQueue2.Dequeue();
        Trace.Assert(result4 == "Fourth");
        var result5 = priorityQueue2.Dequeue();
        Trace.Assert(result5 == "Fifth");
    }

}