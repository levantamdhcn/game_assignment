using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public int Respawn;
    private Animator            m_animator;
    void Start ()
    {
        m_animator = GetComponent<Animator>();
        
    }
   
    // Start is called before the first frame update
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            
            m_animator.SetTrigger("Death");
        }
    }
}
