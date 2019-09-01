---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 12:20
---

local baseclass = require("base.baseclass")
local basestate = require("gamestate.basestate")
local event = require("base.eventlib")

---@class gamestate
gamestate = baseclass(basestate)

gamestate.evententer = event:new()
gamestate.eventrefresh= event.new()
gamestate.eventexit = event.new()

function gamestate.new()
    print("gamestate.new")
end

function gamestate.onEnter()
    print("gamestate.onEnter")

    gamestate.evententer:Fire()
end

function gamestate.onExit()
    print("gamestate.onExit")

    gamestate.evententer:Fire()
end

function gamestate.onRefresh()
    print("gamestate.onRefresh")

    gamestate.eventrefresh:Fire()
end

return gamestate