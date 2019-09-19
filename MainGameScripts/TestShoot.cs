using UnityEngine;
using System.Collections;

public class TestShoot : MonoBehaviour
{
    private OVRGrabbable grab;
    public OVRInput.Button ShootButton;
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;
    private float gunDamage = 1;



    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;


    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;


    void Start()
    {
        grab = GetComponent<OVRGrabbable>();



    }



        // Update is called once per frame
        void Update ()
        {


        if(grab.isGrabbed && OVRInput.GetDown(ShootButton, grab.grabbedBy.GetController()))
        //(Input.GetButtonDown("Fire1"))
        {
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;

            Temporary_Bullet_Handler = Instantiate(Bullet,Bullet_Emitter.transform.position,Bullet_Emitter.transform.rotation) as GameObject;

            //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
            //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 0);

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            Destroy(Temporary_Bullet_Handler, 10f);//








        }
    }

  }
