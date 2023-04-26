

//rakendus küsib kasutaja vanuse
//kui vanus väiksem kui 13, siis konsoolis kuvatakse
//Olete liig noor kasutama instagrami
//muul juhul kuvatakse tere tulemast instagrami


Console.WriteLine("Enter your age:");

int userAge = Int32.Parse (Console.ReadLine());    // "13" - heap. 13 - stack int32 loeb kohe numbriks

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Insta!");

}
else
{
    Console.WriteLine("You are too young to use Insta!");
}
