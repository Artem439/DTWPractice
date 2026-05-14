using UnityEngine;
using DG.Tweening;

namespace Game.Scripts
{
    [RequireComponent(typeof(Transform))]
    public class Scaler : MonoBehaviour
    {
        [SerializeField] [Min(0.5f)] private float _scaleTime;
        [SerializeField] private Vector3 _scaleValue;
    
        private Transform _transformObject;

        private void Awake()
        {
            _transformObject = GetComponent<Transform>();
        }

        private void Start()
        {
            Scale();
        }
    
        private void Scale()
        {
            _transformObject.DOScale(_scaleValue, _scaleTime);
        }
    }
}