using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "CarPart/Wheel", fileName = "Wheel.asset")]
public class Wheel : CarPart {
public WheelType wheelType;
public float weight;
public float gripFactor;

}
