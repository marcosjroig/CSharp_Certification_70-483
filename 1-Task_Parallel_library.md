# C# Certification 70-483

## Task Parallel library

The Task Parallel Library (TPL) provide a range of resources that allow you to use Tasks in an application.

The Task.Parallel class provides three methods that can be used to execute task in parallel:

-	Parallel.Invoke
-	Parallel.ForEach
-	Parallel.For

![alt text](https://github.com/marcosjroig/CSharp_Certification_70-483/blob/master/images/1%20-%20TPL.JPG)

The *__Task.Parallel__* can be found in the *__System.Threading.Tasks__* namespace.

###  Parallel.Invoke

> The Parallel.Invoke method accepts a number of Action delegates and creates a task for each of them.

```
 Parallel.Invoke(() => Method1(), () => Method2());
```

###  Parallel.ForEach

> The Parallel.ForEach performs a parallel implementation of the forach loop.

```
  var items = Enumerable.Range(0, 5);
  Parallel.ForEach(items, item =>
  {
       WorkOnItem(item);
  });
```

###  Parallel.For

> The Parallel.For method can be used to parallelize the execution of a for loop.

```
  var items = Enumerable.Range(0, 5).ToArray();
  Parallel.For(0, items.Length, i => 
  {
       WorkOnItem(items[i]);
  });
```

## PLINQ
Language-Integrated Query or LINQ is used to perform queries on items.
Parallel Language-Integrated Query or PLINQ can be used to allow elements of the query to execute in parallel.

