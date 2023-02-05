using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptChase : MonoBehaviour
{

    public float MaxSpeed;
    private float Speed;


    //To see if anyone is in range
    private Collider[] hitColliders;
    //Laser to see if it's in line of sight
    private RaycastHit Hit;


    public float SightRange;
    public float DetectionRange;


    public Rigidbody rb;
    public GameObject Target;


    private bool seePlayer;


    void Start()
    {
        Speed = MaxSpeed;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver4");
        }
        else
        {
            if (other.tag != "Player")
            {
                Update();
            }
        }
    }



    void Update()
    {
        //Detect players in range

        if (!seePlayer)
        {
            hitColliders = Physics.OverlapSphere(transform.position, DetectionRange);
            foreach (var HitCollider in hitColliders)
            {
                if (HitCollider.tag == "Player")
                {
                    Target = HitCollider.gameObject;
                    seePlayer = true;
                }
            }

        }
        else
        {
            if (Physics.Raycast(transform.position, (Target.transform.position - transform.position), out Hit, SightRange))
            {
                if (Hit.collider.tag != "Player")
                {
                    seePlayer = false;
                }
                else
                {
                    //calculate position/direction of player

                    var Heading = Target.transform.position - transform.position;
                    var Distance = Heading.magnitude;
                    var Direction = Heading / Distance;
                    //move to player

                    Vector3 Move = new Vector3(Direction.x * Speed, 0, Direction.z * Speed);
                    rb.velocity = Move;
                    transform.forward = Move;


                }
            }
        }
    }
}
