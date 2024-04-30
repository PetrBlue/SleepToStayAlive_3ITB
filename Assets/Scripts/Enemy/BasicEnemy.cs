using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Enemy
{
    public BasicEnemy() : base()
    {
        hp = 100;
        speed = 3;
        damage = 10;
    }
}
