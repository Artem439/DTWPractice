using DG.Tweening;
using UnityEngine;

namespace Game.Scripts
{
    [RequireComponent(typeof(Transform))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] [Min(0.5f)] private float _moveTime;
    
        private Transform _transformObject;

        private void Awake()
        {
            _transformObject = GetComponent<Transform>();
        }

        private void Start()
        {
            Move();
        }
    
        private void Move()
        {
            _transformObject.DOMove(_target.position, _moveTime);
        }
    }
}
