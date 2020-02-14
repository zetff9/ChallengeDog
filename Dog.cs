// class Dog start here
class Dog
{
// Enum Gender declaration
public enum Gender
{
Male, Female
};

// variable declaration
public string name;
public string owner;
public int age;
public Gender gender;
  
// static method that returns His or Her on the basis of Gender
// By calling Enum value
public static string getGender(Gender gender)
{
if (gender == Gender.Male)
{
return "His";
}
return "Her";
}

  
// Dog constructor with parameter
public Dog(string name1,string owner1,int age1,Gender gender1)
{
name = name1;
owner = owner1;
age = age1;
gender = gender1;
}

// method to print a bark
// it take a one parameter and print the Woof!
public void bark(int num)
{
for (int i = 0; i < num; i++)
{
Console.Write("Woof!");

}
Console.WriteLine();
}

// method to return all details
public string getTag()
{
// call the method getGender() to get it is "his or her"
// one the basis of male or female;
// and store in a variable
string hisOrher=getGender(gender).ToString();
// variable to store he or she
// on the basis of His or Her
string heOrShe;

// in this it will check the value of hisOrher, if hisOrher=="His" then return "he"
// otherwise return she
if(hisOrher =="His")
{
heOrShe="he";
}
else  
{
heOrShe = "she";
}
// return all the value here
return "If lost, call "+owner+ ". " + hisOrher+" name is "+ name+ " and "+ heOrShe + " is " + age+" old.";
}

// main method
static void Main(string[] args)
{
//create instance of Dog and initialized value
Dog puppy=new Dog("Orion", "Shawn", 1, Gender.Male);
// call bark() method
puppy.bark(3);
// call getTag() method
Console.WriteLine(puppy.getTag());

// same like above
Dog myDog =new Dog("Lileu", "Dale", 4, Gender.Female);
myDog.bark(1);
Console.WriteLine(myDog.getTag());  

// to hold the screen
Console.ReadKey();
}
}
