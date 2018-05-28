# Unity Object Utilities
Unity object utilities helps you get same type of object in scene and load it in array.

## How to use ?
Here is an example about how to use it ;
```c#
using UnityEngine;
using System.Collections.Generic;

class EnemyManager : MonoBehaviour
{
	/* Our enemy lists , since they are static , they can be called from other files like -> EnemyManager.monabotList */
	public static List< MonaBotBaby > monabotList = new List< MonaBotBaby >();

	//---------------------------------------------------------------------------------
    // Purpose : Just Unity's callback function that will run on scene start.
    //---------------------------------------------------------------------------------
	private void Start()
	{
		GetMonabotsInScene();
	}

	//---------------------------------------------------------------------------------
    // Purpose : Gets all monabots in scene.
	//           Uses custom ObjectManager.GetSameTypeObjectsInScene function.
	//           Uses ObjectManager.AddTypeArrayToTypeList
    //---------------------------------------------------------------------------------
	private void GetMonabotsInScene()
	{
		MonaBotBaby[] tmp = ObjectUtils.GetSameTypeObjectsInScene< MonaBotBaby >();
		ObjectUtils.AddTypeArrayToTypeList< MonaBotBaby >( tmp , monabotList );
	}
}
```
