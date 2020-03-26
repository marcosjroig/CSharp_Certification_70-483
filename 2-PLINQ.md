## PLINQ

- Language-Integrated Query or LINQ is used to perform queries on items of data in C#.
- Parallel Language-Integrated Query or PLINQ can be used to allow elements of the query to execute in parallel.

#### AsParallel()
```
var result = from person in persons.AsParallel()
              where person.City == "Seattle"
              select person;
```

The AsParallel method examines the query to determine if using a parallel version would speed it up.

If it is decided that executing elements of the query in parallel would improve performance, the query is broken down into a number of processes and each one runs concurrently.

#### Parallelization options
```
var result = from person in persons.AsParallel().
             WithDegreeOfParallelism(4). //Maximum 4 tasks in parallel
             WithExecutionMode(ParallelExecutionMode.ForceParallelism) //enforce the parallelism
             where person.City == "London"
             select person;
```

The previous code enforce the parallelization with the query execution of a maximum of four processors.

A non-parallel query produces output data that has the same order as the input data. A parallel query, however, may produce data in a different order from the input data.

#### Using AsOrdered to preserve data ordering
```
var result = from person in persons.AsParallel().AsOrdered()
             where person.City == "Seattle"
             select person;
```
