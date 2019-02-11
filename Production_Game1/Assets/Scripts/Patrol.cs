using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour {

    private NavMeshAgent navAgent;
    private float patrol_Radius = 30f;
    private float patrol_Timer = 6f;
    private float timer_Count;
    /*here*/ Transform target;
    

    void Awake (){
        navAgent = GetComponent<NavMeshAgent>();
    }

	// Use this for initialization
	void Start () {
        timer_Count = patrol_Timer;
       /*here*/ target = player.instance.player.transform;
	}
	
	// Update is called once per frame
	void Update () {
        Patroling();
        /*here*/
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= patrol_Radius){

            navAgent.SetDestination(target.position);
            /*here*/
        }
	}

    void Patroling(){
        timer_Count += Time.deltaTime;

        if (timer_Count > patrol_Timer){
            SetNewRandomDestination();
            timer_Count = 0f;
        }

    }
    void SetNewRandomDestination(){

        Vector3 newDestination = RandomNavSphere(transform.position, patrol_Radius, -1);
        navAgent.SetDestination(newDestination);
    }
    Vector3 RandomNavSphere(Vector3 originPos, float radius, int layerMask){
        Vector3 randDir = Random.insideUnitSphere * radius;
        randDir += originPos;

        NavMeshHit navHit;
        NavMesh.SamplePosition(randDir, out navHit, radius, layerMask);

        return navHit.position;
    }
}

