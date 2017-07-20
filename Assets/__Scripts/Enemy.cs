﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Enemy {
	
	// These are declarations of properties that will be implemented by all
	// Classes that implement the Enemy interface
	Vector3 pos { get; set; } // The Enemy's transform.position
	float touchDamage { get; set; } // Damage done by touching the Enemy
}