using Microsoft.Kinect;
using System;
using System.Windows;
using System.Windows.Media;

namespace KinectDistanceDetection
{
    public partial class MainWindow : Window
    {
        private KinectSensor sensor;
        private BodyFrameReader bodyReader;
        private Body[] bodies;

        public MainWindow()
        {
            InitializeComponent();
            InitializeKinect();
        }

        private void InitializeKinect()
        {
            sensor = KinectSensor.GetDefault();
            bodyReader = sensor.BodyFrameSource.OpenReader();
            bodies = new Body[sensor.BodyFrameSource.BodyCount];

            if (sensor != null)
            {
                sensor.Open();
                bodyReader.FrameArrived += BodyReader_FrameArrived;
            }
        }

        private void BodyReader_FrameArrived(object sender, BodyFrameArrivedEventArgs e)
        {
            using (BodyFrame bodyFrame = e.FrameReference.AcquireFrame())
            {
                if (bodyFrame != null)
                {
                    bodyFrame.GetAndRefreshBodyData(bodies);

                    foreach (Body body in bodies)
                    {
                        if (body.IsTracked)
                        {
                            // Get the SpineBase joint, representing the person's torso
                            Joint spineBase = body.Joints[JointType.SpineBase];

                            if (spineBase.TrackingState == TrackingState.Tracked)
                            {
                                // Get the Z coordinate (distance from the sensor in meters)
                                float distance = spineBase.Position.Z;

                                // Update the UI to display the distance
                                UpdateDistanceText(distance);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateDistanceText(float distance)
        {
            // Update the UI text to show the distance in meters
            DistanceText.Text = $"Distance: {distance:F2} meters";

            // Optional: Adjust color based on distance for safety (e.g., green/yellow/red)
            if (distance > 2.0)
            {
                DistanceText.Foreground = Brushes.Green;  // Safe
            }
            else if (distance > 1.0)
            {
                DistanceText.Foreground = Brushes.Yellow;  // Caution
            }
            else
            {
                DistanceText.Foreground = Brushes.Red;  // Danger
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bodyReader.Dispose();
            sensor.Close();
        }
    }
}
