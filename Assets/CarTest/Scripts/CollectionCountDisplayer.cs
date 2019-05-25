using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjectArchitecture.Examples
{
public class CollectionCountDisplayer : MonoBehaviour
{
[SerializeField]
private Text _textTarget = default(Text);
[SerializeField]
private BaseCollection _setTarget = default(BaseCollection);
[SerializeField]
private string _description = "Engine";
[SerializeField]
private string _textFormat = "You have {0} parts.";

private void Update()
{
        _textTarget.text = string.Format(_textFormat, _setTarget.Count, _description);
}
}
}
