// start
// exit
// generate word
// hello

const string _startText = "start";
const string _exitText = "exit";
const string _generateText = "generate";
const string _helloText = "hello";

bool _isWork = true; // true (истина) false (ложь)

while (_isWork)
{
	Console.Write("Enter the command: ");
	string command = Console.ReadLine();

	switch (command)
	{
		case _startText: Console.WriteLine("The app is started"); break;
		case _exitText: Console.WriteLine("exit"); _isWork = false; break;
		case _generateText: Console.WriteLine("Badum"); break;
		case _helloText: Console.WriteLine("hello"); break;
		default: Console.WriteLine(); break;
	}
}
