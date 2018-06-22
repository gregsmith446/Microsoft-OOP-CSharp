// Implementing the IDisposable Interface

// Ensure that the System namespace is in scope by adding the following using statement to the top of the code file.
using System;

// Implement the IDisposable interface in your class definition.
public class ManagedWord : IDisposable
    {
       public void Dispose()
       {
          throw new NotImplementedException();
       }
        
        // Add a private field to the class
        // use to track the disposal status of the object, 
        // and check whether the Dispose method has already been invoked and 
        // the resources released.
        bool _isDisposed;
        
        // example of a public class 
        public void OpenWordDocument(string filePath)
        {
            // check whether the object has already been disposed of. 
            // If the object has been disposed of, you should throw an ObjectDisposedException.
            if (this._isDisposed)
              throw new ObjectDisposedException("ManagedWord");
            
            // an overloaded implementation of the Dispose method
            // dispose of both managed and unmanaged resources if it was called directly (return true)
            // If you pass a Boolean parameter with the value of false, 
            // the Dispose method should only attempt to release unmanaged resources. 
            
            if (this._isDisposed)
                    return;
                if (isDisposing)
                {
                   // Release only managed resources.
                }
                // Always release unmanaged resources.
                
                // Indicate that the object has been disposed.
                this._isDisposed = true;  
        }
    
        // invoke the overloaded Dispose method
        // then call the GC.SuppressFinalize method
        // GC.SuppressFinalize instructs the GC that the resources
        // that the object referenced have already been released 
        // and the GC does not need to waste time running the finalization code.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }