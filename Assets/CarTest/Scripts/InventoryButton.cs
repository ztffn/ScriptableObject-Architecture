using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjectArchitecture.Examples
{
public class InventoryButton : MonoBehaviour
{
[SerializeField]
private Text _textTarget;
[SerializeField]
private Image _spriteTarget;
//[SerializeField]
//private BaseCollection _setTarget = default(BaseCollection);


public void SetText(string textString)
{

        _textTarget.text = textString;
}

public void SetImage()
{

        //    _spriteTarget.sprite = imageLink;
}

//  _textTarget.text = string.Format(_textFormat, _setTarget.Count);
private void OnClick()
{
}

}
}
