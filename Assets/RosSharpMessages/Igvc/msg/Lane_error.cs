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
    public class Lane_error : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "igvc_msgs/lane_error";

        public float error;

        public Lane_error()
        {
            this.error = 0.0f;
        }

        public Lane_error(float error)
        {
            this.error = error;
        }
    }
}
