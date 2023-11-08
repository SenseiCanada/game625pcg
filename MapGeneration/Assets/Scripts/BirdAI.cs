using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAI : MonoBehaviour
{
    public static List<GameObject> goalList = new List<GameObject>();
    [SerializeField] int i;
    const float speed = 20f;
    Vector3 targetDirection;
    Vector3 newDirection;
    void Start()
    {
        i = Random.Range(0, goalList.Count);
        targetDirection = goalList[i].transform.position - this.transform.position;
        newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed, 0.0f);
        this.transform.rotation = Quaternion.LookRotation(newDirection);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, goalList[i].transform.position,
             speed * Time.deltaTime);

        if(Vector3.Distance(goalList[i].transform.position, this.transform.position) < 1)
        {
            i = Random.Range(0, goalList.Count);
            targetDirection = goalList[i].transform.position - this.transform.position;
            newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
            this.transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}