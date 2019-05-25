using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPartPhysical : MonoBehaviour {
public CarPart partScriptableObject;
public Transform attachmentPoint;

void Start()
{
        //this.CarPart.scriptableObjectRepresentation = instance;
        Instantiate(partScriptableObject.physicalRepresentation, attachmentPoint);
}

}
