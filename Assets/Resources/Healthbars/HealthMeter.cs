using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthMeter : MonoBehaviour
{
    [SerializeField]
    private GameObject middleBar;
    [SerializeField]
    private GameObject frontBar;
    private void Awake()
    {
        
    }
    public void SetMeterPercent(float percent)
    {
        float newX = (middleBar.transform.localScale.x / 100) * percent;
        frontBar.transform.localScale = new Vector3(newX, frontBar.transform.localScale.y, frontBar.transform.localScale.z);
    }
}
