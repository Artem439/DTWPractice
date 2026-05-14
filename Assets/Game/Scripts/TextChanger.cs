using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace Game.Scripts
{
    public class TextChanger : MonoBehaviour
    {
        [SerializeField] [Min(0.5f)] private float _changeTime;
        
        [SerializeField] private Text _firstText;
        [SerializeField] private string _textForFirstText;
        [SerializeField] private Text _secondText;
        [SerializeField] private string _textForSecondText;
        [SerializeField] private Text _thirdText;
        [SerializeField] private string _textForThirdText;
    
        private void Start()
        {
            Change();
        }
    
        private void Change()
        {
            _firstText.DOText(_textForFirstText, _changeTime);
            _secondText.DOText(_textForSecondText, _changeTime).SetRelative();
            _thirdText.DOText(_textForThirdText, _changeTime, true, ScrambleMode.All);
        }
    }
}