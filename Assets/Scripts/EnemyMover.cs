using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> waypointsForEnemy = new List<Waypoint>();

    // Start is called before the first frame update
    void Start()
    {
        PrintWayPointName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PrintWayPointName()
    {
        foreach (Waypoint waypoint in waypointsForEnemy)
        {
            Debug.Log(waypoint.name);
        }
    }
}
