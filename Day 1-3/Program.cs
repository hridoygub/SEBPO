using PracticeProject;

//Day-1//


//Lambda Expressions//

var square = (int num) => num * num;

Console.WriteLine("Square of number: " + square(5));



//ForEach Loop//

List<string> strings = new List<string>();
strings.Add("A");
strings.Add("B");
strings.Add("C");
strings.Add("D");
strings.Add("E");
strings.Add("F");


strings.ForEach(x => Console.WriteLine(x));


//inheritance polymorphism//



Employee em = new Employee2();
Console.WriteLine(em.salary);
//Console.WriteLine(em.bonus);
em.run();


//Abstract Class//

Hridoy hridoy = new Hridoy();
hridoy.runs();


//interface//

Drawable d;
d = new Rectangle();
d.draw();
d = new Circle();
d.draw();


//Encapsulation//

Name nm = new Name();
nm.setName("Hridoy");
Console.WriteLine(nm.getName());





//Day-2//




//Find all pairs of an integer array whose sum is equal to a given number.//
//How do you find all pairs of an integers array whose sum is equal to a given number? //

int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
int target = 6;
List<int> diff = new List<int>();

for (int i = 0; i < arr.Length; i++)
{

    int value = target - arr[i];

    if (!diff.Contains(value))
    {
        diff.Add(arr[i]);

    }
    else
    {
        Console.WriteLine(arr[i] + " " + value);
    }

}




//Find the largest and smallest number in an unsorted integer array. //
//.How do you find the largest and smallest number in an unsorted integer array ?//


int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
Array.Sort(arr);
Console.WriteLine(arr[arr.Length - 1] + " " + arr[0]);





//How to count a number of vowels and consonants in a String?//

String sentence = "iloveyou";
int vowels = 0;
int consonants = 0;

for (int i = 0; i < sentence.Length; i++)
{
    if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] ==
    'i' || sentence[i] == 'o' || sentence[i] == 'u') ||
    (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
    'I' || sentence[i] == 'O' || sentence[i] == 'U'))
    {
        vowels++;
    }
    else
    {
        consonants++;
    }
}

Console.WriteLine(vowels + " " + consonants);




// How do you find the missing number in a given integer array of 1 to 100? //

int[] arr = new int[] { 1, 2, 3, 5, 6, 8, 9, 10 };
int check = 0;
for (int i = 0; i < arr.Length; i++)
{
    check++;
    if (arr[i] != check)
    {
        Console.WriteLine(check++);
    }
}




//How do you find duplicate numbers in an array if it contains multiple duplicates ?//


int[] arr = new int[] { 1, 2, 3, 5, 6, 6, 8, 9, 1, 5, 3, 10 };
List<int> diff = new List<int>();
for (int i = 0; i < arr.Length; i++)
{

    if (!diff.Contains(arr[i]))
    {
        diff.Add(arr[i]);

    }
    else
    {
        Console.WriteLine(arr[i]);
    }
}



//How do you count the occurrence of a given character in a string?//

String arr = "asdfwertosasdfdfdkaoifodkfldfohidfhod";
List<String> diff = new List<String>();
String check = "a";
int count = 0;
for (int i = 0; i < arr.Length; i++)
{

    if (arr[i].ToString() == check)
    {
        count++;
    }
}
Console.WriteLine(count);



//Stack//

Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);

foreach (var item in myStack)
    Console.WriteLine(item);





//Queue//

Queue<string> names = new Queue<string>();
names.Enqueue("Sonoo");
names.Enqueue("Peter");
names.Enqueue("James");
names.Enqueue("Ratan");
names.Enqueue("Irfan");

//names.Dequeue();

foreach (string name in names)
{
    Console.WriteLine(name);
}




//Find the maximum and minimum value of the given unsorted array using function//

int findMaxValue(int[] arr)
{
    int check = -9999999;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > check)
        {
            check = arr[i];
        }
    }
    return check;
}

int findMinValue(int[] arr)
{
    int check = 9999999;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < check)
        {
            check = arr[i];
        }
    }
    return check;
}

int[] arr = new int[] { 10, 32, 1, 8, 32, 92, 41, 71, 34, 64, 99 };
Console.WriteLine(findMaxValue(arr));
Console.WriteLine(findMinValue(arr));


//Convert the array to a List, and then print the List using enhanced for loop. Do it in a function called 'convertingToListAndPrint(int[] arr)//


string[] groceryList = new string[] { "Eggs", "Cheese", "Chicken", "Milk", "Beef", "Potato", "Potato", "Carrot", "Eggs", "Eggs" };
List<string> list = new List<string>();
convertingToListAndPrint(groceryList);

void convertingToListAndPrint(string[] arr)
{
    //Creating List from Array
    foreach (string item in arr)
    {
        list.Add(item);
    }

    List<string> difflist = new List<string>();
    //Remove duplicate elements from the list
    for (int i = 0; i < list.Count; i++)
    {
        if (!difflist.Contains(list[i]))
            difflist.Add(list[i]);
    }
    list = difflist;

    //print the list
    foreach (string item in list)
        Console.Write(item + " ");
}



////The user wants to make sure whether he wrote down Potato in his
////groceryList. Without using the brute force approach, create a method
////"isPotatoThere(...)" that returns true, if it exists, else false.
//Console.WriteLine(isPotatoThere("Potato"));

bool isPotatoThere(string keyword)
{
    if (list.Contains(keyword))
        return true;
    else
        return false;
}



////The user realized he mistakenly wrote "Beef" instead of "Mutton". Update
////the shopping list. Make sure, you mention the line below in your code.
////System.out.println("The updated List are" + updatedArrayList(...))


list[list.IndexOf("Beef")] = "Mutton";
Console.Write("The updated List are : ");
foreach (string item in list)
    Console.Write(item + " ");




//2.Construct a dictionary(HashTable/HashMap any one of your wish), and
//print them. Each individual can have none, one or more than one
//address. Code for the given scenario, making the individual name as the
//unique key


var address = new Dictionary<string, string>(){
    {"Akib", "Mirpur, Dhanmondi, Shiddheshwari"},
    {"Sajeeb", "Lalmatia, New York, Washington"},
    {"Niloy", "Mumbai, New Delhi, Pune"},
    {"Ratul",""},
};

for (int i = 0; i < address.Count; i++)
{
    Console.WriteLine("{0} {1} {2}",
        i+1,                              
        address.ElementAt(i).Key,                  
        address.ElementAt(i).Value == "" ? "NO ADDRESS" : address.ElementAt(i).Value);
}




