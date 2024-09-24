using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class Avatar : Fighter
    {
        public Power Power;
        public EntitySO Entity;

        public void passInfo()
        {
            GameManager.gameManager.avatarImg.sprite = Entity.Design;
            GameManager.gameManager.avatarNAME.text = Entity.Name;
        }
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
