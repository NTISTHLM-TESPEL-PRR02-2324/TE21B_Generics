

List<int> numbers = new() { 56, 45, 88, 98 };

Queue<int> alsoNumbers = new();

alsoNumbers.Enqueue(9);
alsoNumbers.Enqueue(2);
alsoNumbers.Enqueue(3);
alsoNumbers.Enqueue(10);

int t = alsoNumbers.Dequeue();

// Console.WriteLine(t);


Stack<int> thirdNumbers = new();
thirdNumbers.Push(4);
thirdNumbers.Push(6);
thirdNumbers.Push(9);
thirdNumbers.Push(2);

int r = thirdNumbers.Pop();



// Dictionary<string, int> stats = new();

// stats.Add("strength", 23);

// Console.WriteLine(stats["strength"]);



Dictionary<string, Action> actions = new();

actions.Add("feed", Feed);

actions["feed"]();

Monster m = new Monster();

Dictionary<Monster, Action> monsters = new();
monsters[m]();


Console.ReadLine();

static void Feed()
{
  Console.WriteLine("Eat! Nom nom!");
}

Node<string> n = new();



class Monster
{
  public string name = "Goomba";
}





class Node<T>
{
  public T contents;
}