using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantEnemy : Enemy
{
    public GiantEnemy() : base()
    {
        hp = 500;
        speed = 1;
        damage = 15;
    }
}