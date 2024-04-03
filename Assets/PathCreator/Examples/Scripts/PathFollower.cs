﻿using UnityEngine;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Collections.Generic;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 0.5f;
        public float distanceTravelled;

        public bool RotationIgnoreXZ = true;

        void Start() {
            if (pathCreator != null)
            {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
            }
        }

        void Update()
        {
            if (pathCreator != null)
            { 
                void OnConnectionEvent(bool received)
                {
                    print(received);
                }
                void OnMessageArrived(string message)
                {
                    print(message);
                    if(message == "Slow!"&& speed >= 0.06)
                    {
                        speed -= 0.1f;
                        distanceTravelled += speed * Time.deltaTime;
                    }

                    if (message == "Fast!" && speed <= 0.2)
                    {
                        speed += 0.1f;
                        distanceTravelled += speed * Time.deltaTime;
                    }
                }
                if(Input.GetKeyDown(KeyCode.UpArrow) && speed <= 0.2)
                {
                    speed += 0.1f;
                    distanceTravelled += speed * Time.deltaTime;
                }
                if(Input.GetKeyDown(KeyCode.DownArrow) && speed >= 0.06)
                {
                    speed -= 0.1f;
                    distanceTravelled += speed * Time.deltaTime;
                }
                distanceTravelled += speed * Time.deltaTime;
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);

                // Fix rotation of player
                // https://www.youtube.com/watch?v=mM9T-0T5LjM
                if(RotationIgnoreXZ)
                {
                    Quaternion newRotate = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
                    newRotate.x = 0; 
                    newRotate.z = 0; 

                    transform.rotation = newRotate;
                }
                else
                {
                    transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
                }
            }
        }

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged() {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }
    }
}
