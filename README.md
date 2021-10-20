# Solid-5-The-Dependency-Inversion-Principle

The DI principle states that a high level module(eg static void Main or the Chore class in our example), should not depent on low 
level modules(eg the Logger or Emailer class). 

A high level module, is something that calls something else, whereas a low level module does not call anything(indipendent module).
If a high level module, depends on a low level module, any change on the low level module will break the code, unless we change the code 
anywhere the particular low level module exists, which is something we shouldn't need to do. 

The best way to achieve this, is make both high and low level modules depend on abstractions/interfaces. 
The result is:
*No monolithic apps
*No direct dependencies
*Lots of tiny parts of code, that each does only one thing
