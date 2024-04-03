using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class VictoryWindow : AbstractWindow
{
    [SerializeField] private Image _blackout;
    [SerializeField] private float _timeBlackout;

    private void Start()
    {
        Hade();
    }
    public override void Show()
    {
        ApplyBlackout();
        base.Show();
    }

    public void ApplyBlackout()
    {
        _blackout.DOColor( new Color(0f, 0f, 0f, 0.5f), _timeBlackout);
    }




}
