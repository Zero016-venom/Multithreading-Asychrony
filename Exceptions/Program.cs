
Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

Task task;
try
{
    task = Task.Run(() => MethodThrowingException());
}
catch (Exception ex)
{
    Console.WriteLine("Exception caught: " + ex.Message);
}


Thread.Sleep(10000);
Console.WriteLine("Program is finished.");
Console.ReadKey();


static void MethodThrowingException()
{
    Console.WriteLine("Inside MethodThrowingException");
    throw new Exception("abc");
}

