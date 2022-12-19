using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipRotator : MonoBehaviour
{
	void Update()
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
