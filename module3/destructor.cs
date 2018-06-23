// You can add a destructor to a class to perform any additional application-specific cleanup that is necessary.

//To define a destructor, you add a tilde (~) followed by the name of the class. Then enclose the destructor logic in braces. 

// Defining a Destructor
class ManagedWord
{
    // Destructor
    ~ManagedWord()
    {
        // to guarantee that the Dispose method is always invoked, 
        // add a call to the Dispose method/invoke the Dispose method from a destructor.
        Dispose(false);
    }
}


// KEY CONCEPT --> manage the lifetime of an object
// invoke the dispose method when you have finished with an object
// if you do not implement a destructor to invoke the dispose method,
// here are other ways you can do that:

// 1.) invoke the dispose method after any other code that uses the object
// invoke the Dispose method on an object that implements the IDisposable interface

var word = new ManagedWord();
 // Code to use the ManagedWord object.
word.Dispose();
// POSSIBLE ISSUES - code can thow an exception before the call to Dispose(), then Dispose() will not run

// more reliable approach is to invoke Dispose() in the 'finally' block of a 'try/catch/finally' statement
// code in that 'try/catch/finally' block will always execute, regardless of any exceptions thrown
// 2.) Invoking the Dispose Method in a finally Block
// GUARANTEES the code will invoke Dispose()/ works even without the IDisposable interface

var word = default(ManagedWord);
try
{
   word = new ManagedWord();
   // Code to use the ManagedWord object.
}
catch
{
    // Code to handle any errors.
}
finally
{
   if(word!=null)
      word.Dispose();
}
// When explicitly invoking the Dispose method, 
// it is good practice to check whether the object is not null beforehand, 
// as you cannot guarantee the state of the object.

// 3.) can also implicitly dispose of object by using a 'using statement'
using (var word = default(ManagedWord))
{
   // Code to use the ManagedWord object.
}


