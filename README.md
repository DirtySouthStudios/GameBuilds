Scripts
==========

 Please use the following template for all SCRIPTS:
 
 //Name of programmer
 //Date started
 //Last Edit
 //Proper Location
 //Proper Prefab attachment
 
 using UnityEngine;
 using System.Collections;
 
 //All variables must be grouped properly and explained if use is not obvious
 
 EXAMPLE:
 // Movement variables
 public float moveSpeed;
 private float maxMoveSpeed;
 
 // Positioning variables
 private float currentPosition;
 private float targetPosition;

 
 // Main methods are compiled in the order of Awake(), Start(), Update()
 // Please organize them in the way they compile so as to not confuse
 // If not using any of the above methods please come up with a logical top to bottom organization of methods
 
 // Convetional way of naming methods
 void MyMethod ();
 void NewMethod ();
 
 // Conventional way of using IF statements
 
 if (1 > 0){
  return;
 }
 // If the method requires paramters and has a single line of programming, the following convention is preferred
 
 void VeryNewMethod(int current, int target, int a){ current * a * Time.Deltatime = target; }
 
 // Please explain in comments the use of each method ESPECIALLY if an algorithmic solution is used
 
 ...Further instructions of how to create new assets will be explained as we commit them to the build.
