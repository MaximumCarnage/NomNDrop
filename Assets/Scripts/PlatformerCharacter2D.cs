using System;
using UnityEngine;


    public class PlatformerCharacter2D : MonoBehaviour
    {
        [SerializeField] private float m_MaxSpeed = 10f;                   
        private Rigidbody2D m_Rigidbody2D;
        private void Awake()
        {
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
        }
        public void Move(float move)
        {
             m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, m_Rigidbody2D.velocity.y);
        }
    }

