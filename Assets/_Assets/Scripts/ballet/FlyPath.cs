using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;
    
    private void Reset()
    {
        waypoints = GetComponentsInChildren<Waypoint>();
        //tìm tất cả các component Waypoint nằm trong GameObject hiện tại
        //và các con của nó trong Hierarchy.
    }
    public Vector3 this[int index] => waypoints[index].transform.position;//chưa hiểu 
    private void OnDrawGizmos()
    {
        if (waypoints == null)
        {
            return;
        }
        Gizmos.color = Color.green;
        for(int i = 0 ; i < waypoints.Length - 1 ; i++)
        {
            Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
        }
    }

}
