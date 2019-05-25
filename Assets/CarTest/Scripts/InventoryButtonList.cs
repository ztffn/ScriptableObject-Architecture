using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace ScriptableObjectArchitecture.Examples
{
public class InventoryButtonList : MonoBehaviour
{
[SerializeField]
private GameObject inventoryButtonTemplate;
[SerializeField]
private BaseCollection _setTarget = default(BaseCollection);

void Start()
{

        var inventorysize = _setTarget.Count;
        for (int i = 0; i <= inventorysize; i++)

        {
                object currentIndex = _setTarget[i];
                //    Debug.Log("Hello: " + currentIndex.itemName);
                //  GameObject objToDisable = _targetSet[index];
                //    objToDisable.SetActive(false);

///
                GameObject button = Instantiate(inventoryButtonTemplate) as GameObject;
                button.SetActive(true);

                button.GetComponent<InventoryButton>().SetText("Button #" + i);


                button.transform.SetParent(inventoryButtonTemplate.transform.parent, false);

        }
}

/*
   void GenerateButtons(string textString)
   {
   _textTarget.text =  textString;
       //  _textTarget.text = string.Format(_textFormat, _setTarget.Count);
   }
 */

}
}
