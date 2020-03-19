﻿using RosSharp.RosBridgeClient.MessageTypes.Igvc;
using RosSharp.RosBridgeClient.MessageTypes.Sensor;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class IGVCConfigLoader : MonoBehaviour
    {

        public string robotName = "IGVC";

        private SimpleCarController simpleCarController;
        private ImagePublisher imagePublisher;
        private LaserScanPublisher laserScanPublisher;
        private IMUPublisher iMUPublisher;
        private VelocityPublisher velocityPublisher;
        private GPSPublisher gPSPublisher;
        private IGVCMotorsSubscriber motorsSubscriber;

        void Awake()
        {
            simpleCarController = this.GetComponent<SimpleCarController>();
            imagePublisher = this.GetComponent<ImagePublisher>();
            laserScanPublisher = this.GetComponent<LaserScanPublisher>();
            iMUPublisher = this.GetComponent<IMUPublisher>();
            velocityPublisher = this.GetComponent<VelocityPublisher>();
            gPSPublisher = this.GetComponent<GPSPublisher>();
            motorsSubscriber = this.GetComponent<IGVCMotorsSubscriber>();

            simpleCarController.useController = !RobotOptions.GetValue(robotName + "Autonomous").Equals("True");
            //rosConnector.RosBridgeServerUrl = "ws://" + RobotOptions.GetValue(robotName + "ROS Bridge IP");
            if (RobotOptions.Exists(robotName + "Camera Topic"))
            {
                imagePublisher.Topic = RobotOptions.GetValue(robotName + "Camera Topic");
            }
            laserScanPublisher.Topic = RobotOptions.GetValue(robotName + "Laser Scan Topic");
            iMUPublisher.Topic = RobotOptions.GetValue(robotName + "IMU Topic");
            velocityPublisher.Topic = RobotOptions.GetValue(robotName + "Velocity Topic");
            gPSPublisher.Topic = RobotOptions.GetValue(robotName + "GPS Topic");
            motorsSubscriber.Topic = RobotOptions.GetValue(robotName + "Motors Topic");
        }
    }
}