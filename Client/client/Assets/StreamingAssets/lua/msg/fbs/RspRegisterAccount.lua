-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: fbs

local flatbuffers = require('3rd.flatbuffers')

---@class RspRegisterAccount
local RspRegisterAccount = {} -- the module

local RspRegisterAccount_mt = {} -- the class metatable

RspRegisterAccount.HashID = 0x33536FC3789AF76C;

function RspRegisterAccount.New()
    local o = {}
    setmetatable(o, {__index = RspRegisterAccount_mt})
    return o
end

function RspRegisterAccount.GetRootAsRspRegisterAccount(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = RspRegisterAccount.New()
    o:Init(buf, n + offset)
    return o
end

function RspRegisterAccount.init(buf, offset)
    return RspRegisterAccount.GetRootAsRspRegisterAccount(buf, offset)
end

function RspRegisterAccount_mt:
Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end

function RspRegisterAccount_mt:Ok()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return (self.view:Get(flatbuffers.N.Bool, o + self.view.pos) ~= 0)
    end
    return false
end

function RspRegisterAccount.Start(builder) builder:StartObject(1) end
function RspRegisterAccount.AddOk(builder, ok) builder:PrependBoolSlot(0, ok, 0) end
function RspRegisterAccount.End(builder) return builder:EndObject() end

return RspRegisterAccount -- return the module