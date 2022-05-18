Calculator
OOPS Assignment
Create a calculator program which has the following capabilities

Add multiple numbers
Finding the difference of the numbers
Division and Multiplication of multiple numbers
The program should be run from command line.
It would take simple instruction and work on the operator
for example 1 + 3 - 4 = 0 ; 1 + (3 * 4) = 13
Please ensure that you have installed Equivalent IDE on your computer before embarking on this assignment. Create object-oriented, scalable, loosely-coupled code and try to look for opportunities to reuse code. Use Design patterns wherever appropriate. Use the best industry practices for commenting, code layout, coding style and naming of objects, members and methods.

The idea of this problem should be to provide a generic solution to any new operator added to this functionalities
Programming Language 
C#.Net 


INSTRUCTIONS:
open the visual studio project by running the .sln file

Then run the project.

In the command console you will be shown example operations, for this case it is not necessary for the user to enter anything, since there are some examples of operations that were added in the program.cs file, so that you can validate quickly.

For this solution design patterns were used to execute arithmetic operations.

It is not necessary to enter anything by console, since I have added examples of operations in the file program.cs

To validate the entire pattern process, I have added an additional functionality to remove or redo operations, which will return or advance some arithmetic operation that has already been executed.


The Command design pattern encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

Participants
#
The classes and objects participating in this pattern include:

Command  (Command)
declares an interface for executing an operation
ConcreteCommand  (CalculatorCommand)
defines a binding between a Receiver object and an action
implements Execute by invoking the corresponding operation(s) on Receiver
Client  (CommandApp)
creates a ConcreteCommand object and sets its receiver
Invoker  (User)
asks the command to carry out the request
Receiver  (Calculator)
knows how to perform the operations associated with carrying out the request.