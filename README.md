# Design Pattern 

here I recovered Builder and Mediator Design Pattern.

== Builder Design Pattern
We can say the Builder Design Pattern is useful : 
When you decouple the process of building a complex object from the parts that make up the object.
When you want to isolate the code for construction and representation.


The Builder Design Pattern builds a complex object using many simple objects and using a step-by-step approach.
here I implemented the Report example by Builder

    Step 1: I created Report.cs that defined the attributes (such as ReportHeader, ReportFooter, ReportFooter, and ReportContent) which are common to create a report.

    Step 2: Creating the Abstract Builder class [ReportBuilder.cs] that have we have four abstract methods
    each subclass of ReportBuilder need to implement those methods.

    Setp 3: Now we can create concrete Builder classes, here I am dealing with two types of reports i.e. Excel and PDF
    ExcelReport.cs that implement ReportBuilder abstract class and provides implementation to all the abstract methods

    Setp 4:
    Then [The director will execute the required steps to create a particular report.]
    we can find ReportDirector.cs that have one generic method called MakeReport which will abstract relation with our builder 

== Mediator Design Pattern

Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.

So, we have Mediator: It is an interface and it defines all possible interactions between colleagues That you can find in [FacebookGroupMediator]
then I created ConcreteMediator implment FacebookGroupMediator interface 
then I created User is an abstract class and ConcreteUser 
This is a concrete class and this class implements the User abstract class and provides the implementation for the Send and Receive abstract methods. The Send method is basically used to send a message to a particular Facebook group. The Receive method is used to receive a message from a particular Facebook group.


