## PLINQ

- Language-Integrated Query or LINQ is used to perform queries on items of data in C#.
- Parallel Language-Integrated Query or PLINQ can be used to allow elements of the query to execute in parallel.

```
  var result = from person in people.__AsParallel()__
               where person.City == "Seattle"
               select person; 
```

