﻿using UnityEngine;
using UnityEngine.Events;

namespace PixelCrew.Components
{
    public class EnterTriggerComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent _acton;

        private void OnTriggerEnter2D(Collider2D other)
        {
           if (other.gameObject.CompareTag(_tag))
            {
                _acton?.Invoke();
            }
        }

    }

}
