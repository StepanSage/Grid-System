using TMPro;
using UnityEngine;
using Zenject;

public class ViewFindText : MonoBehaviour
{
    private const string FIND_TEXT = "Find ";

    [SerializeField] private TMP_Text _findText;

    private GetRandomIdCell _getRandomIdCell;

    [Inject]
    public void Init(GetRandomIdCell getRandomIdCell)
    {
        _getRandomIdCell = getRandomIdCell;
    }

    private void OnEnable()
    {
        _getRandomIdCell.IDCallBack += ApplyValueText; 
    }
    private void OnDisable()
    {
        _getRandomIdCell.IDCallBack -= ApplyValueText;
    }

    private void ApplyValueText(string text)
    {
        _findText.text = FIND_TEXT + text;
    }

    
}
