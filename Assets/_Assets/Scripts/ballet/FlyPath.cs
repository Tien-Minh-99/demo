using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    private void Reset() => waypoints = GetComponentsInChildren<Waypoint>();
    //tìm tất cả các component Waypoint nằm trong GameObject hiện tại
    //và các con của nó trong Hierarchy.

}
