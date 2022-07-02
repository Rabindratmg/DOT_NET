
using DelegatesEg;

WithoutUsingDelegate withoutusing = new WithoutUsingDelegate();
withoutusing.ClassInstance();

WithUsingDelegate withusing = new WithUsingDelegate();
withusing.CallMethod();
Console.WriteLine("This is using genereic delegate");
GenericDelegate genericDelegate = new GenericDelegate();
genericDelegate.CallMethod();
