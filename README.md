# Kinect Human Detection Project

## Project Overview
This project uses a Kinect v2 sensor to detect the distance between a person and a robot. The goal is to allow the robot to adjust its behavior based on the person’s proximity, ensuring safety in human-robot interactions.

---

## Table of Contents
1. [Prerequisites](#prerequisites)
2. [Installation](#installation)
3. [Kinect Setup](#kinect-setup)
4. [Building the Project](#building-the-project)
5. [Running the Project](#running-the-project)
6. [Testing](#testing)

---

## 1. Prerequisites

Before starting, make sure you have the following:

### Hardware
- **Kinect v2 Sensor**
- **Kinect v2 USB Adapter**
- **Windows PC** (with USB 3.0 port)

### Software
- **Windows 10/11**
- **Kinect SDK v2.0**: [Download from Microsoft](https://www.microsoft.com/en-us/download/details.aspx?id=44561)
- **Visual Studio 2019 or later**
- **.NET Framework 4.7.2 or later**

---

## 2. Installation

### Install Kinect SDK v2.0
1. Download the Kinect for Windows SDK v2.0 from [Microsoft’s official site](https://www.microsoft.com/en-us/download/details.aspx?id=44561).
2. Install the SDK by running the downloaded installer and following the prompts.

### Install Visual Studio
1. Download and install [Visual Studio](https://visualstudio.microsoft.com/downloads/).
2. During installation, ensure you select the **.NET desktop development** workload.
3. Ensure **.NET Framework 4.7.2 or later** is installed.

---

## 3. Kinect Setup

1. **Connect the Kinect sensor** to your PC using the Kinect USB adapter.
2. Run the **Kinect Configuration Verifier** tool (installed with the Kinect SDK) to ensure that:
   - Your PC meets the requirements (USB 3.0 support, GPU, etc.).
   - The Kinect sensor is correctly recognized.

---

## 4. Building the Project

1. **Clone the repository** to your local machine:
   ```bash
   git clone https://github.com/your-username/your-repo.git
   cd your-repo
