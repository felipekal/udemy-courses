﻿using hash2.Entites;

HashSet<Product> a = new HashSet<Product>();

a.Add(new Product("TV", 900));
a.Add(new Product("Notebook", 1200));

HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

Product prod = new Product("Notebook", 1200);

Console.WriteLine(a.Contains(prod));