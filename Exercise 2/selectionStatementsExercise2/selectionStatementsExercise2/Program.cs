Console.WriteLine("Enter your favorite school subject");
var favSubj = Console.ReadLine();
switch (favSubj)
{
	case "Coding":
        Console.WriteLine($"{favSubj} is Nate's favorite subject too!");
		break;
	case "Physics":
        Console.WriteLine($"{favSubj} is Steph's favorite subject too!");
		break;
    case "Ethics":
        Console.WriteLine($"{favSubj} is Caleb's favorite subject too!");
        break;
    case "Theology":
        Console.WriteLine($"{favSubj} is Len's favorite subject too!");
        break;
    case "Metallurgy":
        Console.WriteLine($"{favSubj} is Clayton's favorite subject too!");
        break;
    default:
		Console.WriteLine($"{favSubj}, Really? You should have picked a less boring subject");
        break;
}