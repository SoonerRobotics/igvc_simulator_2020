/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Igvc
{
    public class Gps : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "igvc_msgs/gps";

        public double latitude;
        public double longitude;

        public Gps()
        {
            this.latitude = 0.0;
            this.longitude = 0.0;
        }

        public Gps(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
