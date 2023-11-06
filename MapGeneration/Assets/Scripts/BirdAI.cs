using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BirdAI : MonoBehaviour
{
    public static List<GameObject> goalList = new List<GameObject>();
    //NavMeshAgent agent;
    //Animator anim;
    [SerializeField] int i;
    const float speed = 2f;

    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        i = Random.Range(0, goalList.Count);
        //agent.SetDestination(goalList[i].transform.position);
        //anim = this.GetComponent<Animator>();
        //anim.SetTrigger("isWalking");
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, goalList[i].transform.position,
             speed * Time.deltaTime);

        if(Vector3.Distance(goalList[i].transform.position, this.transform.position) < 1)
        {
            i = Random.Range(0, goalList.Count);
            //agent.SetDestination(goalList[i].transform.position);
        }

    }
}