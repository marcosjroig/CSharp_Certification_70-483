## PLINQ

- Language-Integrated Query or LINQ is used to perform queries on items of data in C#.
- Parallel Language-Integrated Query or PLINQ can be used to allow elements of the query to execute in parallel.

#### AsParallel()
```
var result = from person in persons.AsParallel()
              where person.City == "Seattle"
              select person;
```

The ___AsParallel___ method examines the query to determine if using a parallel version would speed it up.

If it is decided that executing elements of the query in parallel would improve performance, the query is broken down into a number of processes and each one runs concurrently.

