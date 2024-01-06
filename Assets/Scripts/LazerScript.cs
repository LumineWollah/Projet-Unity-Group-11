using System;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;


public class LazerScript : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    private LineRenderer laserLine;
    
    [Obsolete("Obsolete")]
    private void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        laserLine.SetWidth (.2f,.2f);
    }

    private void Update()
    {
        laserLine.SetPosition(0,startPoint.position);
        laserLine.SetPosition(1,endPoint.position);
    }
}
