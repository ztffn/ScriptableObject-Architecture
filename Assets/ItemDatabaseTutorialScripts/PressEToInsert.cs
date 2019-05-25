using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEToInsert : MonoBehaviour {
public GameObject player;

void Update() {
        // If E is down, and player is close enough to object.
        if (Input.GetKey(KeyCode.E) && Vector3.Distance(player.transform.position, transform.position) < 2f) {
                Inventory.Instance.InsertItem(new ItemInstance(item: GetComponent<PhysicalItem>().scriptableObjectRepresentation,
                                                               quantity: 1,
                                                               quality: Quality.QualityGrade.Mystic,
                                                               isNew: true));
                // Remove item from the world.
                Destroy(gameObject);
        }
}
}
