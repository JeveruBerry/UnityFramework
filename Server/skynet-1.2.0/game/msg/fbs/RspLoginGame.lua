-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: fbs

local flatbuffers = require('flatbuffers')

---@class RspLoginGame
local RspLoginGame = {} -- the module

local RspLoginGame_mt = {} -- the class metatable

RspLoginGame.HashID = 0xE31B3F10FDB63C51;

function RspLoginGame.New()
    local o = {}
    setmetatable(o, {__index = RspLoginGame_mt})
    return o
end

function RspLoginGame.GetRootAsRspLoginGame(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = RspLoginGame.New()
    o:Init(buf, n + offset)
    return o
end

function RspLoginGame.init(buf, offset)
    return RspLoginGame.GetRootAsRspLoginGame(buf, offset)
end

function RspLoginGame_mt:
Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end

function RspLoginGame_mt:Ok()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return (self.view:Get(flatbuffers.N.Bool, o + self.view.pos) ~= 0)
    end
    return false
end

function RspLoginGame.Start(builder) builder:StartObject(1) end
function RspLoginGame.AddOk(builder, ok) builder:PrependBoolSlot(0, ok, 0) end
function RspLoginGame.End(builder) return builder:EndObject() end

return RspLoginGame -- return the module