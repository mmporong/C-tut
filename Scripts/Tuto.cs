using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto: MonoBehaviour {
    // Start is called before the first frame update

    int newNumber = GetRandomNumber();
    
    void Start() {
        Monster ork
        Attack(ork, 5, 30);

        Monster goblin
        Attack(goblin, 20, 5);
     
       
    }

    int GetRandomNumber(){
        int number = 0;
        return number;
    }

    void Attack(Monster target, int damage, int point) {
        PlayAnimation();
        PlaySound();
        target.hp = target.hp - damage;
        exp = exp + point;
    }
    // Update is called once per frame
    void Update() {}
}
