// From Unity3D user "IsGreen"

using UnityEngine;
using System.Collections;
 
public class JumpTest : MonoBehaviour {
 
    public float jumpHeight = 2f;
    public Vector3 direction = Vector3.forward;
 
    Vector3 position,jumpPosition;
    float time;
    bool jump = false;
    bool up = false;
 
    void Update(){
 
 
        // A bit confusing, could use cleaning up, doesn't fit our format
        if(up) if(jumpPosition.y<=transform.position.y) jumpPosition = transform.position;
                 else {
                            up = false;
                            Debug.Log("Jump Time: "+(Time.time-time)); // Not needed but interesting
                            Debug.Log("Jump Height: "+(jumpPosition.y - position.y));
       
                      }
 
    }
 
   
    void FixedUpdate () {      
       
       // Need to change this part in order for it to work with ours, Also logic organization could use a lot of work
        if (Input.GetKeyDown(KeyCode.Space)) if(!jump){
            
            // Not so sure initialVelocity is needed but it seems like it'll do what we want
            float initialVelocity = Mathf.Sqrt(jumpHeight*2f*-Physics.gravity.y);
            Debug.Log("initialVelocity: "+initialVelocity);
            
            // Useful, keep and do not change
            Vector3 jumpDirection = Vector3.up*initialVelocity+direction;
            rigidbody.AddRelativeForce(jumpDirection,ForceMode.VelocityChange);
            
            // Reposition so these make more sense
            position = jumpPosition = transform.position;
            jump = up = true;
            time = Time.time;
 
        }
 
    }
 
    // We will need to create a colider aka "ceiling" for all of this to work. That's not really the goal we had in mind,
    // instead we want a script that alows adding to the relative up force with no "ceiling" limiting the height. We want
    // jump height limited by a certain Maximum attainable height from a single jump. Also jump needs to continue going higher
    // until this max height point when space bar is held for longer peroids
    void OnCollisionEnter(){
 
        jump = false;
   
    }
 
}
 
