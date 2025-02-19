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
    public class MotorInput : Message
    {
        public const string RosMessageName = "autonav_msgs/MotorInput";

        public float forward_velocity { get; set; }
        public float angular_velocity { get; set; }

        public MotorInput()
        {
            this.forward_velocity = 0.0f;
            this.angular_velocity = 0.0f;
        }

        public MotorInput(float forward_velocity, float angular_velocity)
        {
            this.forward_velocity = forward_velocity;
            this.angular_velocity = angular_velocity;
        }
    }
}
