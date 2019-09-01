---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 6:33
---

---@type msgdispatcher
local msgdispatcher = require("msgdispatcher.msgdispatcher")

---@type ReqLogin
local reqlogin = require("msg.fbs.ReqLogin")

---@type RspLogin
local rsplogin = require("msg.fbs.RspLogin")

--local loginstate = require("gamestate.loginstate")
loginstate.evententer:Connect(function ()
    print("ui_login.show")

    local ui_login = require("ui.ui_login.ui_login")
    ui_login.show()
end)

---@class loginmodel
loginmodel = {}

---------------------------------------继承函数---------------------------------------

function loginmodel.create()
    msgdispatcher.registerFbMsg(rsplogin, loginmodel.onRspLogin_sc)
end

function loginmodel.close()
    msgdispatcher.unRegisterFbMsg(rsplogin, loginmodel.onRspLogin_sc)
end

--------------------------------------------------------------------------------------











---------------------------------------消息事件---------------------------------------

function loginmodel.sendreqlogin_cs(_account, _password)

    ---@type builder
    local builder = msgdispatcher.newBuilder(1024);

    local account = builder:CreateString(_account);
    local password = builder:CreateString(_password);

    reqlogin.Start(builder)
    reqlogin.AddAccount(builder, account)
    reqlogin.AddPassword(builder, password)

    local orc = reqlogin.End(builder)
    builder:Finish(orc)

    msgdispatcher.sendFbMsg(reqlogin, builder)
end

function loginmodel.onRspLogin_sc(msg)
    print(msg:Account())
    print(msg:Password())
end

--------------------------------------------------------------------------------------








return loginmodel;
