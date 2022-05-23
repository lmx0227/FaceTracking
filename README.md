# FaceTracking

## [Lab Journal](https://docs.google.com/presentation/d/1SalMhhXoPPMfWYentVuB1wTzG46tLKjYs94u36TXw3Y/edit#slide=id.g113eb56c3c3_0_48)

## Documentation

### Assets

#### Face Model

-   **Source**: Using (1, neutral) from FaceScape TU Trainset_001_100
    -   more models (.obj files) and materials (.jpg files) for other facial expressions on this face can be found under `facescape_trainset_001_100/1/models_reg`
-   **Script**: switch between expressions can be done by an outside script (in any language) to change the unity assets in its directory

####  Objects

all room objects are created and grouped with basic geometries (e.g. cubes, cylinders, elipsoi...)

-   **Main Camera**: Left LEPD (direction based on the perspective from the face model)
    -   Script Behavior: When running the simulation,  after detect key "k" being pressed, this camera will take 1 picture/frame and export it to path ``~/MainCameraOutput/``
-   **Second Camera**: Right LEPD (direction based on the perspective from the face model)
    -   Script Behavior: When running the simulation, after detect key "k" being pressed, this camera will take 1 picture/frame and export it to path ``~/SecondCameraOutput/``

-   **Infrared**: Infrared point light sources in a circle shining at the face model, organized into 2 groups for manipulation and adjustment purpose

    -   **Infrared_Right**: 3 Infrared point light sources on the right
    -   **Infrared_Left**: 3 Infrared point light sources on the left

-   **Room**: a to scale (1 unit in unity = 1 meter in reality) replication of the lab room

    Materials used for Room Objects are all simple materials created with 1 color, stored under Assets/Materials with names according to the Object name

    -   **Floor**: a to scale cube representing the floor
    -   **door**: a to scale cube representing the door
    -   **wall_0**: a to scale cube representing one side wall
    -   **wall_1**: a to scale cube representing one side wall
    -   **wall_2**: a to scale cube representing one side wall
    -   **wall_3**: a to scale cube representing one side wall
    -   **bookshelf**: a to scale cube representing the bookshelf at corner
    -   **blueCloset**: a to scale cube representing the blue closet at corner
    -   **redDesk**: a to scale cube representing the red desk along one side wall
    -   **blueDesk**: a to scale cube representing the blue desk along one side wall
    -   **warning_0**: a to scale cube representing a warning sign on one side wall
    -   **warning_1**: a to scale cube representing a warning sign on one side wall
    -   **warning_2**: a to scale cube representing a warning sign on one side wall

-   **desk_0**: a to scale (1 unit in unity = 1 meter in reality) replication of the desk that supports chinrest
-   **desk_1**: a to scale (1 unit in unity = 1 meter in reality) replication of the other desk at center
-   **chinrest**: a to scale cube represent the chinrest for faces

### Scripts

-   **MainExport**: a C# script file that controls the "taking picture" behavior of the left LEPD
-   **SecondExport**: a C# script file that controls the "taking picture" behavior of the right LEPD

## Used Resouces

-   for studying the basics of Unity:
    -   Unity Learn: Unity Essentials - Get started with Unity
    -   Unity Learn: Unity Essentials - Explore Unity (Real-time Industry Essentials)
    -   Unity Learn: Unity Essentials - Explore Unity (Scene Building Essentials)
    -   Unity Learn: Unity Essentials - Explore Unity (Publishing)
-   for C# coding in Unity
    -   Unity Learn: Unity Essentials - Junior Programmer (Absolute Beginner Code Comprehension)
    -   Unity Learn: Unity Essentials - Junior Programmer (Absolute Beginner Application)
    -   [YouTube: Learn C# Scripting for Unity(2020)](https://www.youtube.com/watch?v=9tMvzrqBUP8)
-   For Version Control
    -   Unity’s official [tutorial](https://unityatscale.com/unity-version-control-guide/how-to-setup-unity-project-on-github/)
    -   [useful blogs](http://www.walterpalladino.com/adding-an-existing-unity-project-to-github/)
-   FaceScape Models to Unity Objects
    -   [Unity documentation](https://docs.unity3d.com/Manual/ImportingModelFiles.html)
