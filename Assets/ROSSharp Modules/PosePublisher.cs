﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class PosePublisher : UnityPublisher<Pose>
    {
        public UnityEngine.Transform tf;
        private UnityEngine.Vector3 startPos;

        private Pose message;
        private Point point;
        private Quaternion quaternion;

        private UnityEngine.Vector3 relPosition;
        private UnityEngine.Quaternion rotation;

        protected override void Start()
        {
            base.Start();
            startPos = tf.position;

            message = new Pose();
            point = new Point();
            quaternion = new Quaternion();

            message.position = point;
            message.orientation = quaternion;

            relPosition = new UnityEngine.Vector3();
            rotation = new UnityEngine.Quaternion();
        }

        private void Update()
        {
            Publish(message);
        }

        void FixedUpdate()
        {
            relPosition = tf.position - startPos;
            rotation = tf.rotation;

            point.x = relPosition.z;
            point.y = -relPosition.x;
            point.z = relPosition.y;
            quaternion.w = rotation.w;
            quaternion.x = rotation.x;
            quaternion.y = rotation.y;
            quaternion.z = rotation.z;
        }
    }
}