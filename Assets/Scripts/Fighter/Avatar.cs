using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class Avatar : Fighter
    {
        public Power Power;
        public int Armor;

        public void Interact()
        {
            Debug.LogWarning("Interact");
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
