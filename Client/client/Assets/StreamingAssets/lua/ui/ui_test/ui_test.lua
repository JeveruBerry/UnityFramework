---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/8/29 22:44
---

---@class ui_test
ui_test = {
}

ui_test.uiname = "ui_panel_test"

---@type testmodel
ui_test.model = require("clientmodel.testmodel.testmodel")


----------------------------------------------内置-------------------------------------------------

function ui_test.show()

    if ui_test.isShow then
        return
    end

    ---@type gtmGame.Dialog
    ui_test.dialog = ui_mgr.createDialog(ui_test.uiname, "ui_test");

    if not ui_test.dialog then
        print("ui_test.dialog null uiname " .. ui_test.uiname);
    end

    ui_test.isShow = true;

    ui_test.initui();
    ui_test.initEvent();
end

function ui_test.close()
    ui_mgr.closeDialog(ui_test.uiname);
end

function ui_test.preShow()
    print("ui_test.preShow")
end

function ui_test.preHide()
    print("ui_test.preHide")
end

function ui_test.preClose()
    print("ui_test.preClose")

    ui_test.isShow = false;
end

--- initui
function ui_test.initui()
    ui_test.uiref = {};

    ui_test.uiref.btn_connectserver = ui_test.dialog:GetButtonInChild(ui_test.dialog.rootDialog, "btn_connectserver");
    ui_test.uiref.btn_sendlogin = ui_test.dialog:GetButtonInChild(ui_test.dialog.rootDialog, "btn_sendlogin");
    ui_test.uiref.btn_sendchat = ui_test.dialog:GetButtonInChild(ui_test.dialog.rootDialog, "btn_sendchat");
    ui_test.uiref.btn_close = ui_test.dialog:GetButtonInChild(ui_test.dialog.rootDialog, "btn_close");
end

--- init event
function ui_test.initEvent()

    ui_test.dialog:AddBtnClickListener(ui_test.uiref.btn_connectserver, ui_test.onConnectServerBtnClick);
    ui_test.dialog:AddBtnClickListener(ui_test.uiref.btn_sendlogin, ui_test.onSendloginBtnClick);
    ui_test.dialog:AddBtnClickListener(ui_test.uiref.btn_sendchat, ui_test.onSendchatBtnClick);
    ui_test.dialog:AddBtnClickListener(ui_test.uiref.btn_close, ui_test.onCloseBtnClick);

end

--------------------------------------------------------------------------------------------------












-------------------------------------------ui事件-------------------------------------------------

function ui_test.onConnectServerBtnClick()
    print("ui_test.onConnectServerBtnClick");

    global.INetManager:SendConnect("192.168.0.108", "8888");
end

function ui_test.onSendloginBtnClick()
    print("ui_test.onSendloginBtnClick");

    testmodel.sendreqlogin_cs(
            "黄河远上白云间，一片孤城万仞山。" ..
                    "羌笛何须怨杨柳，春风不度玉门关。秦时明月汉时关，万里长征人未还。" ..
                    "但使龙城飞将在，不教胡马度阴山。",
            "洛阳女儿对门居，才可颜容十五余。" ..
                    "良人玉勒乘骢马，侍女金盘脍鲤鱼。" ..
                    "画阁朱楼尽相望，红桃绿柳垂檐向。" ..
                    "罗帷送上七香车，宝扇迎归九华帐。" ..
                    "狂夫富贵在青春，意气骄奢剧季伦。" ..
                    "自怜碧玉亲教舞，不惜珊瑚持与人。" ..
                    "春窗曙灭九微火，九微片片飞花琐。" ..
                    "戏罢曾无理曲时，妆成祗是熏香坐。" ..
                    "城中相识尽繁华，日夜经过赵李家。" ..
                    "谁怜越女颜如玉，贫贱江头自浣纱。");
end

function ui_test.onSendchatBtnClick()
    print("ui_test.onSendchatBtnClick");

    testmodel.sendreqchat_cs(
            "白日依山尽，黄河入海流。欲穷千里目，更上一层楼。" ..
                    "红豆生南国，春来发几枝。愿君多采撷，此物最相思。" ..
                    "松下问童子，言师采药去。只在此山中，云深不知处。");
end

function ui_test.onCloseBtnClick()
    print("ui_test.onCloseBtnClick");

    ui_test.close();
end

--------------------------------------------------------------------------------------------------
















return ui_test;