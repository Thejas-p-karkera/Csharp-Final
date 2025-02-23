// Implement Publisher/Subscriber pattern using events and delegates.


//            Publisher and Subscriber

//               +----------------+
//               | Video Encoded  |              ←-------------------------- Publisher 
//               +----------------+
//                      |
//           ------------------------
//           |                      |
//           ↓                      ↓
//    +------------+          +------------+
//    |  Send SMS  |          |  Send Mail |      ←-------------------------- Subscriber
//    +------------+          +------------+

//------------------------------------------------------------------------------------------------------------------------------------------------------

// event.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace eventdelegate
{
    class Event
    {
        static void Main(string[] args)
        {
            video v = new video();
            v.set("Rona");
            Console.WriteLine(v.get());
            messageservice ms = new messageservice();
            mailservice mas = new mailservice();
            videoencode ve = new videoencode();
            ve.encodeevent += ms.videodemand;
            ve.encodeevent += mas.onvideodemand;
            ve.Encode(v);

        }
    }
}

//------------------------------------------------------------------------------------------------------------------------------------------------------

// mailservice.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace eventdelegate
{
   public class mailservice
    {
       public void onvideodemand()
       {
           Console.WriteLine("mail service:this is mail");
       }

    }
}

//------------------------------------------------------------------------------------------------------------------------------------------------------

// messageservice.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace eventdelegate
{
    public class messageservice
    {
        public void videodemand()
        {
            Console.WriteLine("Message service:this is a message");
        }
    

    }
}

//------------------------------------------------------------------------------------------------------------------------------------------------------

// video.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace eventdelegate
{
   public class video
    {
       string title;
       public string get()
       {
           return title;
       }
       public void set(string value)
       {
           title = value;
       }
    }
}

//------------------------------------------------------------------------------------------------------------------------------------------------------

// videoencode.cs

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace eventdelegate
{
   public class videoencode
    {
       public delegate void encodedelegate();
       public event encodedelegate encodeevent;
       public void Encode(video v)
       {
           Console.WriteLine("Encoding video");
           Thread.Sleep(1000);
           if (encodeevent != null)
           {
               encodeevent();
           }
       }


    }
}
