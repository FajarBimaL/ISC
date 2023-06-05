using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public int hp;
    public int hpMax;
    public int goldToGive;

    public Image hpImage;

    public void Damage(){
        hp--;
        SetHPBar();

        if (hp <= 0) Dead();
    }

    public void SetHPBar(){
        hpImage.fillAmount = (float)hp / (float)hpMax;
    }

    public void Dead(){
        enemyManager.instance.DestroyEnemy(gameObject);
        // Debug.Log("Enemy Defeated!");
    }
}
