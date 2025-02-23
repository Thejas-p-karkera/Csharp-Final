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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{

    // Publisher class (sends notifications)
    class VideoEncoder
    {
        public delegate void VideoEncodedHandler(string videoTitle); // Define delegate
        public event VideoEncodedHandler VideoEncoded; // Declare event

        public void Encode(string videoTitle)
        {
            Console.WriteLine($"Encoding video: {videoTitle}");

            // Notify subscribers
            if (VideoEncoded != null)
            {
                VideoEncoded(videoTitle);
            }
        }
    }

    // Subscriber 1 - SMS Notification
    class SmsNotification
    {
        public void SendSms(string videoTitle)
        {
            Console.WriteLine($"SMS: Video '{videoTitle}' has been encoded.");
        }
    }

    // Subscriber 2 - Mail Notification
    class MailNotification
    {
        public void SendMail(string videoTitle)
        {
            Console.WriteLine($"Mail: Video '{videoTitle}' has been encoded.");
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            VideoEncoder encoder = new VideoEncoder();  // Create Publisher
            SmsNotification sms = new SmsNotification(); // Create Subscriber 1
            MailNotification mail = new MailNotification(); // Create Subscriber 2

            // Subscribers register (subscribe) to the event
            encoder.VideoEncoded += sms.SendSms;
            encoder.VideoEncoded += mail.SendMail;

            // Encoding a video (will trigger event)
            encoder.Encode("My First Video");

            Console.ReadLine();
        }
    }

}
