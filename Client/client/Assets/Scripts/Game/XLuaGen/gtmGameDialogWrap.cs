﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class gtmGameDialogWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(gtmGame.Dialog);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Create", _m_Create);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVisible", _m_SetVisible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParent", _m_SetParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddBtnClickListener", _m_AddBtnClickListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGameObjectInChild", _m_GetGameObjectInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetScrollRectInChild", _m_GetScrollRectInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInputFieldInChild", _m_GetInputFieldInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetButtonInChild", _m_GetButtonInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetImageInChild", _m_GetImageInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTextInChild", _m_GetTextInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInteractable", _m_SetInteractable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetText", _m_SetText);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGameObjectVisible", _m_SetGameObjectVisible);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootDialog", _g_get_rootDialog);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "visible", _g_get_visible);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					gtmGame.Dialog gen_ret = new gtmGame.Dialog();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to gtmGame.Dialog constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _layoutname = LuaAPI.lua_tostring(L, 2);
                    string _tablename = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.Create( _layoutname, _tablename );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVisible(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _visible = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetVisible( _visible );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetParent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    gtmGame.UILayer _layer;translator.Get(L, 2, out _layer);
                    
                    gen_to_be_invoked.SetParent( _layer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddBtnClickListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.UI.Button _btn = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
                    UnityEngine.Events.UnityAction _action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 3);
                    
                    gen_to_be_invoked.AddBtnClickListener( _btn, _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGameObjectInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.GameObject gen_ret = gen_to_be_invoked.GetGameObjectInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetScrollRectInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.ScrollRect gen_ret = gen_to_be_invoked.GetScrollRectInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInputFieldInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.InputField gen_ret = gen_to_be_invoked.GetInputFieldInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetButtonInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.Button gen_ret = gen_to_be_invoked.GetButtonInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetImageInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.Image gen_ret = gen_to_be_invoked.GetImageInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTextInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.Text gen_ret = gen_to_be_invoked.GetTextInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInteractable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.UI.Selectable _selectable = (UnityEngine.UI.Selectable)translator.GetObject(L, 2, typeof(UnityEngine.UI.Selectable));
                    bool _interactable = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetInteractable( _selectable, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetText(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.UI.Text _text = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
                    string _info = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.SetText( _text, _info );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGameObjectVisible(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    bool _visible = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetGameObjectVisible( _go, _visible );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rootDialog(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rootDialog);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_visible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.visible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
