
// @author : Ismail "agneng" Ozsaygi

using UnityEngine;
using System.Collections.Generic;

class ObjectUtils
{
	//---------------------------------------------------------------------------------
        // Purpose : Gets same type objects in scene and returns them as an array.
	//           Type is given with generics.
	//           Since it is static declared , can be used like -> ObjectManager.GetSameTypeObjectsInScene< type >();
        //           It returns an array of type.
        //---------------------------------------------------------------------------------
	public static T[] GetSameTypeObjectsInScene< T >()
	{
		T[] objs = GameObject.FindObjectsOfType( typeof( T ) ) as T[];
		return ( objs );
	}

	//---------------------------------------------------------------------------------
        // Purpose : Adds given type / generic array to given list.
        //---------------------------------------------------------------------------------
	public static void AddTypeArrayToTypeList< T >( T[] typeArray , List< T > typeList )
	{
		int i;
		for( i = 0 ; i < typeArray.Length ; i++ )
		{
			typeList.Add( typeArray[ i ] );
		}
	}
}
