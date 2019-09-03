-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: fbs

local flatbuffers = require('3rd.flatbuffers')

---@class RspLoginAccount
local RspLoginAccount = {} -- the module

local RspLoginAccount_mt = {} -- the class metatable

RspLoginAccount.HashID = 0x3355878600CA4D08;

function RspLoginAccount.New()
    local o = {}
    setmetatable(o, {__index = RspLoginAccount_mt})
    return o
end

function RspLoginAccount.GetRootAsRspLoginAccount(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = RspLoginAccount.New()
    o:Init(buf, n + offset)
    return o
end

function RspLoginAccount.init(buf, offset)
    return RspLoginAccount.GetRootAsRspLoginAccount(buf, offset)
end

function RspLoginAccount_mt:
Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end

function RspLoginAccount_mt:Ok()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return (self.view:Get(flatbuffers.N.Bool, o + self.view.pos) ~= 0)
    end
    return false
end

function RspLoginAccount.Start(builder) builder:StartObject(1) end
function RspLoginAccount.AddOk(builder, ok) builder:PrependBoolSlot(0, ok, 0) end
function RspLoginAccount.End(builder) return builder:EndObject() end

return RspLoginAccount -- return the module