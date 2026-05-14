using UnityEngine;
using DG.Tweening;

namespace Game.Scripts
{
    [RequireComponent(typeof(Transform))]
    public class Rotator : MonoBehaviour
    {
        [SerializeField] [Min(0.5f)] private float _rotateTime;
        [SerializeField] private Vector3 _rotateDegrees;
    
        private Transform _transformObject;

        private void Awake()
        {
            _transformObject = GetComponent<Transform>();
        }

        private void Start()
        {
            Rotate();
        }
    
        private void Rotate()
        {
            _transformObject.DORotate(_rotateDegrees, _rotateTime, RotateMode.FastBeyond360);
        }
    }
}