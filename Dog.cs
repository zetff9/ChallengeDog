class Dog
{
public enum Gender
{
Male, Female
};
public string name;
public string owner;
public int age;
public Gender gender;
public static string getGender(Gender gender)
{
if (gender == Gender.Male)
{
return "His";
}
return "Her";
}
public Dog(string name1,string owner1,int age1,Gender gender1)
{
name = name1;
owner = owner1;
age = age1;
gender = gender1;
}
public void bark(int num)
{
for (int i = 0; i < num; i++)
{
Console.Write("Woof!");

}
Console.WriteLine();
}
public string getTag()
{
string hisOrher=getGender(gender).ToString();
string heOrShe;
if(hisOrher =="His")
{
heOrShe="he";
}
else  
{
heOrShe = "she";
}
return "If lost, call "+owner+ ". " + hisOrher+" name is "+ name+ " and "+ heOrShe + " is " + age+" old.";
}

static void Main(string[] args)
{
Dog puppy=new Dog("Orion", "Shawn", 1, Gender.Male);
puppy.bark(3);
Console.WriteLine(puppy.getTag());

Dog myDog =new Dog("Lileu", "Dale", 4, Gender.Female);
myDog.bark(1);
Console.WriteLine(myDog.getTag());  

Console.ReadKey();
}
}
