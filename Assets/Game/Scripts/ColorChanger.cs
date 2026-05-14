using UnityEngine;
using DG.Tweening;

namespace Game.Scripts
{
    [RequireComponent(typeof(MeshRenderer))]
    public class ColorChanger : MonoBehaviour
    {
        [SerializeField] [Min(0.5f)] private float _colorChangeTime;
        [SerializeField] private Color _colorValue;
    
        private Material _material;

        private void Awake()
        {
            _material = GetComponent<MeshRenderer>().material;
        }

        private void Start()
        {
            Change();
        }
    
        private void Change()
        {
            _material.DOColor(_colorValue, _colorChangeTime);
        }
    }
}