using CloningExample;

Cat Cat = new Cat();
Console.WriteLine(Cat.Name);

Cat anotherCat = Cat; // some might do this expecting to make a copy of Cat.
Console.WriteLine(anotherCat.Name);
Cat.Name = "Hammy"; // this should have no bearing on anotherCat... right??
Console.WriteLine(anotherCat.Name); // Oh no! It says Hammy!



Cat thirdCat = (Cat)Cat.Clone(); // making a copy of cat, completely separate from the original
Console.WriteLine(thirdCat.Name);
Cat.Name = "Pumpkin"; // this should have no bearing on thirdCat... right??
Console.WriteLine(thirdCat.Name); // Hurray! No connection. We have a completely separate copy. 
Console.WriteLine(thirdCat == Cat);


Cat equalsCat = (Cat)Cat.Clone(); // created a clone of the Cat variable
Console.WriteLine(equalsCat == Cat); // we expect this to be true