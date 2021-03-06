---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 6:21
---

---@class ui_register
ui_register = {}

ui_register.uiname = "ui_panel_register"

---@type testmodel
ui_register.model = loginmodel


----------------------------------------------内置-------------------------------------------------

function ui_register.show()

    if ui_register.isShow then
        return ;
    end

    ---@type gtmGame.Dialog
    ui_register.dialog = ui_mgr.createDialog(ui_register.uiname, "ui_register");

    if not ui_register.dialog then
        print("ui_register.dialog null uiname " .. ui_register.uiname);
    end

    ui_register.isShow = true;

    ui_register.initui();
    ui_register.initEvent();
end

function ui_register.close()
    ui_mgr.closeDialog(ui_register.uiname);
end

function ui_register.preShow()
    print("ui_register.preShow")
end

function ui_register.preHide()
    print("ui_register.preHide")
end

function ui_register.preClose()
    print("ui_register.preClose")

    ui_register.isShow = false;
    ui_register.uiref = {};

    ui_register.removeEvent()
end

--- initui
function ui_register.initui()
    ui_register.uiref = {};

    local root = ui_register.dialog.rootDialog
    ui_register.uiref.input_account = ui_register.dialog:GetInputFieldInChild(root, "input_account")
    ui_register.uiref.input_password = ui_register.dialog:GetInputFieldInChild(root, "input_password")

    ui_register.uiref.btn_register = ui_register.dialog:GetButtonInChild(root, "btn_register")
    ui_register.uiref.btn_close = ui_register.dialog:GetButtonInChild(root, "btn_close")
end

--- init event
function ui_register.initEvent()

    ui_register.dialog:AddBtnClickListener(ui_register.uiref.btn_register, ui_register.onRegisterBtnClick)
    ui_register.dialog:AddBtnClickListener(ui_register.uiref.btn_close, ui_register.onCloseBtnClick)

    loginmodel.onRegAccEvent:AddHandler(ui_register.onRegAccEvent)
end

function ui_register.removeEvent()
    loginmodel.onRegAccEvent:RemoveHandler(ui_register.onRegAccEvent)
end

--------------------------------------------------------------------------------------------------












-------------------------------------------ui事件-------------------------------------------------

function ui_register.onRegisterBtnClick()
    print("ui_register.onRegisterBtnClick")

    local account = ui_register.uiref.input_account.text
    if not account then
        return
    end

    local password = ui_register.uiref.input_password.text
    if not password then
        return
    end

    ui_register.model.sendreqregacc_cs(account, password)
end

function ui_register.onCloseBtnClick()
    print("ui_register.onCloseBtnClick")

    ui_register.close()

    local ui_login = require("ui.ui_login.ui_login")
    ui_login.show()
end

--------------------------------------------------------------------------------------------------














---------------------------------------------外部事件----------------------------------------------

function ui_register.onRegAccEvent()
    print("ui_register.onRegAccEvent")

    ui_register.close()

    local ui_login = require("ui.ui_login.ui_login")
    ui_login.show()
end

--------------------------------------------------------------------------------------------------














return ui_register;