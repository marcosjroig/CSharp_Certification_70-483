# C# Certification 70-483

## Task Parallel library

The Task Parallel Library (TPL) provide a range of resources that allow you to use Tasks in an application.

The Task.Parallel class provides three methods that can be used to execute task in parallel:

-	Parallel.Invoke
-	Parallel.ForEach
-	Parallel.For

![alt text](https://github.com/marcosjroig/CSharp_Certification_70-483/blob/master/1%20-%20TPL.JPG)

The *__Task.Parallel__* can be found in the *__System.Threading.Tasks__* namespace.

###  Parallel.Invoke

> The Parallel.Invoke method accepts a number of Action delegates and creates a task for each of them.

```
 Parallel.Invoke(() => Method1(), () => Method2());
```





