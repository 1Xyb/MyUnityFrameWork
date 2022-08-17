﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DataTableWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DataTable), typeof(System.Collections.Generic.Dictionary<string,SingleData>));
		L.RegFunction("Analysis", Analysis);
		L.RegFunction("AnalysisNoteValue", AnalysisNoteValue);
		L.RegFunction("AnalysisDefaultValue", AnalysisDefaultValue);
		L.RegFunction("AnalysisFieldType", AnalysisFieldType);
		L.RegFunction("Serialize", Serialize);
		L.RegFunction("ConvertStringArray", ConvertStringArray);
		L.RegFunction("GetFieldType", GetFieldType);
		L.RegFunction("GetArraySplitFormat", GetArraySplitFormat);
		L.RegFunction("SetFieldType", SetFieldType);
		L.RegFunction("SetAssetTypes", SetAssetTypes);
		L.RegFunction("GetLineFromKey", GetLineFromKey);
		L.RegFunction("GetEnumType", GetEnumType);
		L.RegFunction("GetDefault", GetDefault);
		L.RegFunction("SetDefault", SetDefault);
		L.RegFunction("SetNote", SetNote);
		L.RegFunction("GetNote", GetNote);
		L.RegFunction("AddData", AddData);
		L.RegFunction("SetData", SetData);
		L.RegFunction("RemoveData", RemoveData);
		L.RegFunction("New", _CreateDataTable);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("m_tableName", get_m_tableName, set_m_tableName);
		L.RegVar("m_defaultValue", get_m_defaultValue, set_m_defaultValue);
		L.RegVar("m_noteValue", get_m_noteValue, set_m_noteValue);
		L.RegVar("m_tableTypes", get_m_tableTypes, set_m_tableTypes);
		L.RegVar("m_ArraySplitFormat", get_m_ArraySplitFormat, set_m_ArraySplitFormat);
		L.RegVar("m_tableEnumTypes", get_m_tableEnumTypes, set_m_tableEnumTypes);
		L.RegVar("TableKeys", get_TableKeys, set_TableKeys);
		L.RegVar("TableIDs", get_TableIDs, set_TableIDs);
		L.RegVar("m_fieldAssetTypes", get_m_fieldAssetTypes, set_m_fieldAssetTypes);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDataTable(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				DataTable obj = new DataTable();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: DataTable.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Analysis(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			DataTable o = DataTable.Analysis(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AnalysisNoteValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable arg0 = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string[] arg1 = ToLua.CheckStringArray(L, 2);
			DataTable.AnalysisNoteValue(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AnalysisDefaultValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable arg0 = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string[] arg1 = ToLua.CheckStringArray(L, 2);
			DataTable.AnalysisDefaultValue(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AnalysisFieldType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable arg0 = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string[] arg1 = ToLua.CheckStringArray(L, 2);
			DataTable.AnalysisFieldType(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Serialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DataTable arg0 = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string o = DataTable.Serialize(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConvertStringArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string[] o = DataTable.ConvertStringArray(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFieldType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			FieldType o = obj.GetFieldType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetArraySplitFormat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			char[] o = obj.GetArraySplitFormat(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFieldType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			FieldType arg1 = (FieldType)ToLua.CheckObject(L, 3, typeof(FieldType));
			string arg2 = ToLua.CheckString(L, 4);
			obj.SetFieldType(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAssetTypes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			DataFieldAssetType arg1 = (DataFieldAssetType)ToLua.CheckObject(L, 3, typeof(DataFieldAssetType));
			obj.SetAssetTypes(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLineFromKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			SingleData o = obj.GetLineFromKey(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.GetEnumType(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDefault(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.GetDefault(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDefault(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.SetDefault(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetNote(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.SetNote(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNote(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.GetNote(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			SingleData arg0 = (SingleData)ToLua.CheckObject(L, 2, typeof(SingleData));
			obj.AddData(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			SingleData arg0 = (SingleData)ToLua.CheckObject(L, 2, typeof(SingleData));
			obj.SetData(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DataTable obj = (DataTable)ToLua.CheckObject(L, 1, typeof(DataTable));
			string arg0 = ToLua.CheckString(L, 2);
			obj.RemoveData(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_tableName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			string ret = obj.m_tableName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_tableName on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_defaultValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,string> ret = obj.m_defaultValue;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_defaultValue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_noteValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,string> ret = obj.m_noteValue;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_noteValue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_tableTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,FieldType> ret = obj.m_tableTypes;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_tableTypes on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_ArraySplitFormat(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,char[]> ret = obj.m_ArraySplitFormat;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_ArraySplitFormat on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_tableEnumTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,string> ret = obj.m_tableEnumTypes;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_tableEnumTypes on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TableKeys(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.List<string> ret = obj.TableKeys;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index TableKeys on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TableIDs(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.List<string> ret = obj.TableIDs;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index TableIDs on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_fieldAssetTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,DataFieldAssetType> ret = obj.m_fieldAssetTypes;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_fieldAssetTypes on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_tableName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.m_tableName = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_tableName on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_defaultValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,string> arg0 = (System.Collections.Generic.Dictionary<string,string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,string>));
			obj.m_defaultValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_defaultValue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_noteValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,string> arg0 = (System.Collections.Generic.Dictionary<string,string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,string>));
			obj.m_noteValue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_noteValue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_tableTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,FieldType> arg0 = (System.Collections.Generic.Dictionary<string,FieldType>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,FieldType>));
			obj.m_tableTypes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_tableTypes on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_ArraySplitFormat(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,char[]> arg0 = (System.Collections.Generic.Dictionary<string,char[]>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,char[]>));
			obj.m_ArraySplitFormat = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_ArraySplitFormat on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_tableEnumTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,string> arg0 = (System.Collections.Generic.Dictionary<string,string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,string>));
			obj.m_tableEnumTypes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_tableEnumTypes on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_TableKeys(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.List<string> arg0 = (System.Collections.Generic.List<string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<string>));
			obj.TableKeys = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index TableKeys on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_TableIDs(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.List<string> arg0 = (System.Collections.Generic.List<string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<string>));
			obj.TableIDs = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index TableIDs on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_fieldAssetTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DataTable obj = (DataTable)o;
			System.Collections.Generic.Dictionary<string,DataFieldAssetType> arg0 = (System.Collections.Generic.Dictionary<string,DataFieldAssetType>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,DataFieldAssetType>));
			obj.m_fieldAssetTypes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_fieldAssetTypes on a nil value" : e.Message);
		}
	}
}

