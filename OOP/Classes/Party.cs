using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Let's create our namespace we will use to group our classes together
namespace Abstraction.Classes
{
    // This is a really important keyword "abstract"
    // We absolutely CANNOT make an object here 
  public abstract class Party
  {
    // has to be overridden!
    public abstract int MaxNumberOfGuests { get; set; }
    public abstract decimal Budget { get; set; }
    public abstract string Venue { get; set; }


    public abstract void Setup();
    public abstract void TearDown();

    }
}