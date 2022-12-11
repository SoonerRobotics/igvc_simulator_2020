/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Autonav
{
    public class MotorFeedback : Message
    {
        public const string RosMessageName = "autonav_msgs/MotorFeedback";

        //  deltaX - float32 - The change in the X position in meters
        public float delta_x { get; set; }
        //  deltaY - float32 - The change in the Y position in meters
        public float delta_y { get; set; }
        //  deltaTheta - float32 - The change in the Theta in radians
        public float delta_theta { get; set; }

        public MotorFeedback()
        {
            this.delta_x = 0.0f;
            this.delta_y = 0.0f;
            this.delta_theta = 0.0f;
        }

        public MotorFeedback(float delta_x, float delta_y, float delta_theta)
        {
            this.delta_x = delta_x;
            this.delta_y = delta_y;
            this.delta_theta = delta_theta;
        }
    }
}