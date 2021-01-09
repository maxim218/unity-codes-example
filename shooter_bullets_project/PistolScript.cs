using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScript : MonoBehaviour {
    public void WaitAnimationRun() {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.CrossFade("PistolWaitAnim", 0);
    }
    
    public void PistolAllowFire() {
        GameObject hero = GameObject.Find("Hero");
        PlayerScript playerScript = hero.GetComponent<PlayerScript>();
        playerScript.AllowFire();
    }

    public void CreateBullet() {
        GameObject hero = GameObject.Find("Hero");
        PlayerScript playerScript = hero.GetComponent<PlayerScript>();
        playerScript.BulletFire();
    }
}
