# UnityEndless2DPan

Proof of Concept for a 2d camera that loops infinitely regardless of map size and aspect ratio

#### Hierarchy

* Main Camera
  * TrailCamera
* SceneLeftRoot !!y=0!!
  * Map background <left edge placed at x=0>
  *  > SceneRightRoot <placed on rightmost x> !!y=0!!
  * <All GameObjects to exist "on" the map>


#### ScreenClipRight Script
Attached to the Main Camera. This script:
* Identifies the map length by the distance between SceneLeftRoot and SceneRightRoot
* Keeps the TrailCamera a set distance away from the primary camera
* Jumps the main camera to the rightmost and leftmost boundaries when needed

#### OrientLeft Script
Attached to the SceneLeftRoot object. This script:
* OnStart() Adjusts the SceneLeftRoot position to be the starting leftmost position on Camera

Purpose: By dynamically positioning the root onStart(), we account for all aspect ratios

#### SpinObjectByXPosition
Attached to the Main Camera for no particular reason. Just needs access to calculate or ask for Map Length. This script:
* Has a "SpinningRoot" game object that you give it
* Will rotate assigned object based on current camera position:
  * Starting position is 0° rotation
  * Quarterway through the map is 90° rotation
  * Halfway point is 180° rotation
  * etc